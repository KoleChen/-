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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISpan.MidProject
{
	

	public partial class OrderForm : Form
	{
		string name;
		int price, number, subTotal;
		int total=0;
		


		private FoodIndexVM[] food = null;
		public OrderForm()
		{
			InitializeComponent();

			//初始化表單
			InitForm();

			// 顯示商品記錄
			DisplayFood();

			totalLabel.Text = string.Empty;
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
			menuDataGridView.DataSource = data;
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

		private void menuDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (menuDataGridView.Rows[e.RowIndex].Cells[0].Value == null)
				return;
			nameTextBox.Text=menuDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
			priceTextBox.Text=menuDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
			calculateSubTotal();
			numberNumericUpDown.Value = 1;
		}

		private void calculateSubTotal()
		{
			name = nameTextBox.Text;
			price = int.Parse(priceTextBox.Text);
			number = (int)numberNumericUpDown.Value;
			subTotal = price * number;
			subTotalTextBox.Text = subTotal.ToString();
		}

		private void numberNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			calculateSubTotal();
		}

		private void calTotalButton_Click(object sender, EventArgs e)
		{
			calculateTotal(); //重新計算總價
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			int rowIndex = orderDataGridView.CurrentCell.RowIndex;
			orderDataGridView.Rows.RemoveAt(rowIndex);
		}
		



		private void logoutbutton_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("您確定要登出嗎?", "登出", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (result == DialogResult.Yes)
			{
				this.Close();
				var frm = new LoginForm();
				frm.Show();							
			}
		}

		private void payButton_Click(object sender, EventArgs e)
		{
			//var frm = new PayForm();
			//frm.totalmoney = totalLabel.Text;
			//frm.Show();
			DialogResult result = MessageBox.Show("是否結帳?", "結帳", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				
				
				var frm = new PayForm();
				frm.totalmoney = totalLabel.Text;
				this.Close();
				frm.Show();
			}

		}

		private void addButton_Click(object sender, EventArgs e)
		{
			calculateSubTotal(); //計算小計並加入訂單中
			orderDataGridView.Rows.Add(new object[] { name, price, number, subTotal });
			
		}

		private void calculateTotal()
		{						
			for (int i = 0; i < orderDataGridView.Rows.Count; i++)
			{
				
				total += Convert.ToInt32(int.Parse(orderDataGridView.Rows[i].Cells[3].Value.ToString()));
				
			}			 
			totalLabel.Text = Convert.ToString(total);
		}
	}
}
