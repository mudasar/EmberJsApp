using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pos.UI.WinClient.Forms;

namespace Pos.UI.WinClient
{
    public partial class Main : Form
    {
        public bool IsLoggedIn { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsLoggedIn)
            {
                    // Perform logout 

            }
            Application.ExitThread();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show login box 
            // after login display logout and disable login
        }
    }
}
