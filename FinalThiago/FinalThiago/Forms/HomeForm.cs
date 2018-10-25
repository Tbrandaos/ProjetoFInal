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
	}
}
