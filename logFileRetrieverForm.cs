using System;
using RoboRio501;
using System.Windows.Forms;

namespace Read_Rio_Log
{
    public partial class logFileRetrieverMainForm : Form
    {

        public logFileRetrieverMainForm()
        {
            InitializeComponent();
            downloadToTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
        
        public string roboRioAddress { get; private set; }

        private RoboRioConnection robotConnection;

        private const string SAVE_SETTING_BUTTON_TEXT = "Save Settings";
        private const string SAVE_SETTING_BUTTON_TEXT_ALT = "Saved";
        private const string CONNECT_TO_ROBOT_BUTTON = "Connect";
        private const string CONNECT_TO_ROBOT_BUTTON_ALT = "Connected";

        private void browseToLocationButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                downloadToTextBox.Text = folderBrowser.SelectedPath;
            }
        }

        private void initConnection()
        {
            // Get connection values from the form
            string downloadToDirectory = this.downloadToTextBox.Text;
            string username = this.usernameTextBox.Text;
            string password = this.passwordTextBox.Text;
            string ipAddress = this.IPAddressTextBox.Text;
            string downloadFromDirectory = this.downloadFromTextBox.Text;
            int port;
            Int32.TryParse(this.portTextBox.Text, out port);

            // Setup the Rio Connection
            robotConnection = RoboRioConnection.Instance;
            RoboRioConnection.InitializeConnection(ipAddress, username, password, port);
        }

        private void retrieveLogButton_Click(object sender, EventArgs e)
        {
            this.testConnectionButton.Cursor = System.Windows.Forms.Cursors.AppStarting;

            // initilize roboRIO connection
            initConnection();

            // Test the connection
            notConectedTextBox.Visible = robotConnection.CanConnect;

            // Local file directory
            string localDirectory = this.downloadToTextBox.Text;

            // roboRIO file directory
            string rioDirectory = this.downloadFromTextBox.Text;

            // Delete files as they are downloaded
            bool deleteOnDownLoad = this.DeleteFilesFromRobotOption.Checked;

            // get files
            bool successfullDownLoad = robotConnection.GetFilesFromRio(rioDirectory, localDirectory, deleteOnDownLoad);

            this.notConectedTextBox.Visible = !successfullDownLoad;
            if (successfullDownLoad)
            {
                retrieveLogButton.Text = "Complete";
            }
            
            this.testConnectionButton.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        // What heppens when text is changed event handeler
        private void setting_TextChanged(object sender, EventArgs e)
        {
            this.saveSettingsButton.Text = SAVE_SETTING_BUTTON_TEXT;
            this.testConnectionButton.Text = CONNECT_TO_ROBOT_BUTTON;

            this.saveSettingsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.testConnectionButton.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        // Save current settings event handeler
        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.saveSettingsButton.Text = SAVE_SETTING_BUTTON_TEXT_ALT;
            this.saveSettingsButton.ForeColor = System.Drawing.SystemColors.GrayText;
        }

        // Test connection to the robot event handeler
        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            this.testConnectionButton.Cursor = System.Windows.Forms.Cursors.AppStarting;

            robotConnection = RoboRioConnection.Instance;
            initConnection();

            this.notConectedTextBox.Visible = !robotConnection.CanConnect;

            if(robotConnection.CanConnect)
            {
                this.testConnectionButton.Text = CONNECT_TO_ROBOT_BUTTON_ALT;
                this.testConnectionButton.ForeColor = System.Drawing.SystemColors.GrayText;
            }

            this.testConnectionButton.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}
