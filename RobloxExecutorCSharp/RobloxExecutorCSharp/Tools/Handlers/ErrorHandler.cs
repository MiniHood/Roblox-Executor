
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobloxExecutorCSharp.Tools
{
    public class Error
    {
        public static void serror(string message)
        {
            Process.Start(new ProcessStartInfo("cmd.exe", $"/c start cmd /C \"color b && title Error && echo {message} && timeout /t 5\"")
            {
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            });
            Environment.Exit(0);
        }

        public void ShowError(ErrorFlags error)
        {
            switch (error)
            {
                case ErrorFlags.ResourceError:
                    serror("[!] We couldn't find a or all resources.");
                    break;
                case ErrorFlags.LoadedError:
                    serror("[!] We couldn't load a resource.");
                    break;
                case ErrorFlags.FileNotFound:
                    serror("[!] We couldn't find a file.");
                    break;
                case ErrorFlags.UnableToInjectScriptEasyExploit:
                    serror("[!] We couldn't inject your script with Easy Exploits.");
                    break;
                case ErrorFlags.UnableToHookEasyExploit:
                    serror("[!] We couldn't hook with Easy Exploits");
                    break;
                case ErrorFlags.UnableToInjectScriptWeAreDevs:
                    serror("[!] We couldn't inject your script with WeAreDevs");
                    break;
                case ErrorFlags.UnableToHookWeAreDevs:
                    serror("[!] We couldn't hook with WeAreDevs");
                    break;
                case ErrorFlags.UnknownAPI:
                    serror("[!] An error has occured while trying to process which API you wanted to use, if you didn't select one, please do.");
                    break;
            }
        }
    }

    public enum ErrorFlags
    {
        None = 0,

        ResourceError = 1,

        LoadedError = 2,

        FileNotFound = 3,

        UnableToHookEasyExploit = 4,

        UnableToHookWeAreDevs = 5,

        UnableToInjectScriptEasyExploit = 6,

        UnableToInjectScriptWeAreDevs = 7,

        UnknownAPI = 8
    }
}
