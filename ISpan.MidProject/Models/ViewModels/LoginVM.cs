using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.MidProject.Models.ViewModels
{
	public class LoginVM
	{
		[Required(ErrorMessage = "帳號尚未填寫")]
		public string Account { get; set; }


		[Required(ErrorMessage = "密碼尚未填寫")]
		public string Password { get; set; }
	}
}
