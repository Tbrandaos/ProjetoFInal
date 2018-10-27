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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

		#region Mouse Enter/Leave

		private void pbxProduct_MouseEnter(object sender, EventArgs e)
		{
			pbxProduct.BackColor = Color.LightBlue;
		}

		private void pbxProduct_MouseLeave(object sender, EventArgs e)
		{
			pbxProduct.BackColor = Color.Transparent;

		}

		private void pbxCategory_MouseEnter(object sender, EventArgs e)
		{
			pbxCategory.BackColor = Color.LightBlue;
		}

		private void pbxCategory_MouseLeave(object sender, EventArgs e)
		{
			pbxCategory.BackColor = Color.Transparent;
		}

		private void pbxLog_MouseEnter(object sender, EventArgs e)
		{
			pbxLog.BackColor = Color.LightBlue;
		}

		private void pbxLog_MouseLeave(object sender, EventArgs e)
		{
			pbxLog.BackColor = Color.Transparent;
		}

		private void pbxUser_MouseEnter(object sender, EventArgs e)
		{
			pbxUser.BackColor = Color.LightBlue;
		}

		private void pbxUser_MouseLeave(object sender, EventArgs e)
		{
			pbxUser.BackColor = Color.Transparent;
		}

		private void pbxUserProfile_MouseEnter(object sender, EventArgs e)
		{
			pbxUserProfile.BackColor = Color.LightBlue;
		}

		private void pbxUserProfile_MouseLeave(object sender, EventArgs e)
		{
			pbxUserProfile.BackColor = Color.Transparent;

		}

        #endregion

        #region PbxClick

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxProduct_Click(object sender, EventArgs e)
        {
            ProductAllForm paf = new ProductAllForm();
            paf.Show();
        }

        private void pbxCategory_Click(object sender, EventArgs e)
        {
            CategoryAllForm caf = new CategoryAllForm();
            caf.Show();
        }

        private void pbxUser_Click(object sender, EventArgs e)
        {
            UserAllForm uaf = new UserAllForm();
            uaf.Show();
        }

        private void pbxUserProfile_Click(object sender, EventArgs e)
        {
            UserProfileAllForm upaf = new UserProfileAllForm();
            upaf.Show();
        }

        private void pbxLog_Click(object sender, EventArgs e)
        {
            LogForm lf = new LogForm();
            lf.Show();
        }

        #endregion
    }
}
