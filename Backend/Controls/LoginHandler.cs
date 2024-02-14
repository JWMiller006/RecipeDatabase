using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RecipeDatabase.Backend.Controls
{
    internal class LoginHandler
    {
        private static List<string> URLs { get; set; } = [
            @"https://raw.githubusercontent.com/Miller-Inc/DatabaseDownloadAssistant/master/bin/Release/net8.0/DatabaseDownloadAssistant.deps.json",
            @"https://raw.githubusercontent.com/Miller-Inc/DatabaseDownloadAssistant/master/bin/Release/net8.0/DatabaseDownloadAssistant.dll",
            @"https://raw.githubusercontent.com/Miller-Inc/DatabaseDownloadAssistant/master/bin/Release/net8.0/DatabaseDownloadAssistant.exe",
            @"https://raw.githubusercontent.com/Miller-Inc/DatabaseDownloadAssistant/master/bin/Release/net8.0/DatabaseDownloadAssistant.runtimeconfig.json",
            @"https://raw.githubusercontent.com/Miller-Inc/DatabaseDownloadAssistant/master/bin/Release/net8.0/MillerInc.dll",
            @"https://raw.githubusercontent.com/Miller-Inc/DatabaseDownloadAssistant/master/bin/Release/net8.0/Newtonsoft.Json.dll"

            ];

        internal static string FolderPath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MillerInc\RecipeDB";

        private static string Key = "b14ca5898a4e4133bbce2ea2315a1916";

        internal static User ValidateLogin(string username, string password)
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            foreach(var url in URLs)
            {
                MillerInc.Net.Downloader.ThreadedDownload(url, FolderPath + @"\" + url.Substring(url.LastIndexOf('/')));
            }
            Thread.Sleep(1000);
            Process p = new()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = FolderPath + @"\DatabaseDownloadAssistant.exe",
                    Arguments = $"validate {username} {password} {Key}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            p.Start();
            p.WaitForExit();
            Thread.Sleep(250);
            foreach (var url in URLs)
            {
                File.Delete(FolderPath + @"\" + url.Substring(url.LastIndexOf('/')));
            }
            User user = new(); 
            user.LoadFrom(FolderPath + @"\user.exe");
            try { File.Delete(FolderPath + @"\user.exe");
                  }
            catch { }
            AppData.CurrentUser = user;
            return user;
        }
    }
}
