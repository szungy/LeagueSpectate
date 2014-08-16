using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Reflection;
using Microsoft.Win32;

namespace Spectate
{
    public partial class MainForm : Form
    {        
        public static String EncryptionKey = "";
        public static String IP = "";
        public static String GameID = "";
        
        public static String GameVersion = "4.14.14.xx";

        public static Options OptionsFormInstance;
        public static MainForm MainFormInstance;

        public MainForm()
        {
            InitializeComponent();
            MainFormInstance = this;
        }

        public void StatusUpdate(String newStatus)
        {
            statusInformationLabel.Text = newStatus;
        }

        private async void statusButton_Click(object sender, EventArgs e)
        {
            if (summonerNameTextBox.Text.Length == 0 || summonerNameTextBox.Text.Length > 25)
            {
                MessageBox.Show("You must give a valid summoner name!");
                return;
            }

            spectateButton.Enabled = false;
            statusButton.Enabled = false;
            regionsComboBox.Enabled = false;
            summonerNameTextBox.Enabled = false;
            statusInformationLabel.Text = "Retrieving...";
            this.Update();

            Region selected = (Region)Enum.Parse(typeof(Region), regionsComboBox.SelectedItem.ToString());
            ObserverResult result = await ObserverInterface.GetObserverInformation(summonerNameTextBox.Text, AccountManager.GetAccount(selected));

            switch(result.Status)
            {
                case ObserverResultStatus.ConectionProblem:
                    statusInformationLabel.Text = "Connection problem";
                    break;
                case ObserverResultStatus.NotInGame:
                    statusInformationLabel.Text = "Not in game";
                    break;
                case ObserverResultStatus.UnknownFail:
                    statusInformationLabel.Text = "Unknown fail";
                    break;
                case ObserverResultStatus.Successful:
                    statusInformationLabel.Text = "In game";
                    IP = result.ObserverData[0];
                    EncryptionKey = result.ObserverData[1];
                    GameID = result.ObserverData[2];
                    spectateButton.Enabled = true;
                    break;
                default:
                    throw new Exception("Unknown result status!");
            }

            statusButton.Enabled = true;
            summonerNameTextBox.Enabled = true;
            regionsComboBox.Enabled = true;
        }

        public String GetRegionCode(Region region)
        {
            if (region.ToString() == "EUNE")
                return "EUN1";
            else if (region.ToString() == "NA")
                return "NA1";
            else if (region.ToString() == "EUW")
                return "EUW1";
            else if (region.ToString() == "LAN")
                return "LA1";
            else if (region.ToString() == "LAS")
                return "LA2";
            else if (region.ToString() == "BR")
                return "BR1";
            else if (region.ToString() == "OCE")
                return "OC1";
            else if (region.ToString() == "TR")
                return "TR1";
            else if (region.ToString() == "RU")
                return "RU1";

            return "";
        }

        private void spectateButton_Click(object sender, EventArgs e)
        {            
            String startedBy = "LolClient.exe";
            String RegionCode = GetRegionCode(Account.ParseRegionString(regionsComboBox.SelectedItem.ToString()));
            String LoLMainPath = Configuration.GetValue("radsPath").ToString();

            String LoLDir = "";
            String ExePath = "";

            Util.GetLoLDirectoryPath(out LoLDir);
            Boolean found2 = Util.GetLoLExecutablePath(out ExePath);

            if (!found2 && LoLMainPath != null && LoLMainPath.Length > 0)
            {
                LoLDir = LoLMainPath + "\\solutions\\lol_game_client_sln\\releases\\";

                List<DirectoryInfo> subdirs = new DirectoryInfo(LoLDir).GetDirectories().ToList();
                List<DirectoryInfo> subdirsCopy = subdirs.ToList();

                foreach (DirectoryInfo t in subdirsCopy)
                    if (!Util.IsNumericDec(t.Name))
                        subdirs.Remove(t);

                subdirs = subdirs.ToArray().OrderBy(f => f.LastWriteTime).Reverse().ToList();
                LoLDir += subdirs[0].Name + "\\deploy\\";

                ExePath = LoLDir + "League of Legends.exe";
                found2 = true;
            }
            
            if (!found2)
            {
                MessageBox.Show("League Of Legends could not be found!");
                return;
            }
            
            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.FileName = ExePath;
            p.StartInfo.WorkingDirectory = LoLDir;
            p.StartInfo.Arguments = "\"8394\" \"" + startedBy + "\" \"\" \"spectator " + IP + " " + EncryptionKey + " " + GameID + " " + RegionCode + "\"";
            p.Start();
        }

        private void extrasButton_Click(object sender, EventArgs e)
        {
            Extras extrasForm = new Extras();
            extrasForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {                 
            regionsComboBox.DataSource = new BindingSource() { DataSource = AccountManager.GetRegions() };

            Configuration.CreateDefaultFolder();
            Configuration.LoadConfiguration();

            AccountManager.Load(Configuration.GetAccounts(), true);
            regionsComboBox_SelectionChangeCommitted(sender, e);
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            if (OptionsFormInstance == null)
            {
                OptionsFormInstance = new Options();
                OptionsFormInstance.Show();
            }
        }

        private void regionsComboBox_TextUpdate(object sender, EventArgs e)
        {
            if (regionsComboBox.SelectedItem != null)
                regionsComboBox.Text = regionsComboBox.SelectedItem.ToString();
            else
                regionsComboBox.Text = "NA";
        }

        public void regionsComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Region selected = (Region)Enum.Parse(typeof(Region), regionsComboBox.SelectedItem.ToString());

            if (AccountManager.HaveAccountForRegion(selected))
                statusButton.Enabled = true;
            else
                statusButton.Enabled = false;

            spectateButton.Enabled = false;
        }
    }
}
