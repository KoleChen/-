namespace ISpan.MidProject
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.adminLoginButton = new System.Windows.Forms.Button();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.accountTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.leavebutton = new System.Windows.Forms.Button();
			this.memberLoginbutton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// adminLoginButton
			// 
			this.adminLoginButton.Location = new System.Drawing.Point(245, 151);
			this.adminLoginButton.Name = "adminLoginButton";
			this.adminLoginButton.Size = new System.Drawing.Size(75, 23);
			this.adminLoginButton.TabIndex = 3;
			this.adminLoginButton.Text = "管理者登入";
			this.adminLoginButton.UseVisualStyleBackColor = true;
			this.adminLoginButton.Click += new System.EventHandler(this.adminLoginButton_Click);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(149, 107);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(171, 22);
			this.passwordTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(95, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 11;
			this.label2.Text = "密碼:";
			// 
			// accountTextBox
			// 
			this.accountTextBox.Location = new System.Drawing.Point(149, 79);
			this.accountTextBox.Name = "accountTextBox";
			this.accountTextBox.Size = new System.Drawing.Size(171, 22);
			this.accountTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(95, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 12;
			this.label1.Text = "帳號:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// leavebutton
			// 
			this.leavebutton.Location = new System.Drawing.Point(324, 190);
			this.leavebutton.Name = "leavebutton";
			this.leavebutton.Size = new System.Drawing.Size(75, 23);
			this.leavebutton.TabIndex = 4;
			this.leavebutton.Text = "離開";
			this.leavebutton.UseVisualStyleBackColor = true;
			this.leavebutton.Click += new System.EventHandler(this.leavebutton_Click);
			// 
			// memberLoginbutton
			// 
			this.memberLoginbutton.Location = new System.Drawing.Point(149, 151);
			this.memberLoginbutton.Name = "memberLoginbutton";
			this.memberLoginbutton.Size = new System.Drawing.Size(75, 23);
			this.memberLoginbutton.TabIndex = 2;
			this.memberLoginbutton.Text = "會員登入";
			this.memberLoginbutton.UseVisualStyleBackColor = true;
			this.memberLoginbutton.Click += new System.EventHandler(this.memberLoginbutton_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(459, 55);
			this.panel1.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(125, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(204, 24);
			this.label3.TabIndex = 0;
			this.label3.Text = "歡迎來到C#早餐店";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::ISpan.MidProject.Properties.Resources.breakfast3;
			this.pictureBox2.Location = new System.Drawing.Point(4, 4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(60, 48);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ISpan.MidProject.Properties.Resources.breakfast;
			this.pictureBox1.Location = new System.Drawing.Point(386, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(61, 47);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Khaki;
			this.ClientSize = new System.Drawing.Size(459, 242);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.memberLoginbutton);
			this.Controls.Add(this.leavebutton);
			this.Controls.Add(this.adminLoginButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.accountTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "登入介面";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button adminLoginButton;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox accountTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button leavebutton;
		private System.Windows.Forms.Button memberLoginbutton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}