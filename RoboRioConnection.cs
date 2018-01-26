using System.Net;
using System.IO;
using System.Linq;
using Renci.SshNet;
using System.Net.NetworkInformation;
using System;
using System.Text.RegularExpressions;

namespace RoboRio501
{
    /// <summary>
    /// Provides functionality to get and remove files from a roboRIO using SFTP
    /// </summary>
    class RoboRioConnection
    {
        #region Construction

        private RoboRioConnection() { /* All work done in initializeConnection() */ }

        #endregion

        #region Properties

        /// <summary>
        /// Only one instance of a connection can be created. This will create an instance
        /// of the connection if it hasn't already been created. (Singelton design pattern)
        /// </summary>
        public static RoboRioConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoboRioConnection();
                }

                return instance;
            }
        }

        /// <summary>
        /// Test the connection to the robot.
        /// </summary>
        public bool CanConnect => TestConnection();

        #endregion

        #region fields

        // Singelton instance
        private static RoboRioConnection instance;

        // true when the connection settings username, password, port, and host have been set.
        private static bool isInitialized = false;

        // SFTP connector over SSH
        private static SftpClient sftpClient;

        public bool? canConnect { get; set; }

        private static IPAddress _host;
        private static string _username;
        private static string _password;
        private static int _port;

        #endregion

        #region Methods

        /// <summary>
        /// Set the values needed for connecting to the server through SFTP.
        /// </summary>
        /// <param name="host"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="port"></param>
        public static void InitializeConnection(IPAddress host, string username, string password, int port)
        {
            _host = host;
            _username = username;
            _password = password;
            _port = port;

            sftpClient = new SftpClient(host.ToString(), port, username, password);

            isInitialized = true;
        }

        /// <summary>
        /// Set the values needed for connecting to the server through SFTP.
        /// </summary>
        /// <param name="host"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="port"></param>
        public static void InitializeConnection(string host, string username, string password, int port)
        {
            // Try to turn the host value into an IP address
            IPAddress IP;
            if (IPAddress.TryParse(host, out IP))
            {
                InitializeConnection(IP, username, password, port);
            }
        }

        /// <summary>
        /// Test the connection to the server using the server's IP address.
        /// </summary>
        /// <returns></returns>
        public bool TestConnection()
        {
            this.canConnect = false;

            // Ensure that the connection is initialized.
            if (!isInitialized)
                return false;

            // Ping the server
            Ping ping = new Ping();
            var pingTest = ping.Send(_host);
            if (pingTest.Status != IPStatus.Success)
            {
                return false;
            }

            // Try to log in
            try
            {
                sftpClient.Connect();
                sftpClient.Disconnect();
            }
            catch
            {
                return false;
            }

            this.canConnect = true;
            return true;
        }

        /// <summary>
        /// Opens a connection to the RoboRio and gets all the files in the specified file path.
        /// </summary>
        /// <param name="RoboRioFileDirectory">File path where the log files are located on the robots server</param>
        /// <param name="localDirectory">Local file path</param>
        /// <param name="removeFiles">If true remove files from the robot after file transfer is complete</param>
        /// <returns>true if files were successfully transfered.</returns>
        public bool GetFilesFromRio(
            string RoboRioFileDirectory,
            string localDirectory,
            string matchNumber,
            bool removeFiles, 
            out int filesRetrieved,
            out int filesSkipped)
        {
            filesSkipped = 0;
            filesRetrieved = 0;

            try
            {
                sftpClient.Connect();
            }
            catch
            {
                // failed to connect
                return false;
            }

            // Get a list of the files from the specified folder (. and .. are directory pointers)
            var remoteFileNames = sftpClient.ListDirectory(RoboRioFileDirectory)
                .Where(x => x.Name != "." && x.Name != "..");

            // Order by write date
            var AllFilesButTheNewest = remoteFileNames
                .OrderByDescending(file => file.LastWriteTime)
                .Skip(1);

            string firstFileName = string.Empty;
            if (AllFilesButTheNewest.Count() > 0)
                firstFileName = $"{AllFilesButTheNewest.First().LastWriteTime:yyyy-MM-dd HHMMss} {AllFilesButTheNewest.First().Name}";

            // iterate through all valid files
            foreach (var RIOfile in AllFilesButTheNewest)
            {
                var writeTime = RIOfile.LastWriteTime;
                string newName = $"{writeTime:yyyy-MM-dd HHMMss} {RIOfile.Name}";

                // Handel adding match number to first file
                if(newName == firstFileName)
                {
                    // DateTime log name matchNumber fileExtention
                    string prefix = newName.Substring(0, newName.LastIndexOf('.'));
                    string extention = newName.Substring(newName.LastIndexOf('.'));

                    // Remove invalid characters from match number
                    Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                    matchNumber = rgx.Replace(matchNumber, "");

                    newName = $"{prefix} {matchNumber}{extention}";
                }

                string newFile = Path.Combine(localDirectory, newName);
                try
                {
                    using (var file = File.OpenWrite(newFile))
                    {
                        sftpClient.DownloadFile(RIOfile.FullName, file);

                        if (removeFiles)
                        {
                            sftpClient.DeleteFile(RIOfile.FullName);
                        }
                    }
                }
                catch(Exception e)
                {
                    // Skip the failed file 
                    ++filesSkipped;
                    continue;
                }

                ++filesRetrieved;
            }

            // Disconnect from FTP connection
            sftpClient.Disconnect();

            // Successful download
            return true;
        }

        #endregion
    }
}
