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
	public partial class UserAllForm : Form
	{
		string user = "";
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public UserAllForm()
		{
			InitializeComponent();
            ShowData();
            ResizeDataGridView();
        }

        #region PbxClick

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            UserDetailsForm udf = new UserDetailsForm();
            udf.Show();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            int idUser = Int32.Parse(dgvUser.SelectedRows[0].Cells[0].Value.ToString());

            UserDetailsForm userDetailsForm = new UserDetailsForm(idUser);
            userDetailsForm.Show();

            this.Close();
        }

		private void pbxClear_Click(object sender, EventArgs e)
		{
			tbxSearch.Text = "";
            ShowData();
        }

        private void pbxSearch_Click(object sender, EventArgs e)
        {
            string optionForm = "UserForm";
            string optionString = "name";

            Search search = new Search();
            dgvUser.DataSource = search.SearchFilter(connectionString, tbxSearch.Text, optionString, optionForm);

            tbxSearch.Text = "";
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            int idUser = Int32.Parse(dgvUser.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();
                string sql = "UPDATE [USER] SET ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idUser));
                cmd.Parameters.Add(new SqlParameter("@active", false));

                cmd.ExecuteNonQuery();

                ShowData();

                MessageBox.Show("Usuário inativo!");
				Log.SaveLog("Usuário Excluído", DateTime.Now, "Excluir");

			}
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao editar este usuário!" + "\n\n" + Ex.Message);
                throw;
            }
            finally
            {
                sqlConnect.Close();
            }
        }

		#endregion

		#region Functions

		void GetData()
		{
			user = tbxSearch.Text;
		}

        private void ShowData()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT [USER].ID, [USER].NAME, [USER].PASSWORD, [USER].EMAIL, [USER].ACTIVE, USER_PROFILE.NAME FROM [USER] INNER JOIN USER_PROFILE ON [USER].FK_USERPROFILE = USER_PROFILE.ID;", sqlConnect);                // SqlDataReader reader = cmd.ExecuteReader();

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvUser.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar. " + ex.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void ResizeDataGridView()
        {
            dgvUser.Columns["ID"].Visible = false;
            dgvUser.Columns["NAME"].HeaderText = "Nome";
            dgvUser.Columns["ACTIVE"].HeaderText = "Ativo";
            dgvUser.Columns["PASSWORD"].Visible = false;
            dgvUser.Columns["EMAIL"].HeaderText = "Email";
            dgvUser.Columns["ACTIVE"].DisplayIndex = 5;
            dgvUser.Columns["NAME1"].HeaderText = "Perfil";
            dgvUser.Columns["NAME1"].DisplayIndex = 4;

            foreach (DataGridViewColumn col in dgvUser.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

		#endregion

	}
}
