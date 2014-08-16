using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Spectate
{
    class Util
    {
        public static bool GetLoLExecutablePath(out String path)
        {
            path = "";
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Riot Games\\RADS");
            RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Riot Games\\RADS");
            
            String LoLDir = "";
            Boolean found = false;
            
            if (registryKey != null && registryKey.GetValue("LocalRootFolder") != null && registryKey.GetValue("LocalRootFolder").ToString().Length > 0)
            {
                LoLDir = registryKey.GetValue("LocalRootFolder").ToString() + "\\solutions\\lol_game_client_sln\\releases\\";

                List<DirectoryInfo> subdirs = new DirectoryInfo(LoLDir).GetDirectories().ToList();
                List<DirectoryInfo> subdirsCopy = subdirs.ToList();

                foreach (DirectoryInfo t in subdirsCopy)
                    if (!IsNumericDec(t.Name))
                        subdirs.Remove(t);

                subdirs = subdirs.ToArray().OrderBy(f => f.LastWriteTime).Reverse().ToList();
                path = LoLDir.ToString();
                path += subdirs[0].Name + "\\deploy\\" + "League of Legends.exe";

                found = true;
            }else if (registryKey2 != null && registryKey2.GetValue("LocalRootFolder") != null && registryKey2.GetValue("LocalRootFolder").ToString().Length > 0)
            {
                LoLDir = registryKey2.GetValue("LocalRootFolder").ToString() + "\\solutions\\lol_game_client_sln\\releases\\";

                List<DirectoryInfo> subdirs = new DirectoryInfo(LoLDir).GetDirectories().ToList();
                List<DirectoryInfo> subdirsCopy = subdirs.ToList();

                foreach (DirectoryInfo t in subdirsCopy)
                    if (!IsNumericDec(t.Name))
                        subdirs.Remove(t);

                subdirs = subdirs.ToArray().OrderBy(f => f.LastWriteTime).Reverse().ToList();
                path = LoLDir.ToString();
                path += subdirs[0].Name + "\\deploy\\" + "League of Legends.exe";

                found = true;
            }

            return found;
        }

        public static bool GetLoLDirectoryPath(out String path)
        {
            path = "";
            
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Riot Games\\RADS");
            RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Riot Games\\RADS");

            Boolean found = false;

            if (registryKey != null && registryKey.GetValue("LocalRootFolder") != null && registryKey.GetValue("LocalRootFolder").ToString().Length > 0)
            {
                path = registryKey.GetValue("LocalRootFolder").ToString() + "\\solutions\\lol_game_client_sln\\releases\\";

                List<DirectoryInfo> subdirs = new DirectoryInfo(path).GetDirectories().ToList();
                List<DirectoryInfo> subdirsCopy = subdirs.ToList();

                foreach (DirectoryInfo t in subdirsCopy)
                    if (!IsNumericDec(t.Name))
                        subdirs.Remove(t);

                subdirs = subdirs.ToArray().OrderBy(f => f.LastWriteTime).Reverse().ToList();
                path += subdirs[0].Name + "\\deploy\\";

                found = true;
            }else if (registryKey2 != null && registryKey2.GetValue("LocalRootFolder") != null && registryKey2.GetValue("LocalRootFolder").ToString().Length > 0)
            {
                path = registryKey2.GetValue("LocalRootFolder").ToString() + "\\solutions\\lol_game_client_sln\\releases\\";

                List<DirectoryInfo> subdirs = new DirectoryInfo(path).GetDirectories().ToList();
                List<DirectoryInfo> subdirsCopy = subdirs.ToList();

                foreach (DirectoryInfo t in subdirsCopy)
                    if (!IsNumericDec(t.Name))
                        subdirs.Remove(t);

                subdirs = subdirs.ToArray().OrderBy(f => f.LastWriteTime).Reverse().ToList();
                path += subdirs[0].Name + "\\deploy\\";

                found = true;
            }

            return found;
        }

        public static Boolean IsNumericDec(String s)
        {
            for (int i = 0; i < s.Length; i++)
                if (!(Char.IsNumber(((Char)s[i])) || s[i] == '.'))
                    return false;

            return true;
        }
    }
}
