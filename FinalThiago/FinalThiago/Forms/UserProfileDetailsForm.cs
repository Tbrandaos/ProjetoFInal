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
	public partial class UserProfileDetailsForm : Form
	{
		string name = "";
		bool active = false;

        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";


        public UserProfileDetailsForm()
		{
			InitializeComponent();
		}

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		void GetData()
		{
			name = tbxName.Text;
			if(cbxActive.Checked)
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
            cbxActive.Checked = false;
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                GetData();
                UserProfile userprofile = new UserProfile(name, active);

                sqlConnect.Open();
                string sql = "INSERT INTO CATEGORY(NAME, ACTIVE) VALUES (@name, @active)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", userprofile.Name));
                cmd.Parameters.Add(new SqlParameter("@active", userprofile.Active));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Adicionado com sucesso!");

                CleanData();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar categoria!" + ex.Message);
                CleanData();
            }
            finally
            {
                sqlConnect.Close();
            }
        }
    }
}
