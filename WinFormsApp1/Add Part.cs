using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Add_Part : Form
    {
        private Inventory inventory;
        private Part partToModify;
        public Add_Part(Inventory inventory, Part part = null)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.partToModify = part;

            if (part != null)
            {
                PopulateFormFields(part);
            }
            else
            {
                RequiredFields();
                ValidateForm();
            }
        }

        private void PopulateFormFields(Part part)
        {
            partIDTextBox.Text = part.PartID.ToString();
            partNameTextBox.Text = part.Name;
            partInventoryTextBox.Text = part.InStock.ToString();
            partCostTextBox.Text = part.Price.ToString();
            partMinTextBox.Text = part.Min.ToString();
            partMaxTextBox.Text = part.Max.ToString();

            if (part is Inhouse inHousePart)
            {
                partInHouse.Checked = true;
                addPartOrigin.Text = "Machine ID";
                partOriginTextBox.Text = inHousePart.MachineID.ToString();
            }
            else if (part is Outsourced outsourcedPart)
            {
                partOutsourced.Checked = true;
                addPartOrigin.Text = "Company Name";
                partOriginTextBox.Text = outsourcedPart.CompanyName;
            }
        }

        private void partInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (partInHouse.Checked)
            {
                addPartOrigin.Text = "Machine ID";
                ValidateNumericInput(partOriginTextBox);
                ValidateForm();
            }
        }

        private void partOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (partOutsourced.Checked)
            {
                addPartOrigin.Text = "Company Name";
                ValidateLettersOnly(partOriginTextBox);
                ValidateForm();
            }
        }

        private void partNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateLettersOnly(partNameTextBox);
            ValidateForm();
        }

        private void partInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateNumericInput(partInventoryTextBox);
            ValidateForm();
        }

        private void partCostTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateDecimalInput(partCostTextBox);
            ValidateForm();
        }

        private void partMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateNumericInput(partMaxTextBox);
            ValidateForm();
        }

        private void partMinTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateNumericInput(partMinTextBox);
            ValidateForm();
        }

        private void partOriginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addPartOrigin.Text == "Machine ID")
            {
                ValidateNumericInput(partOriginTextBox);
            }
            else if (addPartOrigin.Text == "Company Name")
            {
                ValidateLettersOnly(partOriginTextBox);
            }
            ValidateForm();
        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPartSaveButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(partMaxTextBox.Text) < int.Parse(partMinTextBox.Text))
            {
                MessageBox.Show("Min value cannot be greater than Max value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.Parse(partInventoryTextBox.Text) < int.Parse(partMinTextBox.Text) || int.Parse(partInventoryTextBox.Text) > int.Parse(partMaxTextBox.Text))
            {
                MessageBox.Show("Inventory must be between the Min value and Max value", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string partName = partNameTextBox.Text;
            int inStock = int.Parse(partInventoryTextBox.Text);
            decimal price = decimal.Parse(partCostTextBox.Text);
            int min = int.Parse(partMinTextBox.Text);
            int max = int.Parse(partMaxTextBox.Text);

            if (partToModify != null)
            {
                Part updatedPart;

                if (partInHouse.Checked && partToModify is Outsourced)
                {
                    updatedPart = new Inhouse(partToModify, int.Parse(partOriginTextBox.Text));
                }
                else if (partOutsourced.Checked && partToModify is Inhouse)
                {
                    updatedPart = new Outsourced(partToModify, partOriginTextBox.Text);
                }
                else
                {
                    partToModify.Name = partName;
                    partToModify.InStock = inStock;
                    partToModify.Price = price;
                    partToModify.Min = min;
                    partToModify.Max = max;

                    if (partToModify is Inhouse inHousePart)
                    {
                        inHousePart.MachineID = int.Parse(partOriginTextBox.Text);
                    }
                    else if (partToModify is Outsourced outsourcedPart)
                    {
                        outsourcedPart.CompanyName = partOriginTextBox.Text;
                    }

                    updatedPart = partToModify;
                }

                inventory.updatePart(partToModify.PartID, updatedPart);
            }
            else
            {
                Part newPart;

                if (partInHouse.Checked)
                {
                    int machineID = int.Parse(partOriginTextBox.Text);
                    newPart = new Inhouse(partName, inStock, price, min, max, machineID);
                }
                else
                {
                    string companyName = partOriginTextBox.Text;
                    newPart = new Outsourced(partName, inStock, price, min, max, companyName);
                }

                inventory.addPart(newPart);
            }

            this.Close();
        }


        private void RequiredFields()
        {
            partNameTextBox.BackColor = Color.Red;
            partInventoryTextBox.BackColor = Color.Red;
            partCostTextBox.BackColor = Color.Red;
            partMaxTextBox.BackColor = Color.Red;
            partMinTextBox.BackColor = Color.Red;
            partOriginTextBox.BackColor = Color.Red;
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

        private void ValidateForm()
        {
            bool isValid = true;

            if (partNameTextBox.BackColor == Color.Red)
            {
                isValid = false;
            }

            if (partInventoryTextBox.BackColor == Color.Red)
            {
                isValid = false;
            }

            if (partCostTextBox.BackColor == Color.Red)
            {
                isValid = false;
            }

            if (partMaxTextBox.BackColor == Color.Red)
            {
                isValid = false;
            }

            if (partMinTextBox.BackColor == Color.Red)
            {
                isValid = false;
            }

            if (partOriginTextBox.BackColor == Color.Red)
            {
                isValid = false;
            }

            addPartSaveButton.Enabled = isValid;
        }

    }
}
