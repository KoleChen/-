namespace ISpan.MidProject
{
	partial class FoodForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodForm));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.foodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.listPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.foodIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.addNewButton = new System.Windows.Forms.Button();
			this.searchButton = new System.Windows.Forms.Button();
			this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
			this.foodCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.foodIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.foodCategoryVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryNameDataGridViewTextBoxColumn,
            this.foodNameDataGridViewTextBoxColumn,
            this.listPriceDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.foodIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(34, 71);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(346, 207);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// categoryNameDataGridViewTextBoxColumn
			// 
			this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
			this.categoryNameDataGridViewTextBoxColumn.HeaderText = "餐點分類";
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
			this.listPriceDataGridViewTextBoxColumn.HeaderText = "價格";
			this.listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
			this.listPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// foodIndexVMBindingSource
			// 
			this.foodIndexVMBindingSource.DataSource = typeof(ISpan.MidProject.Models.ViewModels.FoodIndexVM);
			// 
			// addNewButton
			// 
			this.addNewButton.Location = new System.Drawing.Point(305, 29);
			this.addNewButton.Name = "addNewButton";
			this.addNewButton.Size = new System.Drawing.Size(75, 23);
			this.addNewButton.TabIndex = 1;
			this.addNewButton.Text = "Add";
			this.addNewButton.UseVisualStyleBackColor = true;
			this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(161, 26);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 0;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// categoryIdComboBox
			// 
			this.categoryIdComboBox.DataSource = this.foodCategoryVMBindingSource;
			this.categoryIdComboBox.DisplayMember = "CategoryName";
			this.categoryIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.categoryIdComboBox.FormattingEnabled = true;
			this.categoryIdComboBox.Location = new System.Drawing.Point(34, 29);
			this.categoryIdComboBox.Name = "categoryIdComboBox";
			this.categoryIdComboBox.Size = new System.Drawing.Size(121, 20);
			this.categoryIdComboBox.TabIndex = 4;
			this.categoryIdComboBox.ValueMember = "Id";
			// 
			// foodCategoryVMBindingSource
			// 
			this.foodCategoryVMBindingSource.DataSource = typeof(ISpan.MidProject.Models.ViewModels.FoodCategoryVM);
			// 
			// FoodForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(441, 322);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.addNewButton);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.categoryIdComboBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FoodForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FoodForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.foodIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.foodCategoryVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button addNewButton;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.ComboBox categoryIdComboBox;
		private System.Windows.Forms.BindingSource foodIndexVMBindingSource;
		private System.Windows.Forms.BindingSource foodCategoryVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn foodNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
	}
}