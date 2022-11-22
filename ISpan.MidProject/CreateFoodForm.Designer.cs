namespace ISpan.MidProject
{
	partial class CreateFoodForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.saveButton = new System.Windows.Forms.Button();
			this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
			this.foodCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.listPriceTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.foodNameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.foodCategoryVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(206, 145);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 3;
			this.saveButton.Text = "保存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// categoryIdComboBox
			// 
			this.categoryIdComboBox.DataSource = this.foodCategoryVMBindingSource;
			this.categoryIdComboBox.DisplayMember = "CategoryName";
			this.categoryIdComboBox.FormattingEnabled = true;
			this.categoryIdComboBox.Location = new System.Drawing.Point(103, 48);
			this.categoryIdComboBox.Name = "categoryIdComboBox";
			this.categoryIdComboBox.Size = new System.Drawing.Size(178, 20);
			this.categoryIdComboBox.TabIndex = 0;
			this.categoryIdComboBox.ValueMember = "Id";
			// 
			// foodCategoryVMBindingSource
			// 
			this.foodCategoryVMBindingSource.DataSource = typeof(ISpan.MidProject.Models.ViewModels.FoodCategoryVM);
			// 
			// listPriceTextBox
			// 
			this.listPriceTextBox.Location = new System.Drawing.Point(103, 103);
			this.listPriceTextBox.Name = "listPriceTextBox";
			this.listPriceTextBox.Size = new System.Drawing.Size(178, 22);
			this.listPriceTextBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "價格";
			// 
			// foodNameTextBox
			// 
			this.foodNameTextBox.Location = new System.Drawing.Point(103, 75);
			this.foodNameTextBox.Name = "foodNameTextBox";
			this.foodNameTextBox.Size = new System.Drawing.Size(178, 22);
			this.foodNameTextBox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(41, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "餐點分類";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "餐點名稱";
			// 
			// CreateFoodForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.ClientSize = new System.Drawing.Size(369, 205);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.categoryIdComboBox);
			this.Controls.Add(this.listPriceTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.foodNameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "CreateFoodForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "新增餐點界面";
			((System.ComponentModel.ISupportInitialize)(this.foodCategoryVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.ComboBox categoryIdComboBox;
		private System.Windows.Forms.TextBox listPriceTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox foodNameTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource foodCategoryVMBindingSource;
	}
}