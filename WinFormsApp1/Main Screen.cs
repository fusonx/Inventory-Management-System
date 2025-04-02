using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Inventory inventory;

        public Form1()
        {
            InitializeComponent();

            inventory = new Inventory();
            PartsTable.DataSource = inventory.AllParts;
            ProductsTable.DataSource = inventory.Products;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = PartsSearchBar.Text.Trim();

            if (int.TryParse(query, out int partID))
            {
                Part foundPart = inventory.lookupPart(partID);
                if (foundPart != null)
                {
                    PartsTable.DataSource = new BindingList<Part> { foundPart };
                }
                else
                {
                    MessageBox.Show("Part not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                BindingList<Part> foundParts = inventory.searchPartsByName(query);
                if (foundParts.Count > 0)
                {
                    PartsTable.DataSource = foundParts;
                }
                else
                {
                    MessageBox.Show("No parts found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PartsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to modify.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Part selectedPart = GetSelectedPart();

            var addPart = new Add_Part(inventory, selectedPart);
            this.Hide();
            addPart.ShowDialog();
            this.Show();

            RefreshTables();

        }

        private Part GetSelectedPart()
        {
            if (PartsTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = PartsTable.SelectedRows[0];

                Part selectedPart = selectedRow.DataBoundItem as Part;

                return selectedPart;
            }

            return null;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var addPart = new Add_Part(inventory);
            this.Hide();
            addPart.ShowDialog();
            this.Show();

            RefreshTables();
        }

        private void partDeleteButon_Click(object sender, EventArgs e)
        {
            if (PartsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Part selectedPart = (Part)PartsTable.SelectedRows[0].DataBoundItem;

            if (inventory.IsPartAssociated(selectedPart.PartID))
            {
                MessageBox.Show("This part is associated with a product and cannot be deleted.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the part '{selectedPart.Name}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                inventory.deletePart(selectedPart);
                MessageBox.Show("Part deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            RefreshTables();
        }

        private void productDeleteButton_Click(object sender, EventArgs e)
        {
            if (ProductsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product selectedProduct = (Product)ProductsTable.SelectedRows[0].DataBoundItem;

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the product '{selectedProduct.Name}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                inventory.removeProduct(selectedProduct.ProductID);
                MessageBox.Show("Product deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            RefreshTables();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductSearchButton_Click(object sender, EventArgs e)
        {
            string query = ProductSearchBar.Text.Trim();

            if (int.TryParse(query, out int productID))
            {
                Product foundProduct = inventory.lookupProduct(productID);
                if (foundProduct != null)
                {
                    ProductsTable.DataSource = new BindingList<Product> { foundProduct };
                }
                else
                {
                    MessageBox.Show("Product not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                BindingList<Product> foundProducts = inventory.searchProductsByName(query);
                if (foundProducts.Count > 0)
                {
                    ProductsTable.DataSource = foundProducts;
                }
                else
                {
                    MessageBox.Show("No products found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ProductAddButton_Click(object sender, EventArgs e)
        {
            var addProduct = new Add_Product(inventory);
            this.Hide();
            addProduct.ShowDialog();
            this.Show();

            RefreshTables();
        }

        private void ProductModifyButton_Click(object sender, EventArgs e)
        {
            if (ProductsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to modify.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product selectedProduct = GetSelectedProduct();
            var addProduct = new Add_Product(inventory, selectedProduct);
            this.Hide();
            addProduct.ShowDialog();
            this.Show();

            RefreshTables();
        }

        private Product GetSelectedProduct()
        {
            if (ProductsTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ProductsTable.SelectedRows[0];

                Product selectedProduct = selectedRow.DataBoundItem as Product;

                return selectedProduct;
            }

            return null;
        }

        private void RefreshTables()
        {
            PartsTable.DataSource = null;
            PartsTable.DataSource = inventory.AllParts;

            ProductsTable.DataSource = null;
            ProductsTable.DataSource = inventory.Products;

            PartsTable.Refresh();
            ProductsTable.Refresh();
        }

        private void PartsSearchBar_TextChanged(object sender, EventArgs e)
        {
            string query = PartsSearchBar.Text.Trim();

            if (query == "")
            {
                PartsTable.DataSource = inventory.AllParts;
            }
        }

        private void ProductSearchBar_TextChanged(object sender, EventArgs e)
        {
            string query = ProductSearchBar.Text.Trim();

            if (query == "")
            {
                ProductsTable.DataSource = inventory.Products;
            }
        }











        private void ProductsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
