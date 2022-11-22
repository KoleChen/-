using ISpan.MidProject.Infra;
using ISpan.MidProject.Models.Services;
using ISpan.MidProject.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.MidProject
{
	public partial class CreateAdminForm : Form
	{
		public CreateAdminForm()
		{
			InitializeComponent(); 
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			string account = accountTextBox.Text;
			string password = passwordTextBox.Text;
			string name = nameTextBox.Text;
			string level = levelTextBox.Text;

			// 將它們繫結到ViewModel
			AdminVM model = new AdminVM
			{
				Account = account,
				Password = password,
				Name = name,
				Level = level,
			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", accountTextBox},
				{"Password", passwordTextBox},
				{"Name", nameTextBox},
				{"Level", levelTextBox},
			};



			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;


			// 如果通過驗證,就新增記錄
			try
			{
				new AdminService().Create(model);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
			}


		}

	}
}
