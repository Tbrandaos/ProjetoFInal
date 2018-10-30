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
	public partial class CategoryDetailsForm : Form
	{
		string name = "";
		bool active = false;

		public CategoryDetailsForm()
		{
			InitializeComponent();
		}

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		void GetData(string name, bool active)
		{
			name = tbxName.Text;
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
