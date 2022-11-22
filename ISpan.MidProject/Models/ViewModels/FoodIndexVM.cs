using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.MidProject.Models.ViewModels
{
	/// <summary>
	/// 供 FoodForm使用
	/// </summary>
	public class FoodIndexVM
	{
		public int Id { get; set; }
		public string CategoryName { get; set; }
		public string FoodName { get; set; }
		public int ListPrice { get; set; }

	}

	/// <summary>
	/// 供CreateFoodForm, EditFoodForm使用
	/// </summary>
	public class FoodVM
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		public string FoodName { get; set; }
		public int ListPrice { get; set; }
	}

	public class MenuVM
	{
		public string CategoryName { get; set; }
		public string FoodName { get; set; }
		public int ListPrice { get; set; }
	}
}
