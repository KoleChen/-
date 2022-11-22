using ISpan.MidProject.Models.Services;
using ISpan.MidProject.Models.ViewModels;
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
	public partial class PayForm : Form
	{
		
		public PayForm()
		{
			InitializeComponent();

			ResultLabel.Text = string.Empty;
			tableWareLabel.Text = string.Empty;
		}
		public string totalmoney;

		private void PayForm_Load(object sender, EventArgs e)
		{
			moneyLabel.Text = totalmoney;
		}

		private void finalbutton_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(totalmoney);
			int discount = Convert.ToInt32(x*0.8);

			if (radioButton1.Checked == true)
			{
				ResultLabel.Text = "折扣後總金額為:" + discount + "元" + "\r\n";
			}
			if (radioButton2.Checked==true)
			{
				ResultLabel.Text = "總金額為:" + x +"\r\n";
			}
			
			if(yesRadioButton.Checked == true)
			{
				tableWareLabel.Text = "需要餐具";
			}
			if (noRadioButton.Checked == true)
			{
				tableWareLabel.Text = "不需要餐具";
			}
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//var frm = new OrderForm();
			//frm.Show();
			DialogResult result = MessageBox.Show("是否要重新點餐?", "結帳", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				this.Close();
				var frm = new OrderForm();
				frm.Show();
			}
		}
	}
}
