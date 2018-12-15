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
    public partial class UserDetailsForm : Form
    {
        string name = "";
        string email = "";
        string password = "";
        string confirmPassword = "";
        string profile = "";
        bool active = false;
        List<UserProfile> profiles = new List<UserProfile>();

        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public UserDetailsForm()
        {
            InitializeComponent();
            cmbProfile.DisplayMember = "NAME";
            LoadComboBox();
        }

        public UserDetailsForm(int idUser)
        {

            InitializeComponent();
            cmbProfile.DisplayMember = "NAME";
            LoadComboBox();

            lblId.Text = idUser.ToString();

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {

                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM [USER] WHERE ID = @id", sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", idUser));

                    User user = new User();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.Id = Int32.Parse(reader["ID"].ToString());
                            user.Name = reader["NAME"].ToString();
                            user.Active = bool.Parse(reader["ACTIVE"].ToString());
                            user.Email = reader["EMAIL"].ToString();
                            user.Password = reader["PASSWORD"].ToString();
                        }
                    }
                    tbxName.Text = user.Name;
                    cbxActive.Checked = user.Active;
                    tbxEmail.Text = user.Email;
                    tbxPassword.Text = user.Password;
                }
                catch (Exception EX)
                {
                    MessageBox.Show("Erro ao carregar produto");
                    throw;
                }
                finally
                {
                    //Fechar
                    sqlConnect.Close();
                }
            }
        }

		#region PbxClick

		private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblId.Text))
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);
                try
                {
                    GetData();
                    UserProfile userprofile = (UserProfile)cmbProfile.SelectedItem;
                    User user = new User(name, password, email, userprofile, active);

                    sqlConnect.Open();
                    string sql = "INSERT INTO [USER](NAME, EMAIL, PASSWORD, ACTIVE, FK_USERPROFILE) VALUES (@name, @email, @password, @active,@fk_profile)";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", user.Name));
                    cmd.Parameters.Add(new SqlParameter("@email", user.Email));
                    cmd.Parameters.Add(new SqlParameter("@password", user.Password));
                    cmd.Parameters.Add(new SqlParameter("@active", user.Active));
                    cmd.Parameters.Add(new SqlParameter("@fk_profile", user.UserProfile.Id));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Adicionado com sucesso!");
					Log.SaveLog("Usuário Criado", DateTime.Now, "Criação");
					CleanData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar usuário!" + ex.Message);
                    CleanData();
                }
                finally
                {
                    sqlConnect.Close();

                }
            }
            else
            {
                GetData();
                UserProfile userprofile = (UserProfile)cmbProfile.SelectedItem;
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    sqlConnect.Open();
                    string sql = "UPDATE [USER] SET NAME = @name, EMAIL = @email, PASSWORD = @password, ACTIVE = @active, FK_USERPROFILE = @fk_profile WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.Parameters.Add(new SqlParameter("@password", password));
                    cmd.Parameters.Add(new SqlParameter("@active", active));
                    cmd.Parameters.Add(new SqlParameter("@fk_profile", userprofile.Id));
                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Altereções salvas com sucesso!");
					Log.SaveLog("Usuário Editado", DateTime.Now, "Edição");
				}
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao editar este usuário!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();

                    this.Close();
                }
            }
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblId.Text))
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    sqlConnect.Open();
                    string sql = "UPDATE [USER] SET ACTIVE = @active WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", false));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuário inativo!");
					Log.SaveLog("Usuário Excluído", DateTime.Now, "Excluir");
				}
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao desativar este perfil!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                }
            }
        }

		#endregion

		#region Functions

		void GetData()
		{
			name = tbxName.Text;
			email = tbxEmail.Text;
			password = tbxPassword.Text;
			confirmPassword = tbxConfirmPassword.Text;
			profile = cmbProfile.Text;
			if (cbxActive.Checked)
			{
				active = true;
			}
			else
			{
				active = false;
			}
		}

		void CleanData()
		{
			tbxName.Text = "";
			tbxEmail.Text = "";
			tbxPassword.Text = "";
			tbxConfirmPassword.Text = "";
			cmbProfile.SelectedIndex = 0;
			cbxActive.Checked = false;
		}

		void LoadComboBox()
		{
			SqlConnection cn = new SqlConnection(connectionString);

			try
			{
				cn.Open();
				SqlCommand sqlCommand = new SqlCommand("SELECT * FROM USER_PROFILE", cn);

				SqlDataReader reader = sqlCommand.ExecuteReader();
				while (reader.Read())
				{
					UserProfile up = new UserProfile(Int32.Parse(reader["ID"].ToString()), reader["NAME"].ToString(), bool.Parse(reader["ACTIVE"].ToString()));
					profiles.Add(up);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				cn.Close();
			}
			foreach (UserProfile up in profiles)
			{
				cmbProfile.Items.Add(up);
			}
		}

		#endregion
	}
}
