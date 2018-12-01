using FinalThiago.Classes;
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
        string name = "";
        string password = "";
        User user;

        public LoginForm()
        {
            InitializeComponent();

        }

        #region PasswordRecover

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            ShowRecover();
        }

        private void btnRecover_Click(object sender, EventArgs e)
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

        #endregion

        #region Click

        private void pbxBack_Click_1(object sender, EventArgs e)
		{
			RideRecover();
		}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                GetData();
                if (CheckLogin(password, name))
                {
                    HomeForm hf = new HomeForm(user);
                    hf.Show();
                    this.Hide();
                }
                else
                {
                    CleanData();
                    MessageBox.Show("Usuário ou senha incorretos!");
                }
            }
            catch (Exception ex)
            {
                CleanData();
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        void GetData()
        {
            Name = lblName.Text;
            password = lblPassword.Text;
        }

        void CleanData()
        {
            lblName.Text = "";
            lblPassword.Text = "";
        }

        private bool CheckLogin(string password, string name)
        {
            user = UserHelper.SelectByName(name);

            if (user != null)
            {
                if (UserHelper.Hash(password) == user.Password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
