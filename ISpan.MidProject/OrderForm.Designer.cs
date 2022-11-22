namespace ISpan.MidProject
{
	partial class OrderForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
			this.menuDataGridView = new System.Windows.Forms.DataGridView();
			this.orderDataGridView = new System.Windows.Forms.DataGridView();
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.priceTextBox = new System.Windows.Forms.TextBox();
			this.subTotalTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.searchButton = new System.Windows.Forms.Button();
			this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
			this.numberNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.calTotalButton = new System.Windows.Forms.Button();
			this.totalLabel = new System.Windows.Forms.Label();
			this.logoutbutton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.payButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.foodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.listPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.foodIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numberNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.foodIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// menuDataGridView
			// 
			this.menuDataGridView.AllowUserToAddRows = false;
			this.menuDataGridView.AllowUserToDeleteRows = false;
			this.menuDataGridView.AutoGenerateColumns = false;
			this.menuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.menuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryNameDataGridViewTextBoxColumn,
            this.foodNameDataGridViewTextBoxColumn,
            this.listPriceDataGridViewTextBoxColumn});
			this.menuDataGridView.DataSource = this.foodIndexVMBindingSource;
			this.menuDataGridView.Location = new System.Drawing.Point(32, 122);
			this.menuDataGridView.Name = "menuDataGridView";
			this.menuDataGridView.ReadOnly = true;
			this.menuDataGridView.RowTemplate.Height = 24;
			this.menuDataGridView.Size = new System.Drawing.Size(346, 420);
			this.menuDataGridView.TabIndex = 0;
			this.menuDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuDataGridView_CellClick);
			// 
			// orderDataGridView
			// 
			this.orderDataGridView.AllowUserToAddRows = false;
			this.orderDataGridView.AllowUserToDeleteRows = false;
			this.orderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnPrice,
            this.ColumnNumber,
            this.ColumnSubTotal});
			this.orderDataGridView.Location = new System.Drawing.Point(461, 151);
			this.orderDataGridView.Name = "orderDataGridView";
			this.orderDataGridView.ReadOnly = true;
			this.orderDataGridView.RowTemplate.Height = 24;
			this.orderDataGridView.Size = new System.Drawing.Size(455, 314);
			this.orderDataGridView.TabIndex = 1;
			// 
			// ColumnName
			// 
			this.ColumnName.HeaderText = "餐點名稱";
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			// 
			// ColumnPrice
			// 
			this.ColumnPrice.HeaderText = "餐點價格";
			this.ColumnPrice.Name = "ColumnPrice";
			this.ColumnPrice.ReadOnly = true;
			// 
			// ColumnNumber
			// 
			this.ColumnNumber.HeaderText = "數量";
			this.ColumnNumber.Name = "ColumnNumber";
			this.ColumnNumber.ReadOnly = true;
			// 
			// ColumnSubTotal
			// 
			this.ColumnSubTotal.HeaderText = "小計";
			this.ColumnSubTotal.Name = "ColumnSubTotal";
			this.ColumnSubTotal.ReadOnly = true;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.nameTextBox.Location = new System.Drawing.Point(461, 82);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(95, 27);
			this.nameTextBox.TabIndex = 2;
			// 
			// priceTextBox
			// 
			this.priceTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.priceTextBox.Location = new System.Drawing.Point(578, 82);
			this.priceTextBox.Name = "priceTextBox";
			this.priceTextBox.Size = new System.Drawing.Size(64, 27);
			this.priceTextBox.TabIndex = 2;
			// 
			// subTotalTextBox
			// 
			this.subTotalTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.subTotalTextBox.Location = new System.Drawing.Point(752, 82);
			this.subTotalTextBox.Name = "subTotalTextBox";
			this.subTotalTextBox.Size = new System.Drawing.Size(77, 27);
			this.subTotalTextBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(462, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 21);
			this.label1.TabIndex = 5;
			this.label1.Text = "餐點名稱";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(574, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 21);
			this.label2.TabIndex = 5;
			this.label2.Text = "價格";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(673, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 21);
			this.label3.TabIndex = 5;
			this.label3.Text = "數量";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(748, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 21);
			this.label4.TabIndex = 5;
			this.label4.Text = "小計";
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(280, 86);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(98, 23);
			this.searchButton.TabIndex = 6;
			this.searchButton.Text = "搜尋餐點分類";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// categoryIdComboBox
			// 
			this.categoryIdComboBox.DisplayMember = "CategoryName";
			this.categoryIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.categoryIdComboBox.FormattingEnabled = true;
			this.categoryIdComboBox.Location = new System.Drawing.Point(133, 88);
			this.categoryIdComboBox.Name = "categoryIdComboBox";
			this.categoryIdComboBox.Size = new System.Drawing.Size(121, 20);
			this.categoryIdComboBox.TabIndex = 7;
			this.categoryIdComboBox.ValueMember = "Id";
			// 
			// numberNumericUpDown
			// 
			this.numberNumericUpDown.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.numberNumericUpDown.Location = new System.Drawing.Point(662, 82);
			this.numberNumericUpDown.Name = "numberNumericUpDown";
			this.numberNumericUpDown.Size = new System.Drawing.Size(72, 27);
			this.numberNumericUpDown.TabIndex = 8;
			this.numberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numberNumericUpDown.ValueChanged += new System.EventHandler(this.numberNumericUpDown_ValueChanged);
			// 
			// calTotalButton
			// 
			this.calTotalButton.Location = new System.Drawing.Point(466, 491);
			this.calTotalButton.Name = "calTotalButton";
			this.calTotalButton.Size = new System.Drawing.Size(90, 33);
			this.calTotalButton.TabIndex = 9;
			this.calTotalButton.Text = "計算總價";
			this.calTotalButton.UseVisualStyleBackColor = true;
			this.calTotalButton.Click += new System.EventHandler(this.calTotalButton_Click);
			// 
			// totalLabel
			// 
			this.totalLabel.AutoSize = true;
			this.totalLabel.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.totalLabel.Location = new System.Drawing.Point(562, 496);
			this.totalLabel.Name = "totalLabel";
			this.totalLabel.Size = new System.Drawing.Size(85, 19);
			this.totalLabel.TabIndex = 10;
			this.totalLabel.Text = "顯示總價";
			// 
			// logoutbutton
			// 
			this.logoutbutton.Location = new System.Drawing.Point(12, 12);
			this.logoutbutton.Name = "logoutbutton";
			this.logoutbutton.Size = new System.Drawing.Size(90, 36);
			this.logoutbutton.TabIndex = 13;
			this.logoutbutton.Text = "登出";
			this.logoutbutton.UseVisualStyleBackColor = true;
			this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Image = global::ISpan.MidProject.Properties.Resources.remove2;
			this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.deleteButton.Location = new System.Drawing.Point(852, 100);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(42, 42);
			this.deleteButton.TabIndex = 11;
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// payButton
			// 
			this.payButton.BackColor = System.Drawing.Color.Ivory;
			this.payButton.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.payButton.Image = global::ISpan.MidProject.Properties.Resources.dollar1;
			this.payButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.payButton.Location = new System.Drawing.Point(810, 506);
			this.payButton.Name = "payButton";
			this.payButton.Size = new System.Drawing.Size(106, 36);
			this.payButton.TabIndex = 4;
			this.payButton.Text = "結帳";
			this.payButton.UseVisualStyleBackColor = false;
			this.payButton.Click += new System.EventHandler(this.payButton_Click);
			// 
			// addButton
			// 
			this.addButton.Image = global::ISpan.MidProject.Properties.Resources.plus;
			this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addButton.Location = new System.Drawing.Point(852, 52);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(42, 42);
			this.addButton.TabIndex = 4;
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// categoryNameDataGridViewTextBoxColumn
			// 
			this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
			this.categoryNameDataGridViewTextBoxColumn.HeaderText = "餐點種類";
			this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
			this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// foodNameDataGridViewTextBoxColumn
			// 
			this.foodNameDataGridViewTextBoxColumn.DataPropertyName = "FoodName";
			this.foodNameDataGridViewTextBoxColumn.HeaderText = "餐點名稱";
			this.foodNameDataGridViewTextBoxColumn.Name = "foodNameDataGridViewTextBoxColumn";
			this.foodNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// listPriceDataGridViewTextBoxColumn
			// 
			this.listPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice";
			this.listPriceDataGridViewTextBoxColumn.HeaderText = "餐點價格";
			this.listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
			this.listPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// foodIndexVMBindingSource
			// 
			this.foodIndexVMBindingSource.DataSource = typeof(ISpan.MidProject.Models.ViewModels.FoodIndexVM);
			// 
			// OrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Khaki;
			this.ClientSize = new System.Drawing.Size(982, 580);
			this.Controls.Add(this.logoutbutton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.totalLabel);
			this.Controls.Add(this.calTotalButton);
			this.Controls.Add(this.numberNumericUpDown);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.categoryIdComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.payButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.subTotalTextBox);
			this.Controls.Add(this.priceTextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.orderDataGridView);
			this.Controls.Add(this.menuDataGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.Name = "OrderForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "點餐介面";
			((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numberNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.foodIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView menuDataGridView;
		private System.Windows.Forms.DataGridView orderDataGridView;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox priceTextBox;
		private System.Windows.Forms.TextBox subTotalTextBox;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button payButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.BindingSource foodIndexVMBindingSource;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.ComboBox categoryIdComboBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn foodNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubTotal;
		private System.Windows.Forms.NumericUpDown numberNumericUpDown;
		private System.Windows.Forms.Button calTotalButton;
		private System.Windows.Forms.Label totalLabel;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button logoutbutton;
	}
}