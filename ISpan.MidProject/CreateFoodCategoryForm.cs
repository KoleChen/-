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
	public partial class CreateFoodCategoryForm : Form
	{
		public CreateFoodCategoryForm()
		{
			InitializeComponent();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			string categoryName = categoryNameTextBox.Text;

			// ToInt可以將字串轉換成int,若轉換失敗,傳回預設值 -1
			int displayOrder = displayOrderTextBox.Text.ToInt(-1);

			string sql = @"INSERT INTO FoodCategories
(CategoryName, DisplayOrder)
VALUES
(@CategoryName, @DisplayOrder)";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("CategoryName", 50, categoryName)
				.AddNInt("DisplayOrder", displayOrder)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			// MessageBox.Show("記錄已新增");
			this.DialogResult = DialogResult.OK;
		}

		
	}
}
