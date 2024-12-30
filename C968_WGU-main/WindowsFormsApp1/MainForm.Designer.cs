
namespace WGU968
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddParts = new System.Windows.Forms.Button();
            this.ModifyParts = new System.Windows.Forms.Button();
            this.DeleteParts = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.ModifyProduct = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.PartsSearch = new System.Windows.Forms.TextBox();
            this.ProductsSearch = new System.Windows.Forms.TextBox();
            this.SearchProducts = new System.Windows.Forms.Button();
            this.SearchParts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PartGrid = new System.Windows.Forms.DataGridView();
            this.partIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductsGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Parts = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inhouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PartGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inhouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddParts
            // 
            this.AddParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddParts.Location = new System.Drawing.Point(383, 456);
            this.AddParts.Name = "AddParts";
            this.AddParts.Size = new System.Drawing.Size(77, 37);
            this.AddParts.TabIndex = 0;
            this.AddParts.Text = "Add";
            this.AddParts.UseVisualStyleBackColor = true;
            this.AddParts.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModifyParts
            // 
            this.ModifyParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyParts.Location = new System.Drawing.Point(466, 456);
            this.ModifyParts.Name = "ModifyParts";
            this.ModifyParts.Size = new System.Drawing.Size(100, 37);
            this.ModifyParts.TabIndex = 3;
            this.ModifyParts.Text = "Modify";
            this.ModifyParts.UseVisualStyleBackColor = true;
            this.ModifyParts.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteParts
            // 
            this.DeleteParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteParts.Location = new System.Drawing.Point(572, 456);
            this.DeleteParts.Name = "DeleteParts";
            this.DeleteParts.Size = new System.Drawing.Size(101, 37);
            this.DeleteParts.TabIndex = 4;
            this.DeleteParts.Text = "Delete";
            this.DeleteParts.UseVisualStyleBackColor = true;
            this.DeleteParts.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.Location = new System.Drawing.Point(1050, 456);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(77, 37);
            this.AddProduct.TabIndex = 5;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ModifyProduct
            // 
            this.ModifyProduct.BackColor = System.Drawing.Color.Transparent;
            this.ModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProduct.Location = new System.Drawing.Point(1131, 456);
            this.ModifyProduct.Name = "ModifyProduct";
            this.ModifyProduct.Size = new System.Drawing.Size(101, 37);
            this.ModifyProduct.TabIndex = 6;
            this.ModifyProduct.Text = "Modify";
            this.ModifyProduct.UseVisualStyleBackColor = false;
            this.ModifyProduct.Click += new System.EventHandler(this.button5_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProduct.Location = new System.Drawing.Point(1238, 456);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(103, 37);
            this.DeleteProduct.TabIndex = 7;
            this.DeleteProduct.Text = "Delete";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(1255, 525);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(86, 37);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PartsSearch
            // 
            this.PartsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsSearch.Location = new System.Drawing.Point(484, 152);
            this.PartsSearch.Name = "PartsSearch";
            this.PartsSearch.Size = new System.Drawing.Size(189, 30);
            this.PartsSearch.TabIndex = 9;
            // 
            // ProductsSearch
            // 
            this.ProductsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsSearch.Location = new System.Drawing.Point(1133, 151);
            this.ProductsSearch.Name = "ProductsSearch";
            this.ProductsSearch.Size = new System.Drawing.Size(208, 30);
            this.ProductsSearch.TabIndex = 10;
            // 
            // SearchProducts
            // 
            this.SearchProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProducts.Location = new System.Drawing.Point(1011, 152);
            this.SearchProducts.Name = "SearchProducts";
            this.SearchProducts.Size = new System.Drawing.Size(116, 29);
            this.SearchProducts.TabIndex = 11;
            this.SearchProducts.Text = "Search";
            this.SearchProducts.UseVisualStyleBackColor = true;
            this.SearchProducts.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SearchParts
            // 
            this.SearchParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchParts.Location = new System.Drawing.Point(345, 152);
            this.SearchParts.Name = "SearchParts";
            this.SearchParts.Size = new System.Drawing.Size(133, 33);
            this.SearchParts.TabIndex = 12;
            this.SearchParts.Text = "Search";
            this.SearchParts.UseVisualStyleBackColor = true;
            this.SearchParts.Click += new System.EventHandler(this.SearchParts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Inventory Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PartGrid
            // 
            this.PartGrid.AutoGenerateColumns = false;
            this.PartGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn1,
            this.minDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn});
            this.PartGrid.DataSource = this.partBindingSource;
            this.PartGrid.Location = new System.Drawing.Point(45, 191);
            this.PartGrid.Name = "PartGrid";
            this.PartGrid.RowHeadersWidth = 51;
            this.PartGrid.RowTemplate.Height = 24;
            this.PartGrid.Size = new System.Drawing.Size(628, 259);
            this.PartGrid.TabIndex = 15;
            this.PartGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // partIDDataGridViewTextBoxColumn1
            // 
            this.partIDDataGridViewTextBoxColumn1.DataPropertyName = "PartID";
            this.partIDDataGridViewTextBoxColumn1.HeaderText = "PartID";
            this.partIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.partIDDataGridViewTextBoxColumn1.Name = "partIDDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // inStockDataGridViewTextBoxColumn1
            // 
            this.inStockDataGridViewTextBoxColumn1.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn1.HeaderText = "InStock";
            this.inStockDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.inStockDataGridViewTextBoxColumn1.Name = "inStockDataGridViewTextBoxColumn1";
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(WGU968.Part);
            // 
            // ProductsGrid
            // 
            this.ProductsGrid.AllowUserToAddRows = false;
            this.ProductsGrid.AutoGenerateColumns = false;
            this.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.stockDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn1,
            this.maxDataGridViewTextBoxColumn1});
            this.ProductsGrid.DataSource = this.productBindingSource;
            this.ProductsGrid.Location = new System.Drawing.Point(739, 191);
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.RowHeadersWidth = 51;
            this.ProductsGrid.RowTemplate.Height = 24;
            this.ProductsGrid.Size = new System.Drawing.Size(602, 259);
            this.ProductsGrid.TabIndex = 15;
            this.ProductsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.priceDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceDataGridViewTextBoxColumn1.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.Width = 50;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.Width = 50;
            // 
            // minDataGridViewTextBoxColumn1
            // 
            this.minDataGridViewTextBoxColumn1.DataPropertyName = "min";
            this.minDataGridViewTextBoxColumn1.HeaderText = "min";
            this.minDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.minDataGridViewTextBoxColumn1.Name = "minDataGridViewTextBoxColumn1";
            this.minDataGridViewTextBoxColumn1.Width = 50;
            // 
            // maxDataGridViewTextBoxColumn1
            // 
            this.maxDataGridViewTextBoxColumn1.DataPropertyName = "max";
            this.maxDataGridViewTextBoxColumn1.HeaderText = "max";
            this.maxDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.maxDataGridViewTextBoxColumn1.Name = "maxDataGridViewTextBoxColumn1";
            this.maxDataGridViewTextBoxColumn1.Width = 50;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WGU968.Product);
            // 
            // Parts
            // 
            this.Parts.AutoSize = true;
            this.Parts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parts.Location = new System.Drawing.Point(40, 152);
            this.Parts.Name = "Parts";
            this.Parts.Size = new System.Drawing.Size(68, 29);
            this.Parts.TabIndex = 16;
            this.Parts.Text = "Parts";
            this.Parts.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(734, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Products";
            // 
            // inhouseBindingSource
            // 
            this.inhouseBindingSource.DataSource = typeof(WGU968.Inhouse);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(WGU968.Inventory);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1410, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Parts);
            this.Controls.Add(this.ProductsGrid);
            this.Controls.Add(this.PartGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchParts);
            this.Controls.Add(this.SearchProducts);
            this.Controls.Add(this.ProductsSearch);
            this.Controls.Add(this.PartsSearch);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.ModifyProduct);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.DeleteParts);
            this.Controls.Add(this.ModifyParts);
            this.Controls.Add(this.AddParts);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inhouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddParts;
        private System.Windows.Forms.Button ModifyParts;
        private System.Windows.Forms.Button DeleteParts;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button ModifyProduct;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox PartsSearch;
        private System.Windows.Forms.TextBox ProductsSearch;
        private System.Windows.Forms.Button SearchProducts;
        private System.Windows.Forms.Button SearchParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PartGrid;
        private System.Windows.Forms.DataGridView ProductsGrid;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.BindingSource inhouseBindingSource;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.Label Parts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
    }
}

