using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Inventory
    {
        public BindingList<Part> AllParts { get; } = new BindingList<Part>();
        public BindingList<Product> Products { get; } = new BindingList<Product>();
        public Dictionary<int, List<int>> productToPartsMap = new Dictionary<int, List<int>>();


        public Inventory() 
        {
            AllParts.Add(new Inhouse("Wheel", 15, 12.11M, 5, 25, 15));
            AllParts.Add(new Inhouse("Pedal", 11, 8.22M, 5, 25, 23));
            AllParts.Add(new Outsourced("Chain", 12, 8.33M, 5, 25, "Joe Schmoes"));
            AllParts.Add(new Outsourced("Seat", 8, 4.55M, 2, 15, "Joe Schmoes"));

            Products.Add(new Product("Red Bicycle", 15, 11.44M, 25, 1));
            Products.Add(new Product("Yellow Bicycle", 19, 9.66M, 20, 3));
            Products.Add(new Product("Blue Bicycle", 5, 12.77M, 25, 2));
        }

        public void addProduct(Product product)
        {
            Products.Add(product);
        }

        public bool removeProduct(int productID)
        {
            var product = lookupProduct(productID);
            if (product != null)
            {
                return Products.Remove(product);
            }
            return false;
        }

        public Product lookupProduct(int productID)
        {
            return Products.FirstOrDefault(p => p.ProductID == productID);
        }

        public BindingList<Product> searchProductsByName(string name)
        {
            var result = new BindingList<Product>(Products.Where(product => product.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList());
            return result;
        }

        public void updateProduct(int productId, Product updatedProduct)
        {
            var productIndex = Products.IndexOf(lookupProduct(productId));
            if (productIndex >= 0)
            {
                Products[productIndex] = updatedProduct;
            }
        }

        public void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public bool deletePart(Part part)
        {
            return AllParts.Remove(part);
        }

        public Part lookupPart(int partID)
        {
            return AllParts.FirstOrDefault(p => p.PartID == partID);
        }

        public BindingList<Part> searchPartsByName(string name)
        {
            var result = new BindingList<Part>(AllParts.Where(part => part.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList());
            return result;
        }

        public void updatePart(int partID, Part newPart)
        {
            var partIndex = AllParts.IndexOf(lookupPart(partID));
            if (partIndex >= 0)
            {
                AllParts[partIndex] = newPart;
            }
        }

        public bool IsPartAssociated(int partID)
        {
            foreach (var product in Products)
            {
                if (product.AssociatedParts.Any(part => part.PartID == partID))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
