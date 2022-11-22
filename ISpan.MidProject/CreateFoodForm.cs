using ISpan.MidProject.Infra.Extensions;
using ISpan.MidProject.Models.ViewModels;
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
	public partial class CreateFoodForm : Form
	{
		public CreateFoodForm()
		{
			InitializeComponent();
			//初始化表單
			InitForm();
		}

		private void InitForm()
		{
			// 設定 categoryIdComboBox property
			categoryIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT * FROM FoodCategories ORDER BY DisplayOrder";
			var dbHelper = new SqlDbHelper("default");

			List<FoodCategoryVM> categories = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToCategoryVM(row))
				//.Prepend(new FoodCategoryVM { Id = 0, CategoryName = "全部分類" })
				.ToList();

			this.categoryIdComboBox.DataSource = categories;

		}

		private FoodCategoryVM ToCategoryVM(DataRow row)
		{
			return new FoodCategoryVM
			{
				Id = row.Field<int>("Id"),
				CategoryName = row.Field<string>("CategoryName"),
				DisplayOrder = row.Field<int>("DisplayOrder")
			};
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			int categoryId = ((FoodCategoryVM)this.categoryIdComboBox.SelectedItem).Id;
			string foodName = foodNameTextBox.Text;
			int listPrice = listPriceTextBox.Text.ToInt(-1); //如果没填牌價,傳回-1

			// 將它們繫結到ViewModel
			FoodVM model = new FoodVM
			{
				CategoryId = categoryId,
				FoodName = foodName,
				ListPrice = listPrice
			};

			// 針對ViewModel進行欄位驗證
			string errorMsg = string.Empty;
			if (string.IsNullOrEmpty(model.FoodName)) errorMsg += "餐點名稱必填\r\n";
			if (model.ListPrice < 0) errorMsg += "價格必需輸入大於或等於零的整數\r\n";

			if (string.IsNullOrEmpty(errorMsg) == false)
			{
				//表示至少一欄有錯誤
				MessageBox.Show(errorMsg);
				return; // 不再向下執行
			}

			string sql = @"INSERT INTO Food
(CategoryId,FoodName, ListPrice)
VALUES
(@CategoryId,@FoodName, @ListPrice)";

			var parameters = new SqlParameterBuilder()
				.AddNInt("CategoryId", model.CategoryId)
				.AddNVarchar("FoodName", 50, model.FoodName)
				.AddNInt("ListPrice", model.ListPrice)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			// MessageBox.Show("記錄已新增");
			this.DialogResult = DialogResult.OK;
		}
	}
}
