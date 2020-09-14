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
    public partial class FormModPart : Form
    {
        public FormModPart()
        {
            InitializeComponent();
        }

        // Reference to FormMainScreen required to make it visible again when this form is closed
        public Form RefToMainForm { get; set; }

        // Changes the label to Machine ID depending on radio button
        private void InputInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == InputInHouse)
            {
                LabelMachineId.Text = "Machine ID";
            }
        }

        // Changes the label to Company Name depending on radio button
        private void InputOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == InputOutsourced)
            {
                LabelMachineId.Text = "Company Name";
            }
        }

        // Closes form when Cancel is clicked and shows Main Form
        private void BtnModPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToMainForm.Show();
        }

        //displays the data on Modify Part form, includes Machine ID
        public void populatePartInfo(int id, string name, int inventory, decimal price, int max, int min, int machineId)
        {
            TextboxPartId.Text = id.ToString();
            InputPartName.Text = name;
            InputPartInventory.Text = inventory.ToString();
            InputPartPrice.Text = price.ToString();
            InputPartMax.Text = max.ToString();
            InputPartMin.Text = min.ToString();
            InputPartMachineCo.Text = machineId.ToString();
            //int listIndex = index;
            InputInHouse.Checked = true;
        }
        //displays the data on Modify Part form, includes Company Name
        public void populatePartInfo(int id, string name, int inventory, decimal price, int max, int min, string companyName)
        {
            TextboxPartId.Text = id.ToString();
            InputPartName.Text = name;
            InputPartInventory.Text = inventory.ToString();
            InputPartPrice.Text = price.ToString();
            InputPartMax.Text = max.ToString();
            InputPartMin.Text = min.ToString();
            InputPartMachineCo.Text = companyName;
            //listIndex = index;
            InputOutsourced.Checked = true;
        }

        //saves modified part
        private void BtnAddParts_Click(object sender, EventArgs e)
        {         
            if (InputPartName.Text == string.Empty || InputPartInventory.Text == string.Empty || InputPartPrice.Text == string.Empty || InputPartMax.Text == string.Empty || InputPartMin.Text == string.Empty || InputPartMachineCo.Text == string.Empty)
            {
                MessageBox.Show("All fields must be entered.");
            }
            else
            {
                if (int.Parse(InputPartMax.Text) < int.Parse(InputPartMin.Text))
                {
                    MessageBox.Show("Min must be less than Max.");
                }
                else if (int.Parse(InputPartInventory.Text) < int.Parse(InputPartMin.Text) || int.Parse(InputPartInventory.Text) > int.Parse(InputPartMax.Text))
                {
                    MessageBox.Show("Inventory value must be between the Min and Max.");
                }
                else
                {
                    List<Part> list = Inventory.allParts.ToList();
                    int index = list.FindIndex(parts => parts.PartID.Equals(int.Parse(TextboxPartId.Text)));
                    if (InputInHouse.Checked && Inventory.allParts[index].GetType().GetProperty("MachineID") != null)
                    {
                        Inventory.updatePart(InputPartName.Text, Convert.ToDecimal(InputPartPrice.Text), int.Parse(InputPartInventory.Text), int.Parse(InputPartMin.Text), int.Parse(InputPartMax.Text), int.Parse(InputPartMachineCo.Text), int.Parse(TextboxPartId.Text));
                    }
                    else if (InputOutsourced.Checked && Inventory.allParts[index].GetType().GetProperty("CompanyName") != null)
                    {
                        Inventory.updatePart(InputPartName.Text, Convert.ToDecimal(InputPartPrice.Text), int.Parse(InputPartInventory.Text), int.Parse(InputPartMin.Text), int.Parse(InputPartMax.Text), InputPartMachineCo.Text, int.Parse(TextboxPartId.Text));
                    }
                    //if updating from outsourced to inhouse, delete existing outsourced part and add new inhouse part
                    else if (InputInHouse.Checked && Inventory.allParts[index].GetType().GetProperty("MachineID") == null)
                    {
                        var inventory = new Inventory();
                        inventory.deletePart(index);
                        Inventory.addPart(InputPartName.Text, Convert.ToDecimal(InputPartPrice.Text), int.Parse(InputPartInventory.Text), int.Parse(InputPartMax.Text), int.Parse(InputPartMin.Text), int.Parse(InputPartMachineCo.Text));
                    }
                    //if updating from inhouse to outsourced, delete existing inhouse part and add new outsourced part
                    else if (InputOutsourced.Checked && Inventory.allParts[index].GetType().GetProperty("CompanyName") == null)
                    {
                        var inventory = new Inventory();
                        inventory.deletePart(index);
                        Inventory.addPart(InputPartName.Text, Convert.ToDecimal(InputPartPrice.Text), int.Parse(InputPartInventory.Text), int.Parse(InputPartMax.Text), int.Parse(InputPartMin.Text), InputPartMachineCo.Text);
                    }
                    this.Close();
                    this.RefToMainForm.Show();
                }
            }
        }

        //form validations
        private void InputPartInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void InputPartPrice_KeyPress(object sender, KeyPressEventArgs e)
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
        private void InputPartMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void InputPartMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void InputPartMachineCo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (InputInHouse.Checked)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}