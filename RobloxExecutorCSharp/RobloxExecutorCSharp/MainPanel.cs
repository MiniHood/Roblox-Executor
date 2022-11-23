using RobloxExecutorCSharp.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobloxExecutorCSharp
{
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
        }
        #region RoundedCorners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        #endregion

        #region Credits
        // Animated Folder Gif: https://www.flaticon.com/free-animated-icons/folder
        #endregion

        #region Usings For Local Files
        public Tool tools = new Tool();
        #endregion

        #region Variables

        API api = new API();

        #endregion

        private void MainPanel_Load(object sender, EventArgs e)
        {
            // Rounds form corners
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            new Resource.ResourceInstall().SetResources(); // Setting resources
            new Resource.ResourceInstall().LoadResources(); // Making sure all resources are in the directory.
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MiniHood");
        }

        private void selectfilesbutton_CheckedChanged(object sender, EventArgs e)
        {
            new Tool().SelectScript();
            if (new Vars().SelFile == "null")
            { return; }
        }

        private void siticoneRoundedButton1_Click_1(object sender, EventArgs e)
        {
            if(siticoneRoundedComboBox1.Text == "WeAreDevs") { api.ExecuteAndInjection(APISelection.WeAreDevs);  }
            else if(siticoneRoundedComboBox1.Text == "EasyExploits") { api.ExecuteAndInjection(APISelection.EasyExploits);  }
        }
    }
}
