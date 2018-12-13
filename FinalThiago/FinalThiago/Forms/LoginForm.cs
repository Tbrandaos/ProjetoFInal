using FinalThiago.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
		bool updated = false;
		string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";
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
			if (tbxName.Text.Length > 0)
			{
				UpdatePassword();
				if (updated)
				{
					ShowRecover();
				}
			}
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
            name = tbxName.Text;
            password = tbxPassword.Text;
        }

        void CleanData()
        {
            tbxName.Text = "";
            tbxPassword.Text = "";
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

		void UpdatePassword()
		{
			User user = UserHelper.SelectByName(tbxName.Text);

			if (user.Name == null)
			{
				MessageBox.Show("Usuário não encontrado");
				updated = false;
			}
			else
			{
				SqlConnection sqlConnect = new SqlConnection(connectionString);

				try
				{
					EmailHelper.SendEmail(user.Email);

					GetData();
					sqlConnect.Open();
					string sql = "UPDATE [USER] SET PASSWORD = @password Where ID = @id";

					SqlCommand cmd = new SqlCommand(sql, sqlConnect);
					cmd.Parameters.Add(new SqlParameter("@password", UserHelper.Hash("456")));

					cmd.Parameters.Add(new SqlParameter("@id", user.Id));
					cmd.ExecuteNonQuery();

					MessageBox.Show("Uma nova senha foi enviada para seu e-mail!");
					Log.SaveLog("Usuário Editado", DateTime.Now, "Edição");
				}
				catch (Exception Ex)
				{
					MessageBox.Show("Erro ao enviar nova senha!" + "\n\n" + Ex.Message);
					updated = false;
					throw;
				}
				finally
				{
					sqlConnect.Close();
				}
			}
		}

	}
}
