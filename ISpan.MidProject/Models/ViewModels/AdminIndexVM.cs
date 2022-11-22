using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.MidProject.Models.ViewModels
{
	/// <summary>
	/// 供AdminForm使用 (僅顯示不用編輯 故不用驗證)
	/// </summary>
	public class AdminIndexVM
	{
		public int Id { get; set; }
		public string Account { get; set; }
		//public string Password { get; set; }
		//不要顯示密碼
		public string Name { get; set; }
		public string Level { get; set; }
	}


	/// <summary>
	/// 供CreateAdminForm, EditAdminForm使用
	/// </summary>
	public class AdminVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "帳號尚未填寫")]
		public string Account { get; set; }


		[Required(ErrorMessage = "密碼尚未填寫")]
		public string Password { get; set; }


		[Required(ErrorMessage = "姓名尚未填寫")]
		public string Name { get; set; }
		[Required(ErrorMessage = "權限尚未填寫")]
		public string Level { get; set; }

	}
}
