using FinalThiago.Classes;
using FinalThiago.Properties;
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
		bool aux = true;

        public HomeForm(User user)
        {
            InitializeComponent();
            if(user.UserProfile.Name != "Gerente")
            {
				aux = false;
                pbxUser.Enabled = false;
                pbxUserProfile.Enabled = false;
                pbxLog.Enabled = false;
            }
        }

		#region Mouse Enter/Leave

		private void pbxProduct_MouseEnter(object sender, EventArgs e)
		{
			pbxProduct.BackgroundImage = Resources.ColoredProductIcon;
		}

		private void pbxProduct_MouseLeave(object sender, EventArgs e)
		{
			pbxProduct.BackgroundImage = Resources.ProductIcon;
		}

		private void pbxCategory_MouseEnter(object sender, EventArgs e)
		{
			pbxCategory.BackgroundImage = Resources.ColoredCategoryIcon;
		}

		private void pbxCategory_MouseLeave(object sender, EventArgs e)
		{
			pbxCategory.BackgroundImage = Resources.CategoryIcon2;
		}

		private void pbxLog_MouseEnter(object sender, EventArgs e)
		{
			if (aux)
			{
				pbxLog.BackgroundImage = Resources.ColoredLogIcon;
			}
			else
			{
				pbxLog.Cursor = Cursors.Arrow;
			}
		}

		private void pbxLog_MouseLeave(object sender, EventArgs e)
		{
			if (aux)
			{
				pbxLog.BackgroundImage = Resources.LogIcon;
			}
		}

		private void pbxUser_MouseEnter(object sender, EventArgs e)
		{
			if (aux)
			{
				pbxUser.BackgroundImage = Resources.ColoredUserIcon;
			}
			else
			{
				pbxUser.Cursor = Cursors.Arrow;
			}
		}

		private void pbxUser_MouseLeave(object sender, EventArgs e)
		{
			if (aux)
			{
				pbxUser.BackgroundImage = Resources.UserIcon;
			}
		}

		private void pbxUserProfile_MouseEnter(object sender, EventArgs e)
		{
			if (aux)
			{
				pbxUserProfile.BackgroundImage = Resources.ColoredUserProfileIcon;
			}
			else
			{
				pbxUserProfile.Cursor = Cursors.Arrow;
			}
		}

		private void pbxUserProfile_MouseLeave(object sender, EventArgs e)
		{
			if (aux)
			{
				pbxUserProfile.BackgroundImage = Resources.ColoredUserProfileIcon;
			}
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