using ISpan.MidProject.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.MidProject.Models.Services
{
	public class AdminService
	{
		/// <summary>
		/// 傳回所有使用者記錄
		/// </summary>
		/// <returns></returns>
		public IEnumerable<AdminIndexVM> GetAll()
		{
			string sql = @"SELECT * FROM Admin ORDER BY ID ASC";

			var dbHelper = new SqlDbHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row))
				;
			// .ToList();
		}

		public void Create(AdminVM model)
		{
			bool isExists = AccountExists(model.Account);
			if (isExists) throw new Exception("帳號已存在");

			string sql = @"INSERT INTO Admin
(Account,Password, Name,Level)
VALUES
(@Account,@Password, @Name,@Level)";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, model.Account)
				.AddNVarchar("Password", 50, model.Password)
				.AddNVarchar("Name", 50, model.Name)
				.AddNVarchar("Level", 50, model.Level)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}

		private bool AccountExists(string account)
		{
			string sql = @"SELECT Count(*) as count FROM Admin WHERE Account=@Account";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		private bool AccountExists(AdminVM model)
		{
			string sql = @"SELECT Count(*) as count FROM Admin WHERE Account=@Account AND Id!=@Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, model.Account)
				.AddNInt("Id", model.Id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		private AdminIndexVM ParseToIndexVM(DataRow row)
		{
			return new AdminIndexVM
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Name = row.Field<string>("Name"),
				Level = row.Field<string>("Level")
			};
		}

		public AdminVM Get(int id)
		{
			string sql = "SELECT * FROM Admin WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
				.AddNInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");
				
			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			return ToAdminVM(data.Rows[0]);
		}

		private AdminVM ToAdminVM(DataRow row)
		{
			return new AdminVM
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name"),
				Level = row.Field<string>("Level"),
			};
		}

		internal void Update(AdminVM model)
		{
			bool isExists = AccountExists(model);
			if (isExists) throw new Exception("帳號已存在");

			string sql = @"UPDATE Admin
			SET Account=@Account, Password=@Password, Name=@Name ,Level=@Level
			WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, model.Account)
				.AddNVarchar("Password", 50, model.Password)
				.AddNVarchar("Name", 50, model.Name)
				.AddNInt("Id", model.Id)
				.AddNVarchar("Level", 50, model.Level)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}

		internal void Delete(int id)
		{
			string sql = @"DELETE FROM Admin WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddNInt("Id", id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}

		public bool Authenticate(LoginVM model)
		{
			var user = GetMember(model.Account);
			if (user == null) return false; // 找不到符合的帳號
			

			return (user.Password == model.Password);
		}

		public AdminVM GetMember(string account)
		{
			string sql = "SELECT * FROM Admin WHERE Account=@Account AND Level!='3'";
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}

			

			// 將找到的一筆記錄由DataTable 轉換到 AdminVM
			return ToAdminVM(data.Rows[0]);
		}

		public bool Authenticate2(LoginVM model)
		{
			var user = GetAdmin(model.Account);
			if (user == null) return false; // 找不到符合的帳號

			return (user.Password == model.Password);
		}

		public AdminVM GetAdmin(string account)
		{
			string sql = "SELECT * FROM Admin WHERE Account=@Account AND Level='1'";
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}

			// 將找到的一筆記錄由DataTable 轉換到 UserVM
			return ToAdminVM(data.Rows[0]);
		}








	}
}
