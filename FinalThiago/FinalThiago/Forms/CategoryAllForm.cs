﻿using FinalThiago.Classes;
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
	public partial class CategoryAllForm : Form
	{
		string categoria = "";
        User userAux;

        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

		public CategoryAllForm(User user)
		{
			InitializeComponent();
            userAux = user;
            ShowData();
            ResizeDataGridView();
        }

		#region PbxCLick

		private void pbxBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pbxEdit_Click(object sender, EventArgs e)
		{
            int idCategory = Int32.Parse(dgvCategory.SelectedRows[0].Cells[0].Value.ToString());

            CategoryDetailsForm categoryDetails = new CategoryDetailsForm(idCategory, userAux);
            categoryDetails.Show();

            this.Close();
        }

		private void pbxClear_Click(object sender, EventArgs e)
		{
			tbxSearch.Text = "";
            ShowData();
		}

		private void pbxAdd_Click(object sender, EventArgs e)
		{
			CategoryDetailsForm cdf = new CategoryDetailsForm(userAux);
			cdf.Show();
		}

        private void pbxSearch_Click(object sender, EventArgs e)
        {
            string optionForm = "CategoryForm";
            string optionString = "name";

            Search search = new Search();
            dgvCategory.DataSource = search.SearchFilter(connectionString, tbxSearch.Text, optionString, optionForm);

            tbxSearch.Text = "";
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            int idCategory = Int32.Parse(dgvCategory.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();
                string sql = "UPDATE CATEGORY SET ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idCategory));
                cmd.Parameters.Add(new SqlParameter("@active", false));

                cmd.ExecuteNonQuery();

                ShowData();

                MessageBox.Show("Categoria inativa!");
				Log.SaveLog(sqlConnect,"Categoria Excluída", DateTime.Now, "Excluir");
			}
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao editar esta categoria!" + "\n\n" + Ex.Message);
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
			categoria = tbxSearch.Text;
		}

        private void ShowData()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd;
                sqlConnect.Open();

                if (userAux.UserProfile.Name != "Gerente")
                {
                    cmd = new SqlCommand("SELECT * FROM CATEGORY WHERE ACTIVE = @active", sqlConnect);
                    cmd.Parameters.Add(new SqlParameter("@active",true));
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM CATEGORY", sqlConnect);
                }

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvCategory.DataSource = dt;

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
            dgvCategory.Columns["ID"].Visible = false;
            dgvCategory.Columns["NAME"].HeaderText = "Nome";
            dgvCategory.Columns["ACTIVE"].HeaderText = "Ativo";

            foreach (DataGridViewColumn col in dgvCategory.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        #endregion

    }
}
