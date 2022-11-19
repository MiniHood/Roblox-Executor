using RobloxExecutorCSharp.Properties;
using RobloxExecutorCSharp.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RobloxExecutorCSharp.Resource
{
    public class ResourceInstall
    {
        // I know it says resources but it's the references.
        public List<string> Resource = new List<string>(); 
        public List<string> Loaded = new List<string>(); 

        private void SetResources()
        {
            Resource.Add("Siticone.UI.dll");
            Resource.Add("EasyExploits.dll");
            Resource.Add("WRD.dll");
        }

        private string GetCurrentDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        }

        public void LoadResources()
        {
            foreach (var item in Resource)
            {
                try
                {
                    if (File.Exists(GetCurrentDirectory() + $"\\{item}"))
                    {
                        Resource.Remove(item);
                        Loaded.Add(item);
                    }
                }
                catch (Exception) { new Error().ShowError(ErrorFlags.ResourceError); }

            }

            if(Loaded.Count < Resource.Count)
            {
                new Error().ShowError(ErrorFlags.LoadedError);
                InstallResources();
            }
        }

        private void InstallResources()
        {
            foreach (var item in Resource)
            {
                if(item == "Siticone.UI.dll")
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("https://github.com/MiniHood/Roblox-Executor/blob/main/Siticone.UI.dll?raw=true", GetCurrentDirectory() + "\\Siticone.UI.dll");
                } else if(item == "EasyExploits.dll")
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("https://github.com/MiniHood/Roblox-Executor/blob/main/EasyExploits.dll?raw=true", GetCurrentDirectory() + "\\EasyExploits.dll");
                } else if(item == "WRD.dll")
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("https://github.com/MiniHood/Roblox-Executor/blob/main/WRD.dll?raw=true", GetCurrentDirectory() + "\\WRD.dll");
                }
            }
        }
    }
}
