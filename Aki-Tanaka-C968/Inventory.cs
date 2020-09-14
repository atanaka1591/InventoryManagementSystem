using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Aki_Tanaka_C968
{
    public class Inventory
    {
        public static BindingList<Part> allParts = new BindingList<Part>();
        public static BindingList<Product> products = new BindingList<Product>();
        private static int partIDIndex = 1;
        private static int productIDIndex = 1;

        public BindingList<Part> AllParts { get; set; }
        public BindingList<Product> Products { get; set; }

        //adds inhouse part to inventory
        public static void addPart(string name, decimal price, int inStock, int max, int min, int machineID)
        {
            allParts.Add(new Inhouse()
            {
                Name = name,
                Price = price,
                InStock = inStock,
                Min = min,
                Max = max,
                MachineID = machineID,
                PartID = partIDIndex
            });
            partIDIndex += 1;
        }

        //adds outsourced part to inventory
        public static void addPart(string name, decimal price, int inStock, int max, int min, string companyName)
        {
            allParts.Add(new Outsourced()
            {
                Name = name,
                Price = price,
                InStock = inStock,
                Min = min,
                Max = max,
                CompanyName = companyName,
                PartID = partIDIndex
            });
            partIDIndex += 1;
        }

        //deletes selected part and returns true or does not delete part and returns false
        public bool deletePart(int deletingRow)
        {             
            /*if (MessageBox.Show("Are you sure you want to delete this part?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {*/
                    allParts.RemoveAt(deletingRow);
                    return true;
                /*}
            else
            {
                return false;
            }*/
        }

        //updates existing inhouse parts
        public static void updatePart(string name, decimal price, int inStock, int max, int min, int machineID, int partID)
        {
            List<Part> list = allParts.ToList();
            int index = list.FindIndex(parts => parts.PartID.Equals(partID));
            allParts[index].Name = name;
            allParts[index].Price = price;
            allParts[index].InStock = inStock;
            allParts[index].Min = min;
            allParts[index].Max = max;
            ((Inhouse)allParts[index]).MachineID = machineID;
        }
        //updates existing outsourced parts
        public static void updatePart(string name, decimal price, int inStock, int max, int min, string companyName, int partID)
        {
            List<Part> list = allParts.ToList();
            int index = list.FindIndex(parts => parts.PartID.Equals(partID));
            allParts[index].Name = name;
            allParts[index].Price = price;
            allParts[index].InStock = inStock;
            allParts[index].Min = min;
            allParts[index].Max = max;
            ((Outsourced)allParts[index]).CompanyName = companyName;
        }

        //finds parts with names that contain the searched text and returns the part IDs
        public static List<int> lookupPart(string name)
        {
            List<int> partIDs = new List<int>();
            for (int i = 0; i <= allParts.Count - 1; i++)
            {
                if (allParts[i].Name.Contains(name))
                {
                    partIDs.Add(allParts[i].PartID);                  
                }
            }
            return partIDs;
        }

        //adds new product to inventory
        public static void addProduct(string name, decimal price, int inStock, int min, int max, BindingList<Part> associatedParts)
        {
            products.Add(new Product()
            {
                Name = name,
                Price = price,
                InStock = inStock,
                Min = min,
                Max = max,
                ProductID = productIDIndex,
                AssociatedParts = associatedParts
            });
            productIDIndex += 1;
        }

        //deletes selected product and returns true or does not delete product and returns false
        public bool removeProduct(int deletingRow)
        {
            if (MessageBox.Show("Are you sure you want to delete this product?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (products[deletingRow].AssociatedParts.Count != 0)
                {
                    MessageBox.Show("You cannot delete a Product with Parts associated to it.");
                    return false;
                }
                else
                {
                    products.RemoveAt(deletingRow);
                    return true;
                }             
            }
            else
            {
                return false;
            }
        }

        //finds products with names that contain the searched text and returns the product IDs
        public static List<int> lookupProduct(string name)
        {
            List<int> productIDs = new List<int>();
            for (int i = 0; i <= products.Count - 1; i++)
            {
                if (products[i].Name.Contains(name))
                {
                    productIDs.Add(products[i].ProductID);
                }
            }
            return productIDs;          
        }

        //updates existing product
        public static void updateProduct(string name, decimal price, int inStock, int min, int max, int productID, BindingList<Part> associatedParts)
        {
            List<Product> list = products.ToList();
            int index = list.FindIndex(products => products.ProductID.Equals(productID));
            products[index].Name = name;
            products[index].Price = price;
            products[index].InStock = inStock;
            products[index].Min = min;
            products[index].Max = max;
            products[index].AssociatedParts = associatedParts;
        }

    }
}
