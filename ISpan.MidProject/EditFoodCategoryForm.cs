using ISpan.MidProject.Infra.Extensions;
using ISpan.Utility;
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
	public partial class EditFoodCategoryForm : Form
	{
		private int id;
		public EditFoodCategoryForm(int id)
		{
			InitializeComponent();

			this.id = id;
			BindData(id);
		}
		private void BindData(int id)
		{
			string sql = "SELECT * FROM FoodCategories WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
				.AddNInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉, 找不到要編輯的記錄");
				this.DialogResult = DialogResult.Abort;

				this.Close();
				return;
			}

			// 將欄位值放入控制項裡
			DataRow row = data.Rows[0];

			categoryNameTextBox.Text = row.Field<string>("CategoryName");
			displayOrderTextBox.Text = row.Field<int>("DisplayOrder").ToString();
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			string categoryName = categoryNameTextBox.Text;

			int displayOrder = displayOrderTextBox.Text.ToInt(-1);

			string sql = @"UPDATE FoodCategories
SET CategoryName=@CategoryName, DisplayOrder=@DisplayOrder
WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("CategoryName", 50, categoryName)
				.AddNInt("DisplayOrder", displayOrder)
				.AddNInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
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

			string sql = @"DELETE FROM FoodCategories WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddNInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}
	}
}
