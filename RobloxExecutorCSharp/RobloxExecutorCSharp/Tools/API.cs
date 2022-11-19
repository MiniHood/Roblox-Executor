using RobloxExecutorCSharp.Tools.APIs;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobloxExecutorCSharp.Tools
{
    public class API
    {

        WeAreDevs weare = new WeAreDevs();
        EasyExploitsAPI easy =  new EasyExploitsAPI();
        Error ThrowError = new Error();

        public void ExecuteAndInjection(APISelection api)
        {
            if(api == APISelection.WeAreDevs)
            {
                weare.InjectAndExecute();
            } else if (api == APISelection.EasyExploits)
            {
                easy.InjectAndExecute();
            } else
            {
                ThrowError.ShowError(ErrorFlags.UnknownAPI);
            }
        }
    }

    public enum APISelection
    {
        WeAreDevs = 0,

        EasyExploits = 1
    }
}
