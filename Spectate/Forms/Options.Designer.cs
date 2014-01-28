namespace Spectate
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.batFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.accountManagementGroup = new System.Windows.Forms.GroupBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.saveAccButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.accountNameTextBox = new System.Windows.Forms.TextBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.regionLabel = new System.Windows.Forms.Label();
            this.regionsComboBox = new System.Windows.Forms.ComboBox();
            this.NoticeLabel = new System.Windows.Forms.Label();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.generalGroup = new System.Windows.Forms.GroupBox();
            this.setRadPathButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.exampleLabel = new System.Windows.Forms.Label();
            this.radsPathTextBox = new System.Windows.Forms.TextBox();
            this.accountManagementGroup.SuspendLayout();
            this.generalGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // batFilesCheckBox
            // 
            this.batFilesCheckBox.AutoSize = true;
            this.batFilesCheckBox.Location = new System.Drawing.Point(6, 19);
            this.batFilesCheckBox.Name = "batFilesCheckBox";
            this.batFilesCheckBox.Size = new System.Drawing.Size(140, 17);
            this.batFilesCheckBox.TabIndex = 0;
            this.batFilesCheckBox.Text = "Delete bat files after use";
            this.batFilesCheckBox.UseVisualStyleBackColor = true;
            this.batFilesCheckBox.CheckedChanged += new System.EventHandler(this.batFiles_CheckedChanged);
            // 
            // accountManagementGroup
            // 
            this.accountManagementGroup.Controls.Add(this.resultLabel);
            this.accountManagementGroup.Controls.Add(this.checkButton);
            this.accountManagementGroup.Controls.Add(this.saveAccButton);
            this.accountManagementGroup.Controls.Add(this.passwordTextBox);
            this.accountManagementGroup.Controls.Add(this.passwordLabel);
            this.accountManagementGroup.Controls.Add(this.accountNameTextBox);
            this.accountManagementGroup.Controls.Add(this.accountLabel);
            this.accountManagementGroup.Controls.Add(this.regionLabel);
            this.accountManagementGroup.Controls.Add(this.regionsComboBox);
            this.accountManagementGroup.Controls.Add(this.NoticeLabel);
            this.accountManagementGroup.Location = new System.Drawing.Point(12, 12);
            this.accountManagementGroup.Name = "accountManagementGroup";
            this.accountManagementGroup.Size = new System.Drawing.Size(216, 222);
            this.accountManagementGroup.TabIndex = 2;
            this.accountManagementGroup.TabStop = false;
            this.accountManagementGroup.Text = "Account Managament";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(112, 141);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(98, 13);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "Status: Not running";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(11, 134);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(102, 27);
            this.checkButton.TabIndex = 8;
            this.checkButton.Text = "Check connection";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // saveAccButton
            // 
            this.saveAccButton.Location = new System.Drawing.Point(71, 97);
            this.saveAccButton.Name = "saveAccButton";
            this.saveAccButton.Size = new System.Drawing.Size(139, 29);
            this.saveAccButton.TabIndex = 7;
            this.saveAccButton.Text = "Save account information";
            this.saveAccButton.UseVisualStyleBackColor = true;
            this.saveAccButton.Click += new System.EventHandler(this.saveAccountInfo_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(88, 71);
            this.passwordTextBox.MaxLength = 16;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(122, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(6, 74);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // accountNameTextBox
            // 
            this.accountNameTextBox.Location = new System.Drawing.Point(88, 45);
            this.accountNameTextBox.MaxLength = 25;
            this.accountNameTextBox.Name = "accountNameTextBox";
            this.accountNameTextBox.Size = new System.Drawing.Size(122, 20);
            this.accountNameTextBox.TabIndex = 4;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(6, 48);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(76, 13);
            this.accountLabel.TabIndex = 3;
            this.accountLabel.Text = "Account name";
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(6, 22);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(41, 13);
            this.regionLabel.TabIndex = 2;
            this.regionLabel.Text = "Region";
            // 
            // regionsComboBox
            // 
            this.regionsComboBox.FormattingEnabled = true;
            this.regionsComboBox.Location = new System.Drawing.Point(153, 19);
            this.regionsComboBox.Name = "regionsComboBox";
            this.regionsComboBox.Size = new System.Drawing.Size(57, 21);
            this.regionsComboBox.TabIndex = 1;
            this.regionsComboBox.SelectionChangeCommitted += new System.EventHandler(this.regionsComboBox_SelectionChangeCommitted);
            // 
            // NoticeLabel
            // 
            this.NoticeLabel.Location = new System.Drawing.Point(4, 164);
            this.NoticeLabel.Name = "NoticeLabel";
            this.NoticeLabel.Size = new System.Drawing.Size(205, 55);
            this.NoticeLabel.TabIndex = 0;
            this.NoticeLabel.Text = "Warning: All of your account data is saved to your computer as plain text, which " +
    "means anyone accessing your files is able to get all of that information.";
            this.NoticeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFolderButton
            // 
            this.openFolderButton.Location = new System.Drawing.Point(12, 254);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(146, 23);
            this.openFolderButton.TabIndex = 3;
            this.openFolderButton.Text = "Open configuration folder";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.openFolderButton_Click);
            // 
            // generalGroup
            // 
            this.generalGroup.Controls.Add(this.batFilesCheckBox);
            this.generalGroup.Location = new System.Drawing.Point(234, 12);
            this.generalGroup.Name = "generalGroup";
            this.generalGroup.Size = new System.Drawing.Size(216, 48);
            this.generalGroup.TabIndex = 4;
            this.generalGroup.TabStop = false;
            this.generalGroup.Text = "General Options";
            // 
            // setRadPathButton
            // 
            this.setRadPathButton.Location = new System.Drawing.Point(6, 138);
            this.setRadPathButton.Name = "setRadPathButton";
            this.setRadPathButton.Size = new System.Drawing.Size(92, 24);
            this.setRadPathButton.TabIndex = 5;
            this.setRadPathButton.Text = "Set RAD path";
            this.setRadPathButton.UseVisualStyleBackColor = true;
            this.setRadPathButton.Click += new System.EventHandler(this.setRadPathButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.infoLabel1);
            this.groupBox1.Controls.Add(this.exampleLabel);
            this.groupBox1.Controls.Add(this.radsPathTextBox);
            this.groupBox1.Controls.Add(this.setRadPathButton);
            this.groupBox1.Location = new System.Drawing.Point(234, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 168);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RAD Path";
            // 
            // infoLabel1
            // 
            this.infoLabel1.Location = new System.Drawing.Point(8, 97);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(208, 27);
            this.infoLabel1.TabIndex = 8;
            this.infoLabel1.Text = "You only have to set this if the application can\'t find your League setup on its " +
    "own.";
            // 
            // exampleLabel
            // 
            this.exampleLabel.Location = new System.Drawing.Point(8, 51);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(201, 28);
            this.exampleLabel.TabIndex = 7;
            this.exampleLabel.Text = "Rad path example: H:\\LOL\\Game\\League of Legends\\rads";
            // 
            // radsPathTextBox
            // 
            this.radsPathTextBox.Location = new System.Drawing.Point(11, 23);
            this.radsPathTextBox.Name = "radsPathTextBox";
            this.radsPathTextBox.Size = new System.Drawing.Size(198, 20);
            this.radsPathTextBox.TabIndex = 6;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 289);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.generalGroup);
            this.Controls.Add(this.openFolderButton);
            this.Controls.Add(this.accountManagementGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
            this.Load += new System.EventHandler(this.Options_Load);
            this.accountManagementGroup.ResumeLayout(false);
            this.accountManagementGroup.PerformLayout();
            this.generalGroup.ResumeLayout(false);
            this.generalGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox batFilesCheckBox;
        private System.Windows.Forms.GroupBox accountManagementGroup;
        private System.Windows.Forms.Label NoticeLabel;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.ComboBox regionsComboBox;
        private System.Windows.Forms.Button openFolderButton;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.TextBox accountNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button saveAccButton;
        private System.Windows.Forms.GroupBox generalGroup;
        private System.Windows.Forms.Button setRadPathButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox radsPathTextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label exampleLabel;
        private System.Windows.Forms.Label infoLabel1;
    }
}