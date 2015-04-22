using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public class Catalog
    {
        public string description;
        public DateTime endDate;
        public int id;
        public string name;
        public List<Product> products;
        public DateTime startDate;
        public string note;

        public Catalog()
        {
            products = new List<Product>();
        }
    }
}
