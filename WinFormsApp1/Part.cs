using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Part
    {
        private static int nextID = 0;

        public int PartID { get; private set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        protected Part(string name, int inStock, decimal price, int min, int max)
        {
            PartID = GenerateId();
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        protected Part(int partID, string name, int inStock, decimal price, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        private static int GenerateId()
        {
            return nextID++;
        }
    }

    public class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse(string name, int inStock, decimal price, int min, int max, int machineID)
            : base(name, inStock, price, min, max)
        {
            MachineID = machineID;
        }

        public Inhouse(Part part, int machineID)
            : base(part.PartID, part.Name, part.InStock, part.Price, part.Min, part.Max)
        {
            MachineID = machineID;
        }
    }

    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(string name, int inStock, decimal price, int min, int max, string companyName)
            : base(name, inStock, price, min, max)
        {
            CompanyName = companyName;
        }

        public Outsourced(Part part, string companyName)
            : base(part.PartID, part.Name, part.InStock, part.Price, part.Min, part.Max)
        {
            CompanyName = companyName;
        }
    }
}
