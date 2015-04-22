using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public class Product
    {
        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int productID;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
    }
}
