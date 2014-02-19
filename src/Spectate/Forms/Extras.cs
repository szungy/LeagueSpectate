using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;

namespace Spectate
{
    public partial class Extras : Form
    {
        public Extras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String startedBy = "LolClient.exe";
            String LoLMainPath = Configuration.GetValue("radsPath").ToString();

            String LoLDir = "";
            String ExePath = "";

            Util.GetLoLDirectoryPath(out LoLDir);
            Boolean found2 = Util.GetLoLExecutablePath(out ExePath);

            if (!found2 && LoLMainPath != null && LoLMainPath.Length > 0)
            {
                LoLDir = LoLMainPath + "\\solutions\\lol_game_client_sln\\releases\\";

                DirectoryInfo[] subdirs = new DirectoryInfo(LoLDir).GetDirectories();
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
            p.StartInfo.Arguments = "\"8394\" \"" + startedBy + "\" \"\" \"spectator " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + "\"";
            p.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();

            if(fileDialog.FileName != null && fileDialog.FileName.Length > 0)
                if (File.Exists(fileDialog.FileName))
                {
                    bool dataFound = false;

                    using (StreamReader r = new StreamReader(fileDialog.FileName))
                    {
                        while (!r.EndOfStream)
                        {
                            String l = r.ReadLine();
                            if (l.Contains("@start"))
                            {
                                String[] a1 = l.Split(new string[] { "spectator" }, StringSplitOptions.None);
                                String baseText = a1[1].Substring(1, a1[1].Length - 2);
                                textBox1.Text = baseText.Split(new string[] { " " }, StringSplitOptions.None)[0];
                                textBox2.Text = baseText.Split(new string[] { " " }, StringSplitOptions.None)[1];
                                textBox3.Text = baseText.Split(new string[] { " " }, StringSplitOptions.None)[2];
                                textBox4.Text = baseText.Split(new string[] { " " }, StringSplitOptions.None)[3];

                                dataFound = true;
                            }
                        }
                    }

                    if (!dataFound)
                        MessageBox.Show("The file was found but there was an error while reading spectator data.");
                    else if (((Boolean)Configuration.GetValue("deleteBats")) == true)
                        File.Delete(fileDialog.FileName);
                }
                else
                    MessageBox.Show("The file does not exist!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();

            if (fileDialog.FileName != null && fileDialog.FileName.Length > 0)
                if (File.Exists(fileDialog.FileName))
                {
                    bool dataFound = false;

                    using (StreamReader r = new StreamReader(fileDialog.FileName))
                    {
                        while (!r.EndOfStream)
                        {
                            String l = r.ReadLine();
                            if (l.Contains("@\"League of Legends.exe\""))
                            {
                                String[] a1 = l.Split(new string[] { "spectator" }, StringSplitOptions.None);
                                String baseText = a1[1].Substring(1, a1[1].Length - 1);
                                textBox1.Text = baseText.Split(new string[] { " " }, StringSplitOptions.None)[0];
                                textBox2.Text = baseText.Split(new string[] { " " }, StringSplitOptions.None)[1];
                                textBox3.Text = baseText.Split(new string[] { " " }, StringSplitOptions.None)[2];
                                textBox4.Text = baseText.Split(new string[] { " " }, StringSplitOptions.None)[3];
                                textBox4.Text = textBox4.Text.Substring(0, textBox4.Text.Length - 1);

                                dataFound = true;
                            }
                        }
                    }

                    if (!dataFound)
                        MessageBox.Show("The file was found but there was an error while reading spectator data.");
                    else if (((Boolean)Configuration.GetValue("deleteBats")) == true)
                        File.Delete(fileDialog.FileName);
                }
                else
                    MessageBox.Show("The file does not exist!");
        }
    }
}
