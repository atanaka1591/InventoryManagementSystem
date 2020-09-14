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
    public partial class FormMainScreen : Form
    {

        public FormMainScreen()
        {
            InitializeComponent();           
        }

        private void FormMainScreen_Load(object sender, EventArgs e)
        {
            DatagridParts.DataSource = Inventory.allParts;
            //Inventory.addPart("test1",15,13,5,1,33);
            //Inventory.addPart("aki", 15, 13, 5, 1, 33);
            DatagridProd.DataSource = Inventory.products;
            //Inventory.addProduct("product1", 13, 55, 1, 100, Inventory.allParts);
            //Inventory.addProduct("productsample2", 31, 5, 1, 150, Inventory.allParts);
        }

        // When AddParts btn is clicked - hides the main form, checks FormAddPart form instance is not already created, creates one, and shows it
        private void BtnAddParts_Click(object sender, EventArgs e)
        {            
            if (!Application.OpenForms.OfType<FormAddPart>().Any())
            {
                var AddPartForm = new FormAddPart();
                AddPartForm.RefToMainForm = this;
                AddPartForm.Show(this);
                this.Hide();
            }
        }

        // When ModifyParts btn is clicked - hides the main form, checks FormModPart form instance is not already created, creates one, and shows it
        private void BtnModParts_Click(object sender, EventArgs e)
        {
            if (DatagridParts.CurrentCell != null)
            {
                if (!Application.OpenForms.OfType<FormModPart>().Any())
                {
                    var ModPartForm = new FormModPart();
                    ModPartForm.RefToMainForm = this;
                    ModPartForm.Show(this);
                    this.Hide();

                    //Takes selected row's data from allParts bindingList
                    int listIndex = DatagridParts.CurrentCell.RowIndex;
                    int partId = Inventory.allParts[listIndex].PartID;
                    string name = Inventory.allParts[listIndex].Name;
                    int inventory = Inventory.allParts[listIndex].InStock;
                    decimal price = Inventory.allParts[listIndex].Price;
                    int max = Inventory.allParts[listIndex].Max;
                    int min = Inventory.allParts[listIndex].Min;
                    //if the selected row's data contains MachineID property, pass that and rest of data to populatePartInfo method
                    if (Inventory.allParts[listIndex].GetType().GetProperty("MachineID") != null)
                    {
                        int machineId = ((Inhouse)Inventory.allParts[listIndex]).MachineID;
                        ModPartForm.populatePartInfo(partId, name, inventory, price, max, min, machineId);
                    }
                    //if the selected row's data contains CompanyName property, pass that and rest of data to populatePartInfo method
                    if (Inventory.allParts[listIndex].GetType().GetProperty("CompanyName") != null)
                    {
                        string companyName = ((Outsourced)Inventory.allParts[listIndex]).CompanyName;
                        ModPartForm.populatePartInfo(partId, name, inventory, price, max, min, companyName);
                    }
                }
            }
        }

        //Calls the method to delete the selected part
        private void BtnDelParts_Click(object sender, EventArgs e)
        {
            if (DatagridParts.CurrentCell == null)
            {
                MessageBox.Show("Please select a part you want to delete.");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this part?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var inventory = new Inventory();
                    if (inventory.deletePart(DatagridParts.CurrentCell.RowIndex))
                    {
                        MessageBox.Show("Part has been deleted.");
                    }
                    else
                    {
                        MessageBox.Show("Part was not deleted.");
                    }
                }
            }
        }

        //search part names, return list of partIDs, only make visible rows that match those partIDs
        private void BtnSearchParts_Click(object sender, EventArgs e)
        {
            List<int> partIDs = new List<int>();
            partIDs = Inventory.lookupPart(InputSearchParts.Text);

            CurrencyManager currencyManager = (CurrencyManager)BindingContext[DatagridParts.DataSource];
            currencyManager.SuspendBinding();

            //if empty string is searched, make all rows visible
            if (InputSearchParts.Text == "")
            {
                for (int u = 0; u < DatagridParts.RowCount; u++)
                {
                    DatagridParts.Rows[u].Visible = true;
                }
            }
            else
            {
                for (int u = 0; u < DatagridParts.RowCount; u++)
                {
                    DatagridParts.Rows[u].Visible = false;
                    for (int i = 0; i <= partIDs.Count - 1; i++)
                    {
                        if (DatagridParts.Rows[u].Visible == false)
                        {
                            if (DatagridParts.Rows[u].Cells[0].Value.ToString() == partIDs[i].ToString())
                            {
                                DatagridParts.Rows[u].Visible = true;
                            }
                            else
                            {
                                DatagridParts.Rows[u].Visible = false;
                            }
                        }
                    }
                }
            }
            currencyManager.ResumeBinding();
        }

        // Hide main form and show Add Product form
        private void BtnAddProd_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<FormAddProd>().Any())
            {
                var AddProdForm = new FormAddProd();
                AddProdForm.RefToMainForm = this;
                AddProdForm.Show(this);
                this.Hide();
            }
        }

        // Hide main form and show Modify Product form
        private void BtnModProd_Click(object sender, EventArgs e)
        {
            if (DatagridProd.CurrentCell != null)
            {
                if (!Application.OpenForms.OfType<FormModProd>().Any())
                {
                    var ModProdForm = new FormModProd();
                    ModProdForm.RefToMainForm = this;
                    ModProdForm.Show(this);
                    this.Hide();

                    //Takes selected row's data from products bindingList
                    int listIndex = DatagridProd.CurrentCell.RowIndex;
                    int prodId = Inventory.products[listIndex].ProductID;
                    string name = Inventory.products[listIndex].Name;
                    int inventory = Inventory.products[listIndex].InStock;
                    decimal price = Inventory.products[listIndex].Price;
                    int max = Inventory.products[listIndex].Max;
                    int min = Inventory.products[listIndex].Min;
                    BindingList<Part> associatedParts = Inventory.products[listIndex].AssociatedParts;

                    ModProdForm.populateProductInfo(prodId, name, inventory, price, max, min, associatedParts);
                }
            }
        }

        //calls the method to delete selected product
        private void BtnDelProd_Click(object sender, EventArgs e)
        {
            if (DatagridProd.CurrentCell == null)
            {
                MessageBox.Show("Please select a product you want to delete.");
            }
            else
            {
                var inventory = new Inventory();
                if (inventory.removeProduct(DatagridProd.CurrentCell.RowIndex))
                {
                    MessageBox.Show("Product has been deleted.");
                }
                else
                {
                    MessageBox.Show("Product was not deleted.");
                }
            }
        }

        //search product name, return list of productIDs, only make visible rows that match those productIDs
        private void BtnSearchProd_Click(object sender, EventArgs e)
        {
            List<int> productIDs = new List<int>();
            productIDs = Inventory.lookupProduct(InputSearchProd.Text);
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[DatagridProd.DataSource];
            currencyManager.SuspendBinding();

            //if empty string is searched, make all rows visible
            if (InputSearchProd.Text == "")
            {
                for (int u = 0; u < DatagridProd.RowCount; u++)
                {
                    DatagridProd.Rows[u].Visible = true;
                }
            }
            else
            {
                for (int u = 0; u < DatagridProd.RowCount; u++)
                {
                    DatagridProd.Rows[u].Visible = false;
                    for (int i = 0; i <= productIDs.Count - 1; i++)
                    {
                        if (DatagridProd.Rows[u].Visible == false)
                        {
                            if (DatagridProd.Rows[u].Cells[0].Value.ToString() == productIDs[i].ToString())
                            {
                                DatagridProd.Rows[u].Visible = true;
                            }
                            else
                            {
                                DatagridProd.Rows[u].Visible = false;
                            }
                        }
                    }
                }
            }
            currencyManager.ResumeBinding();
        }

        // Application is closed when Exit is clicked
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      
    }
}
