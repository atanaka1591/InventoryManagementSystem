using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aki_Tanaka_C968
{
    public partial class FormModProd : Form
    {
        public FormModProd()
        {
            InitializeComponent();
            DatagridParts3.DataSource = Inventory.allParts;
            //DataGridProdParts2.DataSource = associatedParts;
        }
        
        BindingList<Part> associatedParts = new BindingList<Part>();

        // Reference to FormMainScreen required to make main form visible again when this form is closed
        public Form RefToMainForm { get; set; }

        // Closes form when Cancel is clicked and shows Main Form
        private void BtnAddProdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToMainForm.Show();
        }

        //displays the data on Modify Product form
        public void populateProductInfo(int id, string name, int inventory, decimal price, int max, int min, BindingList<Part> associatedPartsEntry)
        {
            TextboxProdId.Text = id.ToString();
            InputProdName.Text = name;
            InputProdInventory.Text = inventory.ToString();
            InputProdPrice.Text = price.ToString();
            InputProdMax.Text = max.ToString();
            InputProdMin.Text = min.ToString();
            associatedParts = associatedPartsEntry;
            DataGridProdParts2.DataSource = associatedParts;
        }

        // Adds part to temp associatedPart list
        private void BtnAddProdPartMod_Click(object sender, EventArgs e)
        {
            int listIndex = DatagridParts3.CurrentCell.RowIndex;
            int partId = Inventory.allParts[listIndex].PartID;
            string name = Inventory.allParts[listIndex].Name;
            int inventory = Inventory.allParts[listIndex].InStock;
            decimal price = Inventory.allParts[listIndex].Price;
            int max = Inventory.allParts[listIndex].Max;
            int min = Inventory.allParts[listIndex].Min;
            Product.addAssociatedPart(partId, name, inventory, price, min, max, associatedParts);
        }

        // Removes part from temp associatedPart list
        private void BtnRemoveProdPart_Click(object sender, EventArgs e)
        {
            if (DataGridProdParts2.CurrentCell == null)
            {
                MessageBox.Show("Please select a part you want to remove.");
            }
            else
            {
                var product = new Product();
                if (product.removeAssociatedPart(DataGridProdParts2.CurrentCell.RowIndex, associatedParts))
                {
                    MessageBox.Show("Part has been removed.");
                }
                else
                {
                    MessageBox.Show("Part was not removed.");
                }
            }
        }

        //searches by parts name
        private void BtnSearchParts_Click(object sender, EventArgs e)
        {
            List<int> partIDs = new List<int>();
            partIDs = Product.lookupAssociatedPart(InputSearchParts.Text);

            CurrencyManager currencyManager = (CurrencyManager)BindingContext[DatagridParts3.DataSource];
            currencyManager.SuspendBinding();

            //if empty string is searched, make all rows visible
            if (InputSearchParts.Text == "")
            {
                for (int u = 0; u < DatagridParts3.RowCount; u++)
                {
                    DatagridParts3.Rows[u].Visible = true;
                }
            }
            else
            {
                for (int u = 0; u < DatagridParts3.RowCount; u++)
                {
                    DatagridParts3.Rows[u].Visible = false;
                    for (int i = 0; i <= partIDs.Count - 1; i++)
                    {
                        if (DatagridParts3.Rows[u].Visible == false)
                        {
                            if (DatagridParts3.Rows[u].Cells[0].Value.ToString() == partIDs[i].ToString())
                            {
                                DatagridParts3.Rows[u].Visible = true;
                            }
                            else
                            {
                                DatagridParts3.Rows[u].Visible = false;
                            }
                        }
                    }
                }
            }
            currencyManager.ResumeBinding();
        }

        //updates the product
        private void BtnSaveProd_Click(object sender, EventArgs e)
        {
            if (InputProdName.Text == string.Empty || InputProdInventory.Text == string.Empty || InputProdPrice.Text == string.Empty || InputProdMax.Text == string.Empty || InputProdMin.Text == string.Empty)
            {
                MessageBox.Show("All fields must be entered.");
            }
            else
            {
                if (int.Parse(InputProdMax.Text) < int.Parse(InputProdMin.Text))
                {
                    MessageBox.Show("Min must be less than Max.");
                }
                else if (int.Parse(InputProdInventory.Text) < int.Parse(InputProdMin.Text) || int.Parse(InputProdInventory.Text) > int.Parse(InputProdMax.Text))
                {
                    MessageBox.Show("Inventory value must be between the Min and Max.");
                }
                else
                {
                    Inventory.updateProduct(InputProdName.Text, Convert.ToDecimal(InputProdPrice.Text), int.Parse(InputProdInventory.Text), int.Parse(InputProdMin.Text), int.Parse(InputProdMax.Text), int.Parse(TextboxProdId.Text), associatedParts);
                    this.Close();
                    this.RefToMainForm.Show();
                }
            }
        }

        //form validations
        private void InputProdInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void InputProdPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void InputProdMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void InputProdMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
