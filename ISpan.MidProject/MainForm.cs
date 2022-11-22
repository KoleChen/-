using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.MidProject
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void openFoodCategoriesFormbutton_Click(object sender, EventArgs e)
		{
			var frm = new FoodCategoriesForm();			
			frm.Show();
		}

		private void openFoodFormbutton_Click(object sender, EventArgs e)
		{
			var frm = new FoodForm();			
			frm.Show();
		}

		private void openAdminFormbutton_Click(object sender, EventArgs e)
		{
			var frm = new AdminForm();			
			frm.Show();
		}

		private void logoutbutton_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("您確定要登出嗎?","登出",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

			if (result == DialogResult.Yes)
			{
				this.Close();
				var frm = new LoginForm();				
				frm.Show();
			}
			
		}
	}
}
