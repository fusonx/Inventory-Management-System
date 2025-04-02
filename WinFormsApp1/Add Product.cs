using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Add_Product : Form
    {

        private Inventory inventory;
        private Product productToModify;
        private BindingList<Part> allPartsList;
        public BindingList<Part> associatedParts = new BindingList<Part>();

        public Add_Product(Inventory inventory, Product product = null)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.productToModify = product;
            allPartsList = inventory.AllParts;
            productAllParts.DataSource = allPartsList;
            productRelatedParts.DataSource = associatedParts;
            CustomizeColumnHeaders();

            if (product != null)
            {
                PopulateFormFields(product);
                associatedParts = new BindingList<Part>(product.AssociatedParts);
                productRelatedParts.DataSource = null;
                productRelatedParts.DataSource = associatedParts;
            }
            else
            {
                RequiredFields();
                ValidateForm();
            }
        }


        private void CustomizeColumnHeaders()
        {
            if (productRelatedParts.Columns["PartID"] != null)
            {
                productRelatedParts.Columns["PartID"].HeaderText = "Part ID";
            }

            if (productRelatedParts.Columns["InStock"] != null)
            {
                productRelatedParts.Columns["InStock"].HeaderText = "Inventory";
            }
        }

        private void PopulateFormFields(Product product)
        {
            addProductIDTextBox.Text = product.ProductID.ToString();
            addProductNameText.Text = product.Name;
            addProductInventoryText.Text = product.InStock.ToString();
            addProductPriceText.Text = product.Price.ToString();
            addProductMaxText.Text = product.Max.ToString();
            addProductMinText.Text = product.Min.ToString();

            productRelatedParts.DataSource = associatedParts;



        }


        private void RequiredFields()
        {
            addProductNameText.BackColor = Color.Red;
            addProductInventoryText.BackColor = Color.Red;
            addProductPriceText.BackColor = Color.Red;
            addProductMaxText.BackColor = Color.Red;
            addProductMinText.BackColor = Color.Red;
        }

        private void ValidateForm()
        {
            bool isValid = true;

            if (addProductNameText.BackColor == Color.Red)
            {
                isValid = false;
            }

            if (addProductInventoryText.BackColor == Color.Red)
            {
                isValid = false;
            }

            if (addProductPriceText.BackColor == Color.Red)
            {
                isValid = false;
            }

            if (addProductMaxText.BackColor == Color.Red)
            {
                isValid = false;
            }

            if (addProductMinText.BackColor == Color.Red)
            {
                isValid = false;
            }

            addProductSaveButton.Enabled = isValid;
        }

        private void ValidateLettersOnly(TextBox textBox)
        {
            string pattern = @"^[a-zA-Z\s]+$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(textBox.Text))
            {
                textBox.BackColor = Color.Red;
            }
            else
            {
                textBox.BackColor = SystemColors.Window;
            }
        }

        private void ValidateNumericInput(TextBox textBox)
        {
            if (!int.TryParse(textBox.Text, out _))
            {
                textBox.BackColor = Color.Red;
            }
            else
            {
                textBox.BackColor = SystemColors.Window;
            }
        }

        private void ValidateDecimalInput(TextBox textBox)
        {
            if (!decimal.TryParse(textBox.Text, out _))
            {
                textBox.BackColor = Color.Red;
            }
            else
            {
                textBox.BackColor = SystemColors.Window;
            }
        }

        private void productAddButton_Click(object sender, EventArgs e)
        {
            if (productAllParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a part to add.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Part selectedPart = (Part)productAllParts.CurrentRow.DataBoundItem;

            if (selectedPart != null)
            {
                if (!associatedParts.Contains(selectedPart))
                {
                    associatedParts.Add(selectedPart);
                    productToModify?.addAssociatedPart(selectedPart);


                    productRelatedParts.DataSource = null;
                    productRelatedParts.DataSource = associatedParts;

                }
            }
        }

        private void addProductDeleteButton_Click(object sender, EventArgs e)
        {
            Part selectedPart = (Part)productRelatedParts.CurrentRow.DataBoundItem;
            if (selectedPart != null)
            {
                associatedParts.Remove(selectedPart);

                productRelatedParts.DataSource = null;
                productRelatedParts.DataSource = associatedParts;
            }
        }

        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(addProductMaxText.Text) < int.Parse(addProductMinText.Text))
            {
                MessageBox.Show("Min value cannot be greater than Max value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.Parse(addProductInventoryText.Text) < int.Parse(addProductMinText.Text) || int.Parse(addProductInventoryText.Text) > int.Parse(addProductMaxText.Text))
            {
                MessageBox.Show("Inventory must be between the Min value and Max value", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productName = addProductNameText.Text;
            int inStock = int.Parse(addProductInventoryText.Text);
            decimal price = decimal.Parse(addProductPriceText.Text);
            int max = int.Parse(addProductMaxText.Text);
            int min = int.Parse(addProductMinText.Text);

            if (productToModify != null)
            {
                productToModify.Name = productName;
                productToModify.InStock = inStock;
                productToModify.Price = price;
                productToModify.Max = max;
                productToModify.Min = min;
                productToModify.AssociatedParts = associatedParts;

                inventory.updateProduct(productToModify.ProductID, productToModify);
            }
            else
            {
                Product newProduct = new Product(productName, inStock, price, max, min);
                newProduct.AssociatedParts = associatedParts;
                inventory.addProduct(newProduct);
            }

            this.Close();
        }

        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addProductNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateLettersOnly(addProductNameText);
            ValidateForm();
        }

        private void addProductInventoryText_TextChanged(object sender, EventArgs e)
        {
            ValidateNumericInput(addProductInventoryText);
            ValidateForm();
        }

        private void addProductPriceText_TextChanged(object sender, EventArgs e)
        {
            ValidateDecimalInput(addProductPriceText);
            ValidateForm();
        }

        private void addProductMaxText_TextChanged(object sender, EventArgs e)
        {
            ValidateNumericInput(addProductMaxText);
            ValidateForm();
        }

        private void addProductMinText_TextChanged(object sender, EventArgs e)
        {
            ValidateNumericInput(addProductMinText);
            ValidateForm();
        }












        private void addProductIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
