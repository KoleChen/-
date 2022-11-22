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
	public partial class EditFoodForm : Form
	{
		private int id;
		public EditFoodForm(int id)
		{
			InitializeComponent();
			InitForm();
			this.id = id;
		}

		private void EditFoodForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			string sql = "SELECT * FROM Food WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
				.AddNInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉, 找不到要編輯的記錄");
				this.DialogResult = DialogResult.Abort;

				// this.Close();
				return;
			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			FoodVM model = ToProductVM(data.Rows[0]);

			// 再將 viewModel值繫結到各控制項
			categoryIdComboBox.SelectedItem = ((List<FoodCategoryVM>)categoryIdComboBox.DataSource)
												.FirstOrDefault(x => x.Id == model.CategoryId);

			foodNameTextBox.Text = model.FoodName;
			listPriceTextBox.Text = model.ListPrice.ToString();

		}
		private FoodVM ToProductVM(DataRow row)
		{
			return new FoodVM
			{
				Id = row.Field<int>("Id"),
				CategoryId = row.Field<int>("CategoryId"),
				FoodName = row.Field<string>("FoodName"),
				ListPrice = row.Field<int>("ListPrice")
			};
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
				// .Prepend(new ProductCategoryVM { Id = 0, CategoryName = String.Empty })
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

		private void updateButton_Click(object sender, EventArgs e)
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
			if (model.ListPrice < 0) errorMsg += "餐點價格必需輸入大於或等於零的整數\r\n";

			if (string.IsNullOrEmpty(errorMsg) == false)
			{
				//表示至少一欄有錯誤
				MessageBox.Show(errorMsg);
				return; // 不再向下執行
			}

			// update record
			string sql = @"UPDATE Food
			SET CategoryId=@CategoryId, FoodName=@FoodName, ListPrice = @ListPrice
			WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddNInt("CategoryId", model.CategoryId)
				.AddNVarchar("FoodName", 50, model.FoodName)
				.AddNInt("ListPrice", model.ListPrice)
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

			string sql = @"DELETE FROM Food WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddNInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}
	}
}
