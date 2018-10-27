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
	public partial class ProductDetailsForm : Form
	{
        string nome = "";
        float price = 0;
        string categoria = "";
        bool active = false;

		public ProductDetailsForm()
		{
			InitializeComponent();
		}

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void GetData(string nome, float price, string categoria, bool active)
        {
            nome = tbxName.Text;
            price = float.Parse(tbxPrice.Text);
            categoria = cmbCategory.Text;
            if(cbxActive.Checked)
            {
                active = true;
            }
            else
            {
                active = false;
            }
        }
    }
}
