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
    public partial class FormAddProd : Form
    {
        public FormAddProd()
        {
            InitializeComponent();
            DatagridParts2.DataSource = Inventory.allParts;
            DataGridProdParts.DataSource = associatedParts;
        }

        BindingList<Part> associatedParts = new BindingList<Part>();

        // Reference to FormMainScreen required to make it visible again when this form is closed
        public Form RefToMainForm { get; set; }

        // Closes form when Cancel is clicked and shows Main Form
        private void BtnAddProdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToMainForm.Show();
        }

        // Adds part to temp associatedPart list
        private void BtnAddProdPart_Click(object sender, EventArgs e)
        {
            int listIndex = DatagridParts2.CurrentCell.RowIndex;
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
            if (DataGridProdParts.CurrentCell == null)
            {
                MessageBox.Show("Please select a part you want to remove.");
            }
            else
            {
                var product = new Product();
                if (product.removeAssociatedPart(DataGridProdParts.CurrentCell.RowIndex, associatedParts))
                {
                    MessageBox.Show("Part has been removed.");
                }
                else
                {
                    MessageBox.Show("Part was not removed.");
                }
            }
        }

        // search part names, return list of partIDs, only make visible rows that match those partIDs
        private void BtnSearchParts_Click(object sender, EventArgs e)
        {
            List<int> partIDs = new List<int>();
            partIDs = Product.lookupAssociatedPart(InputSearchParts.Text);

            CurrencyManager currencyManager = (CurrencyManager)BindingContext[DatagridParts2.DataSource];
            currencyManager.SuspendBinding();

            //if empty string is searched, make all rows visible
            if (InputSearchParts.Text == "")
            {
                for (int u = 0; u < DatagridParts2.RowCount; u++)
                {
                    DatagridParts2.Rows[u].Visible = true;
                }
            }
            else
            {
                for (int u = 0; u < DatagridParts2.RowCount; u++)
                {
                    DatagridParts2.Rows[u].Visible = false;
                    for (int i = 0; i <= partIDs.Count - 1; i++)
                    {
                        if (DatagridParts2.Rows[u].Visible == false)
                        {
                            if (DatagridParts2.Rows[u].Cells[0].Value.ToString() == partIDs[i].ToString())
                            {
                                DatagridParts2.Rows[u].Visible = true;
                            }
                            else
                            {
                                DatagridParts2.Rows[u].Visible = false;
                            }
                        }
                    }
                }
            }
            currencyManager.ResumeBinding();
        }

        //adds product
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
                    Inventory.addProduct(InputProdName.Text, Convert.ToDecimal(InputProdPrice.Text), int.Parse(InputProdInventory.Text), int.Parse(InputProdMin.Text), int.Parse(InputProdMax.Text), associatedParts);
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
