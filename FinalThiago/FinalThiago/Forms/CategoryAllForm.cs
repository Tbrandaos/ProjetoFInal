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
	public partial class CategoryAllForm : Form
	{
		string categoria = "";

		public CategoryAllForm()
		{
			InitializeComponent();
		}

		#region PbxCLick

		private void pbxBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pbxEdit_Click(object sender, EventArgs e)
		{
			CategoryDetailsForm cdf = new CategoryDetailsForm();
			cdf.Show();
		}

		private void pbxClear_Click(object sender, EventArgs e)
		{
			tbxSearch.Text = "";
		}

		private void pbxAdd_Click(object sender, EventArgs e)
		{
			CategoryDetailsForm cdf = new CategoryDetailsForm();
			cdf.Show();
		}

		#endregion

		void GetData(string categoria)
		{
			categoria = tbxSearch.Text;
		}
	}
}
