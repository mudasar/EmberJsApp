using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pos.UI.WinClient.Helpers;
using Pos.UI.WinClient.Properties;
using Pos.UI.WinClient.WebUserService;

namespace Pos.UI.WinClient.Forms
{
    public partial class LoginForm : Form
    {
        private WebUserService.IUserWebService _webService;
        public event UserLoginEventHandler LoginEventHandler;

        public LoginForm()
        {
            InitializeComponent();
            _webService = new UserWebServiceClient();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            _webService.BeginLogin(this.txtUsername.Text.Trim(), this.txtPassword.Text.Trim(),LoginAsyncCallback, new{} );
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginAsyncCallback(IAsyncResult result)
        {
            var user = _webService.EndLogin(result);
            if (user != null)
            {
                // delegate the user to main form with success message
                if (LoginEventHandler != null)
                {
                    LoginEventHandler(this,new LoginEventArgs(){User = user });
                }
                this.Close();
            }
            else
            {
                // show error login error
                lblError.Text = Resources.LoginForm_LoginAsyncCallback_Username___password_incorrect;
            }
        }
    }
}
