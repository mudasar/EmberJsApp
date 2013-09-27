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
using Pos.UI.WinClient.Helpers;
using Pos.UI.WinClient.WebUserService;

namespace Pos.UI.WinClient
{
    public delegate void UserLoginEventHandler(object sender, LoginEventArgs e);

    public partial class Main : Form
    {
        public bool IsLoggedIn { get; set; }
        public User User { get; set; }

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
                Logout();
            }
            Application.ExitThread();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show login box 
            // after login display logout and disable login
            var frmlLogin = new LoginForm();
            frmlLogin.LoginEventHandler += frmlLogin_LoginEventHandler;
            frmlLogin.ShowDialog();
        }

        void frmlLogin_LoginEventHandler(object sender, LoginEventArgs e)
        {
            this.User = e.User;
            LoadDisplay();
        }

        private void LoadDisplay()
        {
            MessageBox.Show("", "user logged in", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Logout()
        {
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }
    }
}
