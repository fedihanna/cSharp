using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DemoSalesSystem
{
    public class ProductMapper
    {
        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            DataTable myDataTable = DataAccess.GetDataTable("GetAllProducts");

            foreach (DataRow row in myDataTable.Rows)
            {
                Product product = new Product();
                product.ProductID = Convert.ToInt16(row["Id"]);
                product.Name = row["Name"].ToString();

                products.Add(product);
            }

            return products;
        }
    }
}
