using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Aki_Tanaka_C968
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
       
        //adds part to associatedParts
        public static void addAssociatedPart(int partID, string name, int inventory, decimal price, int min, int max, BindingList<Part> tempAssociatedParts)
        {
            tempAssociatedParts.Add(new Inhouse()
            {
                PartID = partID,
                Name = name,
                InStock = inventory,
                Price = price,
                Min = min,
                Max = max
            });
        }

        //removes part from associatedParts
        public bool removeAssociatedPart(int deletingRow, BindingList<Part> tempAssociatedParts)
        {
            if (MessageBox.Show("Are you sure you want to delete this part?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tempAssociatedParts.RemoveAt(deletingRow);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        //finds parts with names that contain the searched text and returns the part IDs
        public static List<int> lookupAssociatedPart(string name)
        {
            List<int> partIDs = new List<int>();
            for (int i = 0; i <= Inventory.allParts.Count - 1; i++)
            {
                if (Inventory.allParts[i].Name.Contains(name))
                {
                    partIDs.Add(Inventory.allParts[i].PartID);
                }
            }
            return partIDs;
        }
    } 
}

