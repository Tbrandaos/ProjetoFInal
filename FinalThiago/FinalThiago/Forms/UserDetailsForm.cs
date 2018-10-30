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
	public partial class UserDetailsForm : Form
	{
		string name = "";
		string email = "";
		string password = "";
		string confirmPassword = "";
		string profile = "";
		bool active = false;

		public UserDetailsForm()
		{
			InitializeComponent();
		}

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		void GetData(string name, string email, string password, string confirmPassword, string profile, bool active)
		{
			name = tbxName.Text;
			email = tbxEmail.Text;
			password = tbxPassword.Text;
			confirmPassword = tbxConfirmPassword.Text;
			profile = cmbProfile.Text;
			if (cbxActive.Checked)
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
