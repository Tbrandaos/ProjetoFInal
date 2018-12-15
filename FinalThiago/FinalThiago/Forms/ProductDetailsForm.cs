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
    public partial class ProductDetailsForm : Form
    {
        string name = "";
        float price = 0;
        string categoria = "";
        bool active = false;
        List<Category> categories = new List<Category>();

        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public ProductDetailsForm()
        {
            InitializeComponent();
            cmbCategory.DisplayMember = "NAME";
            LoadComboBox();
        }

        public ProductDetailsForm(int idProduct)
        {

            InitializeComponent();
            cmbCategory.DisplayMember = "NAME";
            LoadComboBox();

            lblId.Text = idProduct.ToString();

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {

                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCT WHERE ID = @id", sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", idProduct));

                    Product product = new Product();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            product.Id = Int32.Parse(reader["ID"].ToString());
                            product.Name = reader["NAME"].ToString();
                            product.Active = bool.Parse(reader["ACTIVE"].ToString());
                            product.Price = float.Parse(reader["PRICE"].ToString());
                        }
                    }

                    tbxName.Text = product.Name;
                    cbxActive.Checked = product.Active;
                    tbxPrice.Text = product.Price.ToString();
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
                    Category c = (Category)cmbCategory.SelectedItem;
                    Product product = new Product(name, price, c, active);

                    sqlConnect.Open();
                    string sql = "INSERT INTO PRODUCT(NAME, PRICE, ACTIVE, FK_PRODUCT) VALUES (@name, @price, @active, @category)";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", product.Name));
                    cmd.Parameters.Add(new SqlParameter("@price", product.Price));
                    cmd.Parameters.Add(new SqlParameter("@active", product.Active));
                    cmd.Parameters.Add(new SqlParameter("@category", product.Category.Id));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Adicionado com sucesso!");
					Log.SaveLog("Produto Criado", DateTime.Now, "Criação");
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
            else
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    GetData();
                    Category c = (Category)cmbCategory.SelectedItem;
                    sqlConnect.Open();
                    string sql = "UPDATE PRODUCT SET NAME = @name, PRICE = @price, ACTIVE = @active, FK_PRODUCT = @category WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@price", price));
                    cmd.Parameters.Add(new SqlParameter("@active", active));
                    cmd.Parameters.Add(new SqlParameter("@category", c.Id));
                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Altereções salvas com sucesso!");
					Log.SaveLog("Produto Editado", DateTime.Now, "Edição");
				}
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao editar este produto!" + "\n\n" + Ex.Message);
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
            if (!string.IsNullOrEmpty(lblId.Text)) //-----
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    sqlConnect.Open();
                    string sql = "UPDATE PRODUCT SET ACTIVE = @active WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", false));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produto inativo!");
					Log.SaveLog("Produto Excluído", DateTime.Now, "Excluir");
				}
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao desativar este produto!" + "\n\n" + Ex.Message);
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
			price = float.Parse(tbxPrice.Text);
			categoria = cmbCategory.Text;
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
			tbxPrice.Text = "";
			cmbCategory.SelectedIndex = 0;
			cbxActive.Checked = false;
		}

		void LoadComboBox()
		{
			SqlConnection cn = new SqlConnection(connectionString);

			try
			{
				cn.Open();
				SqlCommand sqlCommand = new SqlCommand("SELECT * FROM CATEGORY", cn);

				SqlDataReader reader = sqlCommand.ExecuteReader();
				while (reader.Read())
				{
					Category c = new Category(Int32.Parse(reader["ID"].ToString()), reader["NAME"].ToString(), bool.Parse(reader["ACTIVE"].ToString()));
					categories.Add(c);
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
			foreach (Category c in categories)
			{
				cmbCategory.Items.Add(c);
			}
		}

		#endregion
	}
}
