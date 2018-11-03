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
	public partial class UserAllForm : Form
	{
		string user = "";

		public UserAllForm()
		{
			InitializeComponent();
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
            UserDetailsForm udf = new UserDetailsForm();
            udf.Show();
        }

		private void pbxClear_Click(object sender, EventArgs e)
		{
			tbxSearch.Text = "";
		}

		#endregion

		void GetData()
		{
			user = tbxSearch.Text;
		}
	}
}
