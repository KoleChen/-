namespace ISpan.MidProject
{
	partial class MainForm
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
			this.openFoodCategoryFormbutton = new System.Windows.Forms.Button();
			this.openFoodFormbutton = new System.Windows.Forms.Button();
			this.openAdminFormbutton = new System.Windows.Forms.Button();
			this.logoutbutton = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFoodCategoryFormbutton
			// 
			this.openFoodCategoryFormbutton.Location = new System.Drawing.Point(50, 43);
			this.openFoodCategoryFormbutton.Name = "openFoodCategoryFormbutton";
			this.openFoodCategoryFormbutton.Size = new System.Drawing.Size(120, 33);
			this.openFoodCategoryFormbutton.TabIndex = 0;
			this.openFoodCategoryFormbutton.Text = "維護餐點類別介面";
			this.openFoodCategoryFormbutton.UseVisualStyleBackColor = true;
			this.openFoodCategoryFormbutton.Click += new System.EventHandler(this.openFoodCategoriesFormbutton_Click);
			// 
			// openFoodFormbutton
			// 
			this.openFoodFormbutton.Location = new System.Drawing.Point(50, 107);
			this.openFoodFormbutton.Name = "openFoodFormbutton";
			this.openFoodFormbutton.Size = new System.Drawing.Size(120, 33);
			this.openFoodFormbutton.TabIndex = 1;
			this.openFoodFormbutton.Text = "維護餐點介面";
			this.openFoodFormbutton.UseVisualStyleBackColor = true;
			this.openFoodFormbutton.Click += new System.EventHandler(this.openFoodFormbutton_Click);
			// 
			// openAdminFormbutton
			// 
			this.openAdminFormbutton.Location = new System.Drawing.Point(50, 168);
			this.openAdminFormbutton.Name = "openAdminFormbutton";
			this.openAdminFormbutton.Size = new System.Drawing.Size(120, 33);
			this.openAdminFormbutton.TabIndex = 2;
			this.openAdminFormbutton.Text = "維護使用者";
			this.openAdminFormbutton.UseVisualStyleBackColor = true;
			this.openAdminFormbutton.Click += new System.EventHandler(this.openAdminFormbutton_Click);
			// 
			// logoutbutton
			// 
			this.logoutbutton.Location = new System.Drawing.Point(77, 21);
			this.logoutbutton.Name = "logoutbutton";
			this.logoutbutton.Size = new System.Drawing.Size(65, 27);
			this.logoutbutton.TabIndex = 3;
			this.logoutbutton.Text = "登出";
			this.logoutbutton.UseVisualStyleBackColor = true;
			this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.LightCyan;
			this.panel2.Controls.Add(this.logoutbutton);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 245);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(220, 77);
			this.panel2.TabIndex = 5;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
			this.panel3.Controls.Add(this.openFoodCategoryFormbutton);
			this.panel3.Controls.Add(this.openFoodFormbutton);
			this.panel3.Controls.Add(this.openAdminFormbutton);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(220, 322);
			this.panel3.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(220, 322);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "主介面";
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button openFoodCategoryFormbutton;
		private System.Windows.Forms.Button openFoodFormbutton;
		private System.Windows.Forms.Button openAdminFormbutton;
		private System.Windows.Forms.Button logoutbutton;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
	}
}