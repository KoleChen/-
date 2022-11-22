using ISpan.MidProject.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.MidProject
{
	
	public partial class FoodForm : Form
	{
		private FoodIndexVM[] food = null;
		public FoodForm()
		{
			InitializeComponent();

			//初始化表單
			InitForm();

			// 顯示商品記錄
			DisplayFood();
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
				.Prepend(new FoodCategoryVM { Id = 0, CategoryName = "全部分類" })
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

		private void DisplayFood()
		{
			string sql = @"SELECT F.Id, F.FoodName, F.ListPrice, C.CategoryName
FROM Food F
INNER JOIN FoodCategories C ON F.CategoryId = C.Id";

			//加入 where 
			SqlParameter[] parameters = new SqlParameter[] { };

			//取得下拉清單的篩選值
			int categoryId = ((FoodCategoryVM)categoryIdComboBox.SelectedItem).Id;

			//除了prepend設的"全部分類"categoryId"0"以外 其他選到的(Id 1 2 3...)
			if (categoryId > 0)
			{
				sql += " WHERE CategoryId=@CategoryId";
				parameters = new SqlParameterBuilder()
					.AddNInt("CategoryId", categoryId)
					.Build();
			}
			

			// 加入排序子句
			sql += " ORDER BY F.CategoryId,F.ListPrice, F.FoodName";
			var dbHelper = new SqlDbHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			food = dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row))
				.ToArray();
			
			BindData(food);


		}
		private void BindData(FoodIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private FoodIndexVM ParseToIndexVM(DataRow row)
		{
			return new FoodIndexVM
			{
				Id = row.Field<int>("Id"),
				CategoryName = row.Field<string>("CategoryName"),
				FoodName = row.Field<string>("FoodName"),
				ListPrice = row.Field<int>("ListPrice"),
			};
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			DisplayFood();
		}

		private void addNewButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateFoodForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayFood();
			}
		}

		
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			FoodIndexVM row = this.food[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.Id; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditFoodForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayFood();
			}
		}
	}
}
