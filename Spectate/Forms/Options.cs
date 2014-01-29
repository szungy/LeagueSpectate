using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spectate
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.OptionsFormInstance = null;
        }

        private void Options_Load(object sender, EventArgs e)
        {
            batFilesCheckBox.Checked = (Boolean)Configuration.GetValue("deleteBats");
            regionsComboBox.DataSource = new BindingSource() { DataSource = AccountManager.GetRegions() };
            radsPathTextBox.Text = Configuration.GetValue("radsPath").ToString();
        }

        private void batFiles_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.SetValue("deleteBats", batFilesCheckBox.Checked);
            Configuration.SaveConfiguration();
        }

        private void saveAccountInfo_Click(object sender, EventArgs e)
        {
            if (accountNameTextBox.Text.Length > 0 && passwordTextBox.Text.Length > 0)
            {
                String regionText = regionsComboBox.SelectedItem.ToString();
                Configuration.SetValue(regionText + "acc", new Account(accountNameTextBox.Text, passwordTextBox.Text, Account.ParseRegionString(regionText)));
                Configuration.SaveConfiguration();

                AccountManager.Load(Configuration.GetAccounts(), true);
                MainForm.MainFormInstance.regionsComboBox_SelectionChangeCommitted(sender, e);
                MessageBox.Show("Account information saved!");
            }
            else
                MessageBox.Show("Empty summoner name or password!");
        }

        private void openFolderButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = Configuration.GetDefaultFolder(),
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void regionsComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Region selected = (Region)Enum.Parse(typeof(Region), regionsComboBox.SelectedItem.ToString());

            if (AccountManager.HaveAccountForRegion(selected))
            {
                accountNameTextBox.Text = AccountManager.GetAccount(selected).Name;
                passwordTextBox.Text = AccountManager.GetAccount(selected).Password;
            }
            else
            {
                accountNameTextBox.Text = "";
                passwordTextBox.Text = "";
            }
        }

        private void setRadPathButton_Click(object sender, EventArgs e)
        {
            Configuration.SetValue("radsPath", radsPathTextBox.Text);
            Configuration.SaveConfiguration();

            MessageBox.Show("Path saved!");
        }

        private async void checkButton_Click(object sender, EventArgs e)
        {
            if (accountNameTextBox.Text.Length > 0 && passwordTextBox.Text.Length > 0)
            {
                saveAccountInfo_Click(sender, e);

                checkButton.Enabled = false;
                saveAccButton.Enabled = false;
                accountNameTextBox.Enabled = false;
                passwordTextBox.Enabled = false;
                regionsComboBox.Enabled = false;

                MainForm.MainFormInstance.statusButton.Enabled = false;

                resultLabel.Text = "Status: Running...";
                this.Update();

                Region selected = (Region)Enum.Parse(typeof(Region), regionsComboBox.SelectedItem.ToString());
                Double res = await ObserverInterface.TestAccount(AccountManager.GetAccount(selected));

                if (res == -1)
                    resultLabel.Text = "Status: Failed";
                else
                    resultLabel.Text = "Status: Successful";

                checkButton.Enabled = true;
                saveAccButton.Enabled = true;
                accountNameTextBox.Enabled = true;
                passwordTextBox.Enabled = true;
                regionsComboBox.Enabled = true;

                MainForm.MainFormInstance.statusButton.Enabled = true;
            }
            else
                MessageBox.Show("Empty summoner name or password!");
        }
    }
}
