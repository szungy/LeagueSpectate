using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spectate
{
    class Configuration
    {        
        public static List<Option> Options = new List<Option>();

        public static void CreateDefaultFolder()
        {
            if (!Directory.Exists(GetDefaultFolder()))
                Directory.CreateDirectory(GetDefaultFolder());
        }

        public static String GetDefaultFolder()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LeagueSpectate");
        }

        public static String GetDefaultConfigPath()
        {
            return Path.Combine(GetDefaultFolder(), "config.xml");
        }

        public static void LoadConfiguration()
        {
            LoadConfiguration(GetDefaultConfigPath());
        }

        public static void LoadConfiguration(String file)
        {
            if (!File.Exists(file))
                SetupDefaultConfiguration();
            else
            {
                String content = "";

                using (StreamReader r = new StreamReader(file))
                    content = r.ReadToEnd();

                try
                {
                    Configuration.Options = JsonConvert.DeserializeObject<List<Option>>(content);
                }
                catch (Exception e)
                {
                    MessageBox.Show("There was an error parsing the config file. The error is:" + e.ToString());
                }

                // Lets interpret the accounts
                foreach(Option o in Options)
                    if (IsAccountConfigOption(o.Name))
                        o.Value = JsonConvert.DeserializeObject<Account>(((JObject)o.Value).ToString());

                if (Configuration.Options == null || Configuration.Options.Count == 0)
                    SetupDefaultConfiguration();
            }
        }

        public static void SaveConfiguration()
        {
            SaveConfiguration(GetDefaultConfigPath());
        }

        public static void SaveConfiguration(String file)
        {            
            string json = JsonConvert.SerializeObject(Configuration.Options, Formatting.Indented);

            using (StreamWriter w = new StreamWriter(file))
                w.Write(json);
        }

        public static void SetupDefaultConfiguration()
        {
            Options = new List<Option>();
            SetValue("deleteBats", false);
            SetValue("radsPath", "");

            foreach (var region in Enum.GetValues(typeof(Region)))
                SetValue(region.ToString() + "acc", new Account("", "", (Region)region));

            SaveConfiguration();
        }

        public static object GetValue(String name)
        {
            foreach (Option o in Options)
                if (o.Name == name)
                    return o.Value;

            throw new Exception("No config option '" + name + "' found.");
        }

        public static void SetValue(String name, object value)
        {
            foreach (Option o in Options)
                if (o.Name == name)
                {
                    o.Value = value;
                    return;
                }

            Options.Add(new Option(name, value));
        }

        public static List<Account> GetAccounts()
        {
            List<Account> outp = new List<Account>();

            foreach (Option o in Options)
                if (IsAccountConfigOption(o.Name))
                {
                    Account t = (Account)o.Value;

                    if(t.Name != null && t.Name.Length > 0 && t.Password != null && t.Password.Length > 0)
                        outp.Add(t);
                }

            return outp;
        }

        private static Boolean IsAccountConfigOption(String s)
        {
            if (s.Contains("acc"))
            {
                if (AccountManager.GetRegions().Contains(s.Substring(0, s.Length - 3)))
                    return true;
                else
                    return false;
            }

            return false;
        }

        public class Option
        {
            public String Name;
            public object Value;

            public Option(String name, object value)
            {
                this.Name = name;
                this.Value = value;
            }
        }
    }
}
