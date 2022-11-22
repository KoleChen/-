namespace ISpan.MidProject
{
	partial class EditFoodCategoryForm
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
			this.displayOrderTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.categoryNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(124, 93);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 2;
			this.updateButton.Text = "更新";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(205, 93);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 3;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// displayOrderTextBox
			// 
			this.displayOrderTextBox.Location = new System.Drawing.Point(102, 65);
			this.displayOrderTextBox.Name = "displayOrderTextBox";
			this.displayOrderTextBox.Size = new System.Drawing.Size(178, 22);
			this.displayOrderTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 12);
			this.label2.TabIndex = 10;
			this.label2.Text = "顯示順序:";
			// 
			// categoryNameTextBox
			// 
			this.categoryNameTextBox.Location = new System.Drawing.Point(102, 37);
			this.categoryNameTextBox.Name = "categoryNameTextBox";
			this.categoryNameTextBox.Size = new System.Drawing.Size(178, 22);
			this.categoryNameTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 11;
			this.label1.Text = "分類名稱:";
			// 
			// EditFoodCategoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.ClientSize = new System.Drawing.Size(381, 184);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.displayOrderTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.categoryNameTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "EditFoodCategoryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "編輯餐點分類";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.TextBox displayOrderTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox categoryNameTextBox;
		private System.Windows.Forms.Label label1;
	}
}