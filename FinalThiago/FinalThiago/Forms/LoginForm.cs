using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalThiago.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            ShowRecover();
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            RideRecover();
        }

		private void pbxBack_Click_1(object sender, EventArgs e)
		{
			RideRecover();
		}

		void ShowRecover()
        {
            lblPassword.Visible = false;
            tbxPassword.Visible = false;
            btnLogin.Visible = false;
            lblForgetPassword.Visible = false;
            pbxBack.Visible = true;

            btnRecover.Visible = true;
        }

        void RideRecover()
        {
            lblPassword.Visible = true;
            tbxPassword.Visible = true;
            btnLogin.Visible = true;
            lblForgetPassword.Visible = true;

            btnRecover.Visible = false;
            pbxBack.Visible = false;
        }

		
	}
}
