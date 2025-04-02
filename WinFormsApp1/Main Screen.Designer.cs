namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PartSearchButton = new Button();
            PartsSearchBar = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            PartAddButton = new Button();
            PartDeleteButton = new Button();
            PartModifyButton = new Button();
            PartsTable = new DataGridView();
            PartID = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inStockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            allPartsBindingSource = new BindingSource(components);
            inventoryBindingSource = new BindingSource(components);
            ProductsTable = new DataGridView();
            productIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            inStockDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            productsBindingSource = new BindingSource(components);
            panel3 = new Panel();
            ProductSearchButton = new Button();
            ProductSearchBar = new TextBox();
            panel4 = new Panel();
            ExitButton = new Button();
            ProductAddButton = new Button();
            ProductDeleteButton = new Button();
            ProductModifyButton = new Button();
            MainScreenTitle = new Label();
            PartsTableTitle = new Label();
            ProductTableTitle = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PartsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // PartSearchButton
            // 
            PartSearchButton.Location = new Point(3, 14);
            PartSearchButton.Name = "PartSearchButton";
            PartSearchButton.Size = new Size(75, 23);
            PartSearchButton.TabIndex = 0;
            PartSearchButton.Text = "Search";
            PartSearchButton.UseVisualStyleBackColor = true;
            PartSearchButton.Click += button1_Click;
            // 
            // PartsSearchBar
            // 
            PartsSearchBar.Location = new Point(84, 14);
            PartsSearchBar.Name = "PartsSearchBar";
            PartsSearchBar.Size = new Size(222, 23);
            PartsSearchBar.TabIndex = 1;
            PartsSearchBar.TextChanged += PartsSearchBar_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(PartSearchButton);
            panel1.Controls.Add(PartsSearchBar);
            panel1.Location = new Point(322, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 53);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(PartAddButton);
            panel2.Controls.Add(PartDeleteButton);
            panel2.Controls.Add(PartModifyButton);
            panel2.Location = new Point(378, 516);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 53);
            panel2.TabIndex = 3;
            // 
            // PartAddButton
            // 
            PartAddButton.Location = new Point(13, 14);
            PartAddButton.Name = "PartAddButton";
            PartAddButton.Size = new Size(75, 23);
            PartAddButton.TabIndex = 4;
            PartAddButton.Text = "Add";
            PartAddButton.UseVisualStyleBackColor = true;
            PartAddButton.Click += button2_Click;
            // 
            // PartDeleteButton
            // 
            PartDeleteButton.Location = new Point(175, 14);
            PartDeleteButton.Name = "PartDeleteButton";
            PartDeleteButton.Size = new Size(75, 23);
            PartDeleteButton.TabIndex = 6;
            PartDeleteButton.Text = "Delete";
            PartDeleteButton.UseVisualStyleBackColor = true;
            PartDeleteButton.Click += partDeleteButon_Click;
            // 
            // PartModifyButton
            // 
            PartModifyButton.Location = new Point(94, 14);
            PartModifyButton.Name = "PartModifyButton";
            PartModifyButton.Size = new Size(75, 23);
            PartModifyButton.TabIndex = 5;
            PartModifyButton.Text = "Modify";
            PartModifyButton.UseVisualStyleBackColor = true;
            PartModifyButton.Click += button3_Click;
            // 
            // PartsTable
            // 
            PartsTable.AllowUserToAddRows = false;
            PartsTable.AllowUserToDeleteRows = false;
            PartsTable.AutoGenerateColumns = false;
            PartsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsTable.Columns.AddRange(new DataGridViewColumn[] { PartID, nameDataGridViewTextBoxColumn, inStockDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, minDataGridViewTextBoxColumn, maxDataGridViewTextBoxColumn });
            PartsTable.DataSource = allPartsBindingSource;
            PartsTable.Location = new Point(28, 169);
            PartsTable.MultiSelect = false;
            PartsTable.Name = "PartsTable";
            PartsTable.ReadOnly = true;
            PartsTable.RowHeadersVisible = false;
            PartsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PartsTable.Size = new Size(603, 329);
            PartsTable.TabIndex = 4;
            PartsTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // PartID
            // 
            PartID.DataPropertyName = "PartID";
            PartID.HeaderText = "Part ID";
            PartID.Name = "PartID";
            PartID.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            inStockDataGridViewTextBoxColumn.HeaderText = "Inventory";
            inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            inStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minDataGridViewTextBoxColumn
            // 
            minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            minDataGridViewTextBoxColumn.HeaderText = "Min";
            minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            minDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            maxDataGridViewTextBoxColumn.HeaderText = "Max";
            maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            maxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allPartsBindingSource
            // 
            allPartsBindingSource.DataMember = "AllParts";
            allPartsBindingSource.DataSource = inventoryBindingSource;
            // 
            // inventoryBindingSource
            // 
            inventoryBindingSource.DataSource = typeof(Inventory);
            // 
            // ProductsTable
            // 
            ProductsTable.AllowUserToAddRows = false;
            ProductsTable.AllowUserToDeleteRows = false;
            ProductsTable.AutoGenerateColumns = false;
            ProductsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsTable.Columns.AddRange(new DataGridViewColumn[] { productIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn1, priceDataGridViewTextBoxColumn1, inStockDataGridViewTextBoxColumn1, minDataGridViewTextBoxColumn1, maxDataGridViewTextBoxColumn1 });
            ProductsTable.DataSource = productsBindingSource;
            ProductsTable.Location = new Point(671, 169);
            ProductsTable.MultiSelect = false;
            ProductsTable.Name = "ProductsTable";
            ProductsTable.ReadOnly = true;
            ProductsTable.RowHeadersVisible = false;
            ProductsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsTable.Size = new Size(604, 329);
            ProductsTable.TabIndex = 5;
            ProductsTable.CellContentClick += ProductsTable_CellContentClick;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // inStockDataGridViewTextBoxColumn1
            // 
            inStockDataGridViewTextBoxColumn1.DataPropertyName = "InStock";
            inStockDataGridViewTextBoxColumn1.HeaderText = "Inventory";
            inStockDataGridViewTextBoxColumn1.Name = "inStockDataGridViewTextBoxColumn1";
            inStockDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // minDataGridViewTextBoxColumn1
            // 
            minDataGridViewTextBoxColumn1.DataPropertyName = "Min";
            minDataGridViewTextBoxColumn1.HeaderText = "Min";
            minDataGridViewTextBoxColumn1.Name = "minDataGridViewTextBoxColumn1";
            minDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // maxDataGridViewTextBoxColumn1
            // 
            maxDataGridViewTextBoxColumn1.DataPropertyName = "Max";
            maxDataGridViewTextBoxColumn1.HeaderText = "Max";
            maxDataGridViewTextBoxColumn1.Name = "maxDataGridViewTextBoxColumn1";
            maxDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataMember = "Products";
            productsBindingSource.DataSource = inventoryBindingSource;
            // 
            // panel3
            // 
            panel3.Controls.Add(ProductSearchButton);
            panel3.Controls.Add(ProductSearchBar);
            panel3.Location = new Point(966, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(309, 53);
            panel3.TabIndex = 3;
            // 
            // ProductSearchButton
            // 
            ProductSearchButton.Location = new Point(3, 14);
            ProductSearchButton.Name = "ProductSearchButton";
            ProductSearchButton.Size = new Size(75, 23);
            ProductSearchButton.TabIndex = 0;
            ProductSearchButton.Text = "Search";
            ProductSearchButton.UseVisualStyleBackColor = true;
            ProductSearchButton.Click += ProductSearchButton_Click;
            // 
            // ProductSearchBar
            // 
            ProductSearchBar.Location = new Point(84, 14);
            ProductSearchBar.Name = "ProductSearchBar";
            ProductSearchBar.Size = new Size(222, 23);
            ProductSearchBar.TabIndex = 1;
            ProductSearchBar.TextChanged += ProductSearchBar_TextChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(ExitButton);
            panel4.Controls.Add(ProductAddButton);
            panel4.Controls.Add(ProductDeleteButton);
            panel4.Controls.Add(ProductModifyButton);
            panel4.Location = new Point(1022, 516);
            panel4.Name = "panel4";
            panel4.Size = new Size(253, 109);
            panel4.TabIndex = 7;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(175, 83);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += exitButton_Click;
            // 
            // ProductAddButton
            // 
            ProductAddButton.Location = new Point(13, 14);
            ProductAddButton.Name = "ProductAddButton";
            ProductAddButton.Size = new Size(75, 23);
            ProductAddButton.TabIndex = 4;
            ProductAddButton.Text = "Add";
            ProductAddButton.UseVisualStyleBackColor = true;
            ProductAddButton.Click += ProductAddButton_Click;
            // 
            // ProductDeleteButton
            // 
            ProductDeleteButton.Location = new Point(175, 14);
            ProductDeleteButton.Name = "ProductDeleteButton";
            ProductDeleteButton.Size = new Size(75, 23);
            ProductDeleteButton.TabIndex = 6;
            ProductDeleteButton.Text = "Delete";
            ProductDeleteButton.UseVisualStyleBackColor = true;
            ProductDeleteButton.Click += productDeleteButton_Click;
            // 
            // ProductModifyButton
            // 
            ProductModifyButton.Location = new Point(94, 14);
            ProductModifyButton.Name = "ProductModifyButton";
            ProductModifyButton.Size = new Size(75, 23);
            ProductModifyButton.TabIndex = 5;
            ProductModifyButton.Text = "Modify";
            ProductModifyButton.UseVisualStyleBackColor = true;
            ProductModifyButton.Click += ProductModifyButton_Click;
            // 
            // MainScreenTitle
            // 
            MainScreenTitle.AutoSize = true;
            MainScreenTitle.Font = new Font("Segoe UI", 12F);
            MainScreenTitle.Location = new Point(12, 9);
            MainScreenTitle.Name = "MainScreenTitle";
            MainScreenTitle.Size = new Size(227, 21);
            MainScreenTitle.TabIndex = 8;
            MainScreenTitle.Text = "Inventory Management System";
            // 
            // PartsTableTitle
            // 
            PartsTableTitle.AutoSize = true;
            PartsTableTitle.Font = new Font("Segoe UI", 14F);
            PartsTableTitle.Location = new Point(23, 141);
            PartsTableTitle.Name = "PartsTableTitle";
            PartsTableTitle.Size = new Size(53, 25);
            PartsTableTitle.TabIndex = 9;
            PartsTableTitle.Text = "Parts";
            PartsTableTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductTableTitle
            // 
            ProductTableTitle.AutoSize = true;
            ProductTableTitle.Font = new Font("Segoe UI", 14F);
            ProductTableTitle.Location = new Point(665, 141);
            ProductTableTitle.Name = "ProductTableTitle";
            ProductTableTitle.Size = new Size(86, 25);
            ProductTableTitle.TabIndex = 10;
            ProductTableTitle.Text = "Products";
            ProductTableTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 648);
            Controls.Add(ProductTableTitle);
            Controls.Add(PartsTableTitle);
            Controls.Add(MainScreenTitle);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(ProductsTable);
            Controls.Add(PartsTable);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Main Screen";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PartsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button PartSearchButton;
        private TextBox PartsSearchBar;
        private Panel panel1;
        private Panel panel2;
        private Button PartAddButton;
        private Button PartModifyButton;
        private Button PartDeleteButton;
        private DataGridView PartsTable;
        private DataGridView ProductsTable;
        private Panel panel3;
        private Button ProductSearchButton;
        private TextBox ProductSearchBar;
        private Panel panel4;
        private Button ExitButton;
        private Button ProductAddButton;
        private Button ProductDeleteButton;
        private Button ProductModifyButton;
        private Label MainScreenTitle;
        private Label PartsTableTitle;
        private Label ProductTableTitle;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private BindingSource inventoryBindingSource;
        private BindingSource allPartsBindingSource;
        private BindingSource productsBindingSource;
        private DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
    }
}
