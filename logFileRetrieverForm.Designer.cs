using System;
namespace Read_Rio_Log
{
    partial class logFileRetrieverMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logFileRetrieverMainForm));
            this.retrieveLogButton = new System.Windows.Forms.Button();
            this.SaveToLabel = new System.Windows.Forms.Label();
            this.browseToLocationButton = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.IPAddressLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.optionsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.downloadFromTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.downloadToTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.IPAddressTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.testConnectionButton = new System.Windows.Forms.Button();
            this.notConectedTextBox = new System.Windows.Forms.TextBox();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.DeleteFilesFromRobotOption = new System.Windows.Forms.CheckBox();
            this.optionsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // retrieveLogButton
            // 
            this.retrieveLogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.retrieveLogButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.retrieveLogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retrieveLogButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrieveLogButton.Location = new System.Drawing.Point(359, 192);
            this.retrieveLogButton.MaximumSize = new System.Drawing.Size(131, 45);
            this.retrieveLogButton.MinimumSize = new System.Drawing.Size(114, 30);
            this.retrieveLogButton.Name = "retrieveLogButton";
            this.retrieveLogButton.Size = new System.Drawing.Size(131, 30);
            this.retrieveLogButton.TabIndex = 0;
            this.retrieveLogButton.Text = "Download Files";
            this.retrieveLogButton.UseVisualStyleBackColor = false;
            this.retrieveLogButton.Click += new System.EventHandler(this.retrieveLogButton_Click);
            // 
            // SaveToLabel
            // 
            this.SaveToLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SaveToLabel.AutoSize = true;
            this.SaveToLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveToLabel.Location = new System.Drawing.Point(3, 6);
            this.SaveToLabel.Name = "SaveToLabel";
            this.SaveToLabel.Size = new System.Drawing.Size(93, 18);
            this.SaveToLabel.TabIndex = 2;
            this.SaveToLabel.Text = "Download to:";
            // 
            // browseToLocationButton
            // 
            this.browseToLocationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseToLocationButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.browseToLocationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseToLocationButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseToLocationButton.Location = new System.Drawing.Point(359, 10);
            this.browseToLocationButton.MaximumSize = new System.Drawing.Size(131, 45);
            this.browseToLocationButton.MinimumSize = new System.Drawing.Size(114, 30);
            this.browseToLocationButton.Name = "browseToLocationButton";
            this.browseToLocationButton.Size = new System.Drawing.Size(131, 30);
            this.browseToLocationButton.TabIndex = 3;
            this.browseToLocationButton.Text = "Browse...";
            this.browseToLocationButton.UseVisualStyleBackColor = false;
            this.browseToLocationButton.Click += new System.EventHandler(this.browseToLocationButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.usernameLabel.Location = new System.Drawing.Point(3, 36);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(80, 18);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(3, 66);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(74, 18);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password:";
            // 
            // IPAddressLabel
            // 
            this.IPAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IPAddressLabel.AutoSize = true;
            this.IPAddressLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPAddressLabel.Location = new System.Drawing.Point(3, 96);
            this.IPAddressLabel.Name = "IPAddressLabel";
            this.IPAddressLabel.Size = new System.Drawing.Size(84, 18);
            this.IPAddressLabel.TabIndex = 13;
            this.IPAddressLabel.Text = "IP Address:";
            // 
            // portLabel
            // 
            this.portLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel.Location = new System.Drawing.Point(3, 126);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(39, 18);
            this.portLabel.TabIndex = 14;
            this.portLabel.Text = "Port:";
            // 
            // optionsLayout
            // 
            this.optionsLayout.AutoSize = true;
            this.optionsLayout.ColumnCount = 2;
            this.optionsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.58199F));
            this.optionsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.41801F));
            this.optionsLayout.Controls.Add(this.downloadFromTextBox, 1, 5);
            this.optionsLayout.Controls.Add(this.label1, 0, 5);
            this.optionsLayout.Controls.Add(this.portLabel, 0, 4);
            this.optionsLayout.Controls.Add(this.SaveToLabel, 0, 0);
            this.optionsLayout.Controls.Add(this.IPAddressLabel, 0, 3);
            this.optionsLayout.Controls.Add(this.downloadToTextBox, 1, 0);
            this.optionsLayout.Controls.Add(this.passwordLabel, 0, 2);
            this.optionsLayout.Controls.Add(this.usernameLabel, 0, 1);
            this.optionsLayout.Controls.Add(this.portTextBox, 1, 4);
            this.optionsLayout.Controls.Add(this.IPAddressTextBox, 1, 3);
            this.optionsLayout.Controls.Add(this.passwordTextBox, 1, 2);
            this.optionsLayout.Controls.Add(this.usernameTextBox, 1, 1);
            this.optionsLayout.Location = new System.Drawing.Point(12, 9);
            this.optionsLayout.Name = "optionsLayout";
            this.optionsLayout.RowCount = 6;
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.optionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.optionsLayout.Size = new System.Drawing.Size(341, 183);
            this.optionsLayout.TabIndex = 15;
            // 
            // downloadFromTextBox
            // 
            this.downloadFromTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.downloadFromTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Read_Rio_Log.Properties.Settings.Default, "filePathSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.downloadFromTextBox.Location = new System.Drawing.Point(103, 154);
            this.downloadFromTextBox.Name = "downloadFromTextBox";
            this.downloadFromTextBox.Size = new System.Drawing.Size(234, 24);
            this.downloadFromTextBox.TabIndex = 15;
            this.downloadFromTextBox.Text = global::Read_Rio_Log.Properties.Settings.Default.filePathSetting;
            this.downloadFromTextBox.TextChanged += new System.EventHandler(this.setting_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(3, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "RIO File:";
            // 
            // downloadToTextBox
            // 
            this.downloadToTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.downloadToTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Read_Rio_Log.Properties.Settings.Default, "LocalPathSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.downloadToTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadToTextBox.Location = new System.Drawing.Point(103, 3);
            this.downloadToTextBox.Name = "downloadToTextBox";
            this.downloadToTextBox.Size = new System.Drawing.Size(234, 24);
            this.downloadToTextBox.TabIndex = 1;
            this.downloadToTextBox.Text = global::Read_Rio_Log.Properties.Settings.Default.LocalPathSetting;
            this.downloadToTextBox.TextChanged += new System.EventHandler(this.setting_TextChanged);
            // 
            // portTextBox
            // 
            this.portTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.portTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Read_Rio_Log.Properties.Settings.Default, "portSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portTextBox.Location = new System.Drawing.Point(103, 123);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(73, 24);
            this.portTextBox.TabIndex = 10;
            this.portTextBox.Text = global::Read_Rio_Log.Properties.Settings.Default.portSetting;
            this.portTextBox.TextChanged += new System.EventHandler(this.setting_TextChanged);
            // 
            // IPAddressTextBox
            // 
            this.IPAddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IPAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Read_Rio_Log.Properties.Settings.Default, "IPAddressSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IPAddressTextBox.Location = new System.Drawing.Point(103, 93);
            this.IPAddressTextBox.Name = "IPAddressTextBox";
            this.IPAddressTextBox.Size = new System.Drawing.Size(234, 24);
            this.IPAddressTextBox.TabIndex = 9;
            this.IPAddressTextBox.Text = global::Read_Rio_Log.Properties.Settings.Default.IPAddressSetting;
            this.IPAddressTextBox.TextChanged += new System.EventHandler(this.setting_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Read_Rio_Log.Properties.Settings.Default, "passwordSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.passwordTextBox.Location = new System.Drawing.Point(103, 63);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(234, 24);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.Text = global::Read_Rio_Log.Properties.Settings.Default.passwordSetting;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.setting_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Read_Rio_Log.Properties.Settings.Default, "usernameSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.usernameTextBox.Location = new System.Drawing.Point(103, 33);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(234, 24);
            this.usernameTextBox.TabIndex = 7;
            this.usernameTextBox.Text = global::Read_Rio_Log.Properties.Settings.Default.usernameSetting;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.setting_TextChanged);
            // 
            // testConnectionButton
            // 
            this.testConnectionButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.testConnectionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testConnectionButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testConnectionButton.Location = new System.Drawing.Point(359, 161);
            this.testConnectionButton.Name = "testConnectionButton";
            this.testConnectionButton.Size = new System.Drawing.Size(131, 30);
            this.testConnectionButton.TabIndex = 16;
            this.testConnectionButton.Text = "Connect";
            this.testConnectionButton.UseVisualStyleBackColor = false;
            this.testConnectionButton.Click += new System.EventHandler(this.testConnectionButton_Click);
            // 
            // notConectedTextBox
            // 
            this.notConectedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notConectedTextBox.CausesValidation = false;
            this.notConectedTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notConectedTextBox.ForeColor = System.Drawing.Color.Red;
            this.notConectedTextBox.Location = new System.Drawing.Point(359, 47);
            this.notConectedTextBox.Multiline = true;
            this.notConectedTextBox.Name = "notConectedTextBox";
            this.notConectedTextBox.Size = new System.Drawing.Size(131, 44);
            this.notConectedTextBox.TabIndex = 17;
            this.notConectedTextBox.Text = "Could not connect to roboRIO";
            this.notConectedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.notConectedTextBox.Visible = false;
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveSettingsButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSettingsButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.saveSettingsButton.Location = new System.Drawing.Point(359, 128);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(131, 30);
            this.saveSettingsButton.TabIndex = 18;
            this.saveSettingsButton.Text = "Save Settings";
            this.saveSettingsButton.UseVisualStyleBackColor = false;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // DeleteFilesFromRobotOption
            // 
            this.DeleteFilesFromRobotOption.AutoSize = true;
            this.DeleteFilesFromRobotOption.Checked = global::Read_Rio_Log.Properties.Settings.Default.removeFilesSetting;
            this.DeleteFilesFromRobotOption.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Read_Rio_Log.Properties.Settings.Default, "removeFilesSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DeleteFilesFromRobotOption.Location = new System.Drawing.Point(12, 198);
            this.DeleteFilesFromRobotOption.Name = "DeleteFilesFromRobotOption";
            this.DeleteFilesFromRobotOption.Size = new System.Drawing.Size(347, 21);
            this.DeleteFilesFromRobotOption.TabIndex = 19;
            this.DeleteFilesFromRobotOption.Text = "Remove files from robot when download completes.";
            this.DeleteFilesFromRobotOption.UseVisualStyleBackColor = true;
            // 
            // logFileRetrieverMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(497, 229);
            this.Controls.Add(this.DeleteFilesFromRobotOption);
            this.Controls.Add(this.optionsLayout);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.notConectedTextBox);
            this.Controls.Add(this.testConnectionButton);
            this.Controls.Add(this.browseToLocationButton);
            this.Controls.Add(this.retrieveLogButton);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "logFileRetrieverMainForm";
            this.Text = "501 Log File Retriever";
            this.optionsLayout.ResumeLayout(false);
            this.optionsLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button retrieveLogButton;
        private System.Windows.Forms.TextBox downloadToTextBox;
        private System.Windows.Forms.Label SaveToLabel;
        private System.Windows.Forms.Button browseToLocationButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox IPAddressTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label IPAddressLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TableLayoutPanel optionsLayout;
        private System.Windows.Forms.Button testConnectionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox downloadFromTextBox;
        private System.Windows.Forms.TextBox notConectedTextBox;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.CheckBox DeleteFilesFromRobotOption;
    }
}

