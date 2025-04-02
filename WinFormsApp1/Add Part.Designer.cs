namespace WinFormsApp1
{
    partial class Add_Part
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
            partTitle = new Label();
            partInHouse = new RadioButton();
            partOutsourced = new RadioButton();
            panel1 = new Panel();
            addPartID = new Label();
            addPartName = new Label();
            addPartInventory = new Label();
            addPartCost = new Label();
            addPartMax = new Label();
            addPartMin = new Label();
            addPartOrigin = new Label();
            addPartSaveButton = new Button();
            addPartCancelButton = new Button();
            partIDTextBox = new TextBox();
            partNameTextBox = new TextBox();
            partInventoryTextBox = new TextBox();
            partCostTextBox = new TextBox();
            partMaxTextBox = new TextBox();
            partMinTextBox = new TextBox();
            partOriginTextBox = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // partTitle
            // 
            partTitle.AutoSize = true;
            partTitle.Font = new Font("Segoe UI", 14F);
            partTitle.Location = new Point(12, 9);
            partTitle.Name = "partTitle";
            partTitle.Size = new Size(84, 25);
            partTitle.TabIndex = 0;
            partTitle.Text = "Add Part";
            // 
            // partInHouse
            // 
            partInHouse.AutoSize = true;
            partInHouse.Location = new Point(3, 3);
            partInHouse.Name = "partInHouse";
            partInHouse.Size = new Size(74, 19);
            partInHouse.TabIndex = 1;
            partInHouse.TabStop = true;
            partInHouse.Text = "In-House";
            partInHouse.UseVisualStyleBackColor = true;
            partInHouse.CheckedChanged += partInHouse_CheckedChanged;
            // 
            // partOutsourced
            // 
            partOutsourced.AutoSize = true;
            partOutsourced.Location = new Point(83, 3);
            partOutsourced.Name = "partOutsourced";
            partOutsourced.Size = new Size(87, 19);
            partOutsourced.TabIndex = 2;
            partOutsourced.TabStop = true;
            partOutsourced.Text = "Outsourced";
            partOutsourced.UseVisualStyleBackColor = true;
            partOutsourced.CheckedChanged += partOutsourced_CheckedChanged;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(partInHouse);
            panel1.Controls.Add(partOutsourced);
            panel1.Location = new Point(119, 9);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 25);
            panel1.TabIndex = 3;
            // 
            // addPartID
            // 
            addPartID.AutoSize = true;
            addPartID.Location = new Point(113, 83);
            addPartID.Name = "addPartID";
            addPartID.Size = new Size(18, 15);
            addPartID.TabIndex = 4;
            addPartID.Text = "ID";
            addPartID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // addPartName
            // 
            addPartName.AutoSize = true;
            addPartName.Location = new Point(92, 121);
            addPartName.Name = "addPartName";
            addPartName.Size = new Size(39, 15);
            addPartName.TabIndex = 5;
            addPartName.Text = "Name";
            addPartName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // addPartInventory
            // 
            addPartInventory.AutoSize = true;
            addPartInventory.Location = new Point(74, 157);
            addPartInventory.Name = "addPartInventory";
            addPartInventory.Size = new Size(57, 15);
            addPartInventory.TabIndex = 6;
            addPartInventory.Text = "Inventory";
            addPartInventory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // addPartCost
            // 
            addPartCost.AutoSize = true;
            addPartCost.Location = new Point(63, 198);
            addPartCost.Name = "addPartCost";
            addPartCost.Size = new Size(68, 15);
            addPartCost.TabIndex = 7;
            addPartCost.Text = "Price / Cost";
            addPartCost.TextAlign = ContentAlignment.MiddleRight;
            // 
            // addPartMax
            // 
            addPartMax.AutoSize = true;
            addPartMax.Location = new Point(101, 240);
            addPartMax.Name = "addPartMax";
            addPartMax.Size = new Size(30, 15);
            addPartMax.TabIndex = 8;
            addPartMax.Text = "Max";
            // 
            // addPartMin
            // 
            addPartMin.AutoSize = true;
            addPartMin.Location = new Point(264, 240);
            addPartMin.Name = "addPartMin";
            addPartMin.Size = new Size(28, 15);
            addPartMin.TabIndex = 9;
            addPartMin.Text = "Min";
            // 
            // addPartOrigin
            // 
            addPartOrigin.Anchor = AnchorStyles.Right;
            addPartOrigin.Location = new Point(37, 278);
            addPartOrigin.Name = "addPartOrigin";
            addPartOrigin.Size = new Size(94, 15);
            addPartOrigin.TabIndex = 10;
            addPartOrigin.Text = "Company Name";
            addPartOrigin.TextAlign = ContentAlignment.MiddleRight;
            // 
            // addPartSaveButton
            // 
            addPartSaveButton.Location = new Point(254, 325);
            addPartSaveButton.Name = "addPartSaveButton";
            addPartSaveButton.Size = new Size(75, 23);
            addPartSaveButton.TabIndex = 11;
            addPartSaveButton.Text = "Save";
            addPartSaveButton.UseVisualStyleBackColor = true;
            addPartSaveButton.Click += addPartSaveButton_Click;
            // 
            // addPartCancelButton
            // 
            addPartCancelButton.Location = new Point(335, 325);
            addPartCancelButton.Name = "addPartCancelButton";
            addPartCancelButton.Size = new Size(75, 23);
            addPartCancelButton.TabIndex = 12;
            addPartCancelButton.Text = "Cancel";
            addPartCancelButton.UseVisualStyleBackColor = true;
            addPartCancelButton.Click += addPartCancelButton_Click;
            // 
            // partIDTextBox
            // 
            partIDTextBox.Location = new Point(146, 80);
            partIDTextBox.Name = "partIDTextBox";
            partIDTextBox.ReadOnly = true;
            partIDTextBox.Size = new Size(143, 23);
            partIDTextBox.TabIndex = 13;
            // 
            // partNameTextBox
            // 
            partNameTextBox.Location = new Point(146, 118);
            partNameTextBox.Name = "partNameTextBox";
            partNameTextBox.Size = new Size(143, 23);
            partNameTextBox.TabIndex = 14;
            partNameTextBox.TextChanged += partNameTextBox_TextChanged;
            // 
            // partInventoryTextBox
            // 
            partInventoryTextBox.Location = new Point(146, 154);
            partInventoryTextBox.Name = "partInventoryTextBox";
            partInventoryTextBox.Size = new Size(143, 23);
            partInventoryTextBox.TabIndex = 15;
            partInventoryTextBox.TextChanged += partInventoryTextBox_TextChanged;
            // 
            // partCostTextBox
            // 
            partCostTextBox.Location = new Point(146, 195);
            partCostTextBox.Name = "partCostTextBox";
            partCostTextBox.Size = new Size(143, 23);
            partCostTextBox.TabIndex = 16;
            partCostTextBox.TextChanged += partCostTextBox_TextChanged;
            // 
            // partMaxTextBox
            // 
            partMaxTextBox.Location = new Point(146, 237);
            partMaxTextBox.Name = "partMaxTextBox";
            partMaxTextBox.Size = new Size(85, 23);
            partMaxTextBox.TabIndex = 17;
            partMaxTextBox.TextChanged += partMaxTextBox_TextChanged;
            // 
            // partMinTextBox
            // 
            partMinTextBox.Location = new Point(310, 237);
            partMinTextBox.Name = "partMinTextBox";
            partMinTextBox.Size = new Size(81, 23);
            partMinTextBox.TabIndex = 18;
            partMinTextBox.TextChanged += partMinTextBox_TextChanged;
            // 
            // partOriginTextBox
            // 
            partOriginTextBox.Location = new Point(146, 275);
            partOriginTextBox.Name = "partOriginTextBox";
            partOriginTextBox.Size = new Size(143, 23);
            partOriginTextBox.TabIndex = 19;
            partOriginTextBox.TextChanged += partOriginTextBox_TextChanged;
            // 
            // Add_Part
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 371);
            Controls.Add(partOriginTextBox);
            Controls.Add(partMinTextBox);
            Controls.Add(partMaxTextBox);
            Controls.Add(partCostTextBox);
            Controls.Add(partInventoryTextBox);
            Controls.Add(partNameTextBox);
            Controls.Add(partIDTextBox);
            Controls.Add(addPartCancelButton);
            Controls.Add(addPartSaveButton);
            Controls.Add(addPartOrigin);
            Controls.Add(addPartMin);
            Controls.Add(addPartMax);
            Controls.Add(addPartCost);
            Controls.Add(addPartInventory);
            Controls.Add(addPartName);
            Controls.Add(addPartID);
            Controls.Add(panel1);
            Controls.Add(partTitle);
            Name = "Add_Part";
            Text = "Part";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label partTitle;
        private RadioButton partInHouse;
        private RadioButton partOutsourced;
        private Panel panel1;
        private Label addPartID;
        private Label addPartName;
        private Label addPartInventory;
        private Label addPartCost;
        private Label addPartMax;
        private Label addPartMin;
        private Label addPartOrigin;
        private Button addPartSaveButton;
        private Button addPartCancelButton;
        private TextBox partIDTextBox;
        private TextBox partNameTextBox;
        private TextBox partInventoryTextBox;
        private TextBox partCostTextBox;
        private TextBox partMaxTextBox;
        private TextBox partMinTextBox;
        private TextBox partOriginTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}