namespace Spectate
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.summonerNameTextBox = new System.Windows.Forms.TextBox();
            this.summonerNameLabel = new System.Windows.Forms.Label();
            this.regionsComboBox = new System.Windows.Forms.ComboBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.statusButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusInformationLabel = new System.Windows.Forms.Label();
            this.spectateButton = new System.Windows.Forms.Button();
            this.spectateLabel = new System.Windows.Forms.Label();
            this.extrasButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // summonerNameTextBox
            // 
            this.summonerNameTextBox.Location = new System.Drawing.Point(107, 12);
            this.summonerNameTextBox.MaxLength = 25;
            this.summonerNameTextBox.Name = "summonerNameTextBox";
            this.summonerNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.summonerNameTextBox.Size = new System.Drawing.Size(152, 20);
            this.summonerNameTextBox.TabIndex = 0;
            // 
            // summonerNameLabel
            // 
            this.summonerNameLabel.AutoSize = true;
            this.summonerNameLabel.Location = new System.Drawing.Point(12, 15);
            this.summonerNameLabel.Name = "summonerNameLabel";
            this.summonerNameLabel.Size = new System.Drawing.Size(89, 13);
            this.summonerNameLabel.TabIndex = 1;
            this.summonerNameLabel.Text = "Summoner name:";
            // 
            // regionsComboBox
            // 
            this.regionsComboBox.FormattingEnabled = true;
            this.regionsComboBox.Location = new System.Drawing.Point(170, 38);
            this.regionsComboBox.Name = "regionsComboBox";
            this.regionsComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.regionsComboBox.Size = new System.Drawing.Size(89, 21);
            this.regionsComboBox.TabIndex = 2;
            this.regionsComboBox.Text = "No Region";
            this.regionsComboBox.SelectionChangeCommitted += new System.EventHandler(this.regionsComboBox_SelectionChangeCommitted);
            this.regionsComboBox.TextUpdate += new System.EventHandler(this.regionsComboBox_TextUpdate);
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(12, 42);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(44, 13);
            this.regionLabel.TabIndex = 3;
            this.regionLabel.Text = "Region:";
            // 
            // statusButton
            // 
            this.statusButton.Enabled = false;
            this.statusButton.Location = new System.Drawing.Point(169, 69);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(90, 25);
            this.statusButton.TabIndex = 4;
            this.statusButton.Text = "Check status";
            this.statusButton.UseVisualStyleBackColor = true;
            this.statusButton.Click += new System.EventHandler(this.statusButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 75);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Status:";
            // 
            // statusInformationLabel
            // 
            this.statusInformationLabel.AutoSize = true;
            this.statusInformationLabel.Location = new System.Drawing.Point(48, 75);
            this.statusInformationLabel.Name = "statusInformationLabel";
            this.statusInformationLabel.Size = new System.Drawing.Size(68, 13);
            this.statusInformationLabel.TabIndex = 6;
            this.statusInformationLabel.Text = "Not retrieved";
            // 
            // spectateButton
            // 
            this.spectateButton.Enabled = false;
            this.spectateButton.Location = new System.Drawing.Point(170, 100);
            this.spectateButton.Name = "spectateButton";
            this.spectateButton.Size = new System.Drawing.Size(89, 26);
            this.spectateButton.TabIndex = 7;
            this.spectateButton.Text = "Spectate";
            this.spectateButton.UseVisualStyleBackColor = true;
            this.spectateButton.Click += new System.EventHandler(this.spectateButton_Click);
            // 
            // spectateLabel
            // 
            this.spectateLabel.AutoSize = true;
            this.spectateLabel.Location = new System.Drawing.Point(12, 107);
            this.spectateLabel.Name = "spectateLabel";
            this.spectateLabel.Size = new System.Drawing.Size(154, 13);
            this.spectateLabel.TabIndex = 8;
            this.spectateLabel.Text = "Spectate a specific Summoner:";
            // 
            // extrasButton
            // 
            this.extrasButton.Location = new System.Drawing.Point(15, 135);
            this.extrasButton.Name = "extrasButton";
            this.extrasButton.Size = new System.Drawing.Size(89, 26);
            this.extrasButton.TabIndex = 10;
            this.extrasButton.Text = "Extras";
            this.extrasButton.UseVisualStyleBackColor = true;
            this.extrasButton.Click += new System.EventHandler(this.extrasButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(170, 135);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(89, 26);
            this.optionsButton.TabIndex = 11;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 58);
            this.label1.TabIndex = 12;
            this.label1.Text = "This application uses the official Riot servers directly to get the spectator dat" +
    "a. No 3rd Party service is being used and your account data is stored only on yo" +
    "ur computer.";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(268, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.extrasButton);
            this.Controls.Add(this.spectateLabel);
            this.Controls.Add(this.spectateButton);
            this.Controls.Add(this.statusInformationLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.regionsComboBox);
            this.Controls.Add(this.summonerNameLabel);
            this.Controls.Add(this.summonerNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Spectate";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox summonerNameTextBox;
        private System.Windows.Forms.Label summonerNameLabel;
        private System.Windows.Forms.ComboBox regionsComboBox;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label statusInformationLabel;
        private System.Windows.Forms.Button spectateButton;
        private System.Windows.Forms.Label spectateLabel;
        private System.Windows.Forms.Button extrasButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button statusButton;
    }
}

