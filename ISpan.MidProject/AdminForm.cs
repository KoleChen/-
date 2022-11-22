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
	public partial class AdminForm : Form
	{
		private AdminIndexVM[] admin = null;
		public AdminForm()
		{
			InitializeComponent();

			// 顯示記錄
			DisplayAdmin();
		}

		private void DisplayAdmin()
		{
			//string sql = @"SELECT * FROM Users ORDER BY ID DESC";

			//var dbHelper = new SqlDbHelper("default");
			//// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			//users = dbHelper.Select(sql, null)
			//	.AsEnumerable()
			//	.Select(row => ParseToIndexVM(row))
			//	.ToArray();

			admin = new AdminService().GetAll().ToArray();
			BindData(admin);
		}

		//private UserIndexVM ParseToIndexVM(DataRow row)
		//{
		//	return new UserIndexVM
		//	{
		//		Id = row.Field<int>("Id"),
		//		Account = row.Field<string>("Account"),
		//		Name = row.Field<string>("Name")
		//	};
		//}

		private void BindData(AdminIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private void addNewButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateAdminForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayAdmin();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			AdminIndexVM row = this.admin[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.Id; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditAdminForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayAdmin();
			}
		}
	}
}
