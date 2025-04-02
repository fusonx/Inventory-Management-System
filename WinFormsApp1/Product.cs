using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Product
    {

        private static int nextID = 0;

        public int ProductID { get; private set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }

        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

        public Product(string name, int inStock, decimal price, int max, int min)
        {
            ProductID = GenerateId();
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
        }

        private static int GenerateId()
        {
            return nextID++;
        }

   

        public void addAssociatedPart(Part part)
        {
            if (!AssociatedParts.Contains(part))
            {
                AssociatedParts.Add(part);
            }
        }
        public bool removeAssociatedPart(int partID)
        {
            var part = lookupAssociatedPart(partID);
            if (part != null)
            {
                return AssociatedParts.Remove(part);
            }
            return false;
        }

        public Part lookupAssociatedPart(int partID)
        {
            return AssociatedParts.FirstOrDefault(p => p.PartID == partID);
        }
    }
}
