using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobloxExecutorCSharp
{
    public class Tool
    {
        public void SelectScript()
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "lua files (*.lua)|*.lua";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    new Vars().SelFile = openFileDialog1.FileName;
                } else
                {
                    new Vars().SelFile = "null";
                }
            }
        }
    }


    public class Vars
    {
        public string SelFile { get; set; }
    }
}
