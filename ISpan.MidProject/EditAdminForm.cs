using ISpan.MidProject.Infra;
using ISpan.MidProject.Models.Services;
using ISpan.MidProject.Models.ViewModels;
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
	public partial class EditAdminForm : Form
	{
		private int id;
		public EditAdminForm(int id)
		{
			InitializeComponent();
			this.Load += EditAdminForm_Load;
			this.id = id;
		}

		private void EditAdminForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			AdminVM model = new AdminService().Get(id);

			// 再將 viewModel值繫結到各控制項
			accountTextBox.Text = model.Account;
			passwordTextBox.Text = model.Password;
			nameTextBox.Text = model.Name;
			levelTextBox.Text = model.Level;
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string account = accountTextBox.Text;
			string password = passwordTextBox.Text;
			string name = nameTextBox.Text;
			string level = levelTextBox.Text;

			// 將它們繫結到ViewModel
			AdminVM model = new AdminVM
			{
				Id = this.id,
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

			// update record
			try
			{
				new AdminService().Update(model);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Warning) != DialogResult.Yes)
			{
				return;
			}

			new AdminService().Delete(this.id);

			this.DialogResult = DialogResult.OK;
		}
	}
}
