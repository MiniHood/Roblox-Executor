using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreDevs_API;
namespace RobloxExecutorCSharp.Tools.APIs
{
    public partial class WeAreDevs
    {
        private ExploitAPI exploit = new ExploitAPI();
        private Error error = new Error();
        private Vars vars = new Vars();

        private string GetFileContents()
        {
            string a = vars.SelFile;

            string lua = File.ReadAllText(a);

            return lua;
        }

        public void InjectAndExecute()
        {
            if(!exploit.LaunchExploit())
            {
                error.ShowError(ErrorFlags.UnableToHookWeAreDevs);
            } else
            {
                exploit.SendLuaCScript(GetFileContents());
            }
        }
    }
}
