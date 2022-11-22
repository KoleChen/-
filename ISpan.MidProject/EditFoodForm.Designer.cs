namespace ISpan.MidProject
{
	partial class EditFoodForm
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
			this.updateButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
			this.listPriceTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.foodNameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(125, 118);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 3;
			this.updateButton.Text = "更新";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(206, 118);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 4;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// categoryIdComboBox
			// 
			this.categoryIdComboBox.DisplayMember = "CategoryName";
			this.categoryIdComboBox.FormattingEnabled = true;
			this.categoryIdComboBox.Location = new System.Drawing.Point(104, 35);
			this.categoryIdComboBox.Name = "categoryIdComboBox";
			this.categoryIdComboBox.Size = new System.Drawing.Size(178, 20);
			this.categoryIdComboBox.TabIndex = 0;
			this.categoryIdComboBox.ValueMember = "Id";
			// 
			// listPriceTextBox
			// 
			this.listPriceTextBox.Location = new System.Drawing.Point(104, 90);
			this.listPriceTextBox.Name = "listPriceTextBox";
			this.listPriceTextBox.Size = new System.Drawing.Size(178, 22);
			this.listPriceTextBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 12);
			this.label2.TabIndex = 10;
			this.label2.Text = "餐點價格:";
			// 
			// foodNameTextBox
			// 
			this.foodNameTextBox.Location = new System.Drawing.Point(104, 62);
			this.foodNameTextBox.Name = "foodNameTextBox";
			this.foodNameTextBox.Size = new System.Drawing.Size(178, 22);
			this.foodNameTextBox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 12);
			this.label3.TabIndex = 12;
			this.label3.Text = "餐點分類:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 13;
			this.label1.Text = "餐點名稱:";
			// 
			// EditFoodForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.ClientSize = new System.Drawing.Size(389, 200);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.categoryIdComboBox);
			this.Controls.Add(this.listPriceTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.foodNameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "EditFoodForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "編輯餐點";
			this.Load += new System.EventHandler(this.EditFoodForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.ComboBox categoryIdComboBox;
		private System.Windows.Forms.TextBox listPriceTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox foodNameTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
	}
}