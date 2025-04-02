namespace WinFormsApp1
{
    partial class Add_Product
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
            components = new System.ComponentModel.Container();
            productScreenTitle = new Label();
            productSearchButton = new Button();
            productSearchBar = new TextBox();
            productAllParts = new DataGridView();
            partIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inStockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            partBindingSource = new BindingSource(components);
            productAddButton = new Button();
            addProductTableTitle = new Label();
            productRelatedParts = new DataGridView();
            addProductDeleteButton = new Button();
            addProductCancelButton = new Button();
            addProductSaveButton = new Button();
            addProductID = new Label();
            addProductName = new Label();
            addProductInventory = new Label();
            addProductPrice = new Label();
            addProductMax = new Label();
            addProductMin = new Label();
            panel1 = new Panel();
            addProductMinText = new TextBox();
            addProductMaxText = new TextBox();
            addProductPriceText = new TextBox();
            addProductInventoryText = new TextBox();
            addProductNameText = new TextBox();
            addProductIDTextBox = new TextBox();
            productRelatedPartsTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)productAllParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productRelatedParts).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // productScreenTitle
            // 
            productScreenTitle.AutoSize = true;
            productScreenTitle.Font = new Font("Segoe UI", 14F);
            productScreenTitle.Location = new Point(39, 27);
            productScreenTitle.Name = "productScreenTitle";
            productScreenTitle.Size = new Size(117, 25);
            productScreenTitle.TabIndex = 0;
            productScreenTitle.Text = "Add Product";
            // 
            // productSearchButton
            // 
            productSearchButton.Location = new Point(661, 87);
            productSearchButton.Name = "productSearchButton";
            productSearchButton.Size = new Size(75, 23);
            productSearchButton.TabIndex = 1;
            productSearchButton.Text = "Search";
            productSearchButton.UseVisualStyleBackColor = true;
            // 
            // productSearchBar
            // 
            productSearchBar.Location = new Point(742, 87);
            productSearchBar.Name = "productSearchBar";
            productSearchBar.Size = new Size(303, 23);
            productSearchBar.TabIndex = 2;
            // 
            // productAllParts
            // 
            productAllParts.AllowUserToAddRows = false;
            productAllParts.AllowUserToDeleteRows = false;
            productAllParts.AutoGenerateColumns = false;
            productAllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productAllParts.Columns.AddRange(new DataGridViewColumn[] { partIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, inStockDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, minDataGridViewTextBoxColumn, maxDataGridViewTextBoxColumn });
            productAllParts.DataSource = partBindingSource;
            productAllParts.Location = new Point(442, 129);
            productAllParts.MultiSelect = false;
            productAllParts.Name = "productAllParts";
            productAllParts.ReadOnly = true;
            productAllParts.RowHeadersVisible = false;
            productAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productAllParts.Size = new Size(603, 221);
            productAllParts.TabIndex = 3;
            productAllParts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            partIDDataGridViewTextBoxColumn.HeaderText = "Part ID";
            partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            partIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // partBindingSource
            // 
            partBindingSource.DataSource = typeof(Part);
            // 
            // productAddButton
            // 
            productAddButton.Location = new Point(952, 372);
            productAddButton.Name = "productAddButton";
            productAddButton.Size = new Size(75, 34);
            productAddButton.TabIndex = 4;
            productAddButton.Text = "Add";
            productAddButton.UseVisualStyleBackColor = true;
            productAddButton.Click += productAddButton_Click;
            // 
            // addProductTableTitle
            // 
            addProductTableTitle.AutoSize = true;
            addProductTableTitle.Font = new Font("Segoe UI", 10F);
            addProductTableTitle.Location = new Point(441, 103);
            addProductTableTitle.Name = "addProductTableTitle";
            addProductTableTitle.Size = new Size(122, 19);
            addProductTableTitle.TabIndex = 5;
            addProductTableTitle.Text = "All candidate Parts";
            // 
            // productRelatedParts
            // 
            productRelatedParts.AllowUserToAddRows = false;
            productRelatedParts.AllowUserToDeleteRows = false;
            productRelatedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productRelatedParts.Location = new Point(442, 441);
            productRelatedParts.Name = "productRelatedParts";
            productRelatedParts.ReadOnly = true;
            productRelatedParts.RowHeadersVisible = false;
            productRelatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productRelatedParts.Size = new Size(603, 199);
            productRelatedParts.TabIndex = 6;
            // 
            // addProductDeleteButton
            // 
            addProductDeleteButton.Location = new Point(952, 659);
            addProductDeleteButton.Name = "addProductDeleteButton";
            addProductDeleteButton.Size = new Size(75, 32);
            addProductDeleteButton.TabIndex = 7;
            addProductDeleteButton.Text = "Delete";
            addProductDeleteButton.UseVisualStyleBackColor = true;
            addProductDeleteButton.Click += addProductDeleteButton_Click;
            // 
            // addProductCancelButton
            // 
            addProductCancelButton.Location = new Point(952, 712);
            addProductCancelButton.Name = "addProductCancelButton";
            addProductCancelButton.Size = new Size(75, 32);
            addProductCancelButton.TabIndex = 8;
            addProductCancelButton.Text = "Cancel";
            addProductCancelButton.UseVisualStyleBackColor = true;
            addProductCancelButton.Click += addProductCancelButton_Click;
            // 
            // addProductSaveButton
            // 
            addProductSaveButton.Location = new Point(853, 712);
            addProductSaveButton.Name = "addProductSaveButton";
            addProductSaveButton.Size = new Size(75, 32);
            addProductSaveButton.TabIndex = 9;
            addProductSaveButton.Text = "Save";
            addProductSaveButton.UseVisualStyleBackColor = true;
            addProductSaveButton.Click += addProductSaveButton_Click;
            // 
            // addProductID
            // 
            addProductID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            addProductID.AutoSize = true;
            addProductID.Location = new Point(28, 17);
            addProductID.Name = "addProductID";
            addProductID.Size = new Size(18, 15);
            addProductID.TabIndex = 10;
            addProductID.Text = "ID";
            addProductID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // addProductName
            // 
            addProductName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            addProductName.AutoSize = true;
            addProductName.Location = new Point(28, 55);
            addProductName.Name = "addProductName";
            addProductName.Size = new Size(39, 15);
            addProductName.TabIndex = 11;
            addProductName.Text = "Name";
            addProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // addProductInventory
            // 
            addProductInventory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            addProductInventory.AutoSize = true;
            addProductInventory.Location = new Point(28, 92);
            addProductInventory.Name = "addProductInventory";
            addProductInventory.Size = new Size(57, 15);
            addProductInventory.TabIndex = 12;
            addProductInventory.Text = "Inventory";
            addProductInventory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // addProductPrice
            // 
            addProductPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            addProductPrice.AutoSize = true;
            addProductPrice.Location = new Point(28, 132);
            addProductPrice.Name = "addProductPrice";
            addProductPrice.Size = new Size(33, 15);
            addProductPrice.TabIndex = 13;
            addProductPrice.Text = "Price";
            addProductPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // addProductMax
            // 
            addProductMax.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            addProductMax.AutoSize = true;
            addProductMax.Location = new Point(28, 175);
            addProductMax.Name = "addProductMax";
            addProductMax.Size = new Size(30, 15);
            addProductMax.TabIndex = 14;
            addProductMax.Text = "Max";
            addProductMax.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // addProductMin
            // 
            addProductMin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            addProductMin.AutoSize = true;
            addProductMin.Location = new Point(211, 175);
            addProductMin.Name = "addProductMin";
            addProductMin.Size = new Size(28, 15);
            addProductMin.TabIndex = 15;
            addProductMin.Text = "Min";
            // 
            // panel1
            // 
            panel1.Controls.Add(addProductMinText);
            panel1.Controls.Add(addProductMaxText);
            panel1.Controls.Add(addProductPriceText);
            panel1.Controls.Add(addProductInventoryText);
            panel1.Controls.Add(addProductNameText);
            panel1.Controls.Add(addProductIDTextBox);
            panel1.Controls.Add(addProductName);
            panel1.Controls.Add(addProductMin);
            panel1.Controls.Add(addProductID);
            panel1.Controls.Add(addProductMax);
            panel1.Controls.Add(addProductInventory);
            panel1.Controls.Add(addProductPrice);
            panel1.Location = new Point(39, 283);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 221);
            panel1.TabIndex = 16;
            // 
            // addProductMinText
            // 
            addProductMinText.Location = new Point(257, 172);
            addProductMinText.Name = "addProductMinText";
            addProductMinText.Size = new Size(84, 23);
            addProductMinText.TabIndex = 21;
            addProductMinText.TextChanged += addProductMinText_TextChanged;
            // 
            // addProductMaxText
            // 
            addProductMaxText.Location = new Point(88, 172);
            addProductMaxText.Name = "addProductMaxText";
            addProductMaxText.Size = new Size(84, 23);
            addProductMaxText.TabIndex = 20;
            addProductMaxText.TextChanged += addProductMaxText_TextChanged;
            // 
            // addProductPriceText
            // 
            addProductPriceText.Location = new Point(129, 129);
            addProductPriceText.Name = "addProductPriceText";
            addProductPriceText.Size = new Size(151, 23);
            addProductPriceText.TabIndex = 19;
            addProductPriceText.TextChanged += addProductPriceText_TextChanged;
            // 
            // addProductInventoryText
            // 
            addProductInventoryText.Location = new Point(129, 89);
            addProductInventoryText.Name = "addProductInventoryText";
            addProductInventoryText.Size = new Size(151, 23);
            addProductInventoryText.TabIndex = 18;
            addProductInventoryText.TextChanged += addProductInventoryText_TextChanged;
            // 
            // addProductNameText
            // 
            addProductNameText.Location = new Point(129, 52);
            addProductNameText.Name = "addProductNameText";
            addProductNameText.Size = new Size(151, 23);
            addProductNameText.TabIndex = 17;
            addProductNameText.TextChanged += addProductNameText_TextChanged;
            // 
            // addProductIDTextBox
            // 
            addProductIDTextBox.Location = new Point(129, 14);
            addProductIDTextBox.Name = "addProductIDTextBox";
            addProductIDTextBox.ReadOnly = true;
            addProductIDTextBox.Size = new Size(151, 23);
            addProductIDTextBox.TabIndex = 16;
            addProductIDTextBox.TextChanged += addProductIDTextBox_TextChanged;
            // 
            // productRelatedPartsTitle
            // 
            productRelatedPartsTitle.AutoSize = true;
            productRelatedPartsTitle.Font = new Font("Segoe UI", 10F);
            productRelatedPartsTitle.Location = new Point(439, 415);
            productRelatedPartsTitle.Name = "productRelatedPartsTitle";
            productRelatedPartsTitle.Size = new Size(217, 19);
            productRelatedPartsTitle.TabIndex = 17;
            productRelatedPartsTitle.Text = "Parts Associated with this Product";
            // 
            // Add_Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 795);
            Controls.Add(productRelatedPartsTitle);
            Controls.Add(panel1);
            Controls.Add(addProductSaveButton);
            Controls.Add(addProductCancelButton);
            Controls.Add(addProductDeleteButton);
            Controls.Add(productRelatedParts);
            Controls.Add(addProductTableTitle);
            Controls.Add(productAddButton);
            Controls.Add(productAllParts);
            Controls.Add(productSearchBar);
            Controls.Add(productSearchButton);
            Controls.Add(productScreenTitle);
            Name = "Add_Product";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)productAllParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)partBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productRelatedParts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productScreenTitle;
        private Button productSearchButton;
        private TextBox productSearchBar;
        private DataGridView productAllParts;
        private Button productAddButton;
        private Label addProductTableTitle;
        private DataGridView productRelatedParts;
        private Button addProductDeleteButton;
        private Button addProductCancelButton;
        private Button addProductSaveButton;
        private Label addProductID;
        private Label addProductName;
        private Label addProductInventory;
        private Label addProductPrice;
        private Label addProductMax;
        private Label addProductMin;
        private Panel panel1;
        private TextBox addProductInventoryText;
        private TextBox addProductNameText;
        private TextBox addProductIDTextBox;
        private TextBox addProductPriceText;
        private TextBox addProductMinText;
        private TextBox addProductMaxText;
        private Label productRelatedPartsTitle;
        private DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private BindingSource partBindingSource;
    }
}