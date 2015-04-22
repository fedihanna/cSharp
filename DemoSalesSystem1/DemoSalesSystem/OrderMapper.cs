using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DemoSalesSystem
{
    class OrderMapper
    {
        //*******INSERT COMPANY
        public static void InsertOrder(Order order)
        {
            List<SqlParameter> paras = GetOrderParameters(order);
            DataAccess.ExecuteScalar("InsertOrder", paras);
        }

        //********UPDATE COMPANY
        public static void UpdateOrder(Order order)
        {
            List<SqlParameter> paras = GetOrderParameters(order);

            DataAccess.ExecuteNonquery("UpdateOrders", paras);
        }

        //******DELETE COMPANY
        public static void DeleteOrder(Order order)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            SqlParameter id = new SqlParameter("@OrderID", DbType.Int16);
            id.Value = order.OrderId;
            paras.Add(id);
            DataAccess.ExecuteNonquery("DeleteOrder", paras);
        }

        //******GET ALL
        public static List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            DataTable myDataTable = DataAccess.GetDataTable("SelectAllOrders");

            foreach (DataRow row in myDataTable.Rows)
            {
                Order order = new Order();
                order.OrderId = Convert.ToInt16(row["Order_Id"]);
                order.CompanyId = Convert.ToInt16(row["company_id"]);
                order.CompanyContact = row["companyContact"].ToString();
                order.OrderDate = (DateTime)row["orderDate"];
                order.OrderStatus = row["orderStatus"].ToString();


                //if (order.CompanyId == companyId)
                //{
                   orders.Add(order);
                //}
            }
            return orders;
        }

        //********GETTING PARAMETRS
        private static List<SqlParameter> GetOrderParameters(Order order)
        {
            List<SqlParameter> dbParameters = new List<SqlParameter>();
            SqlParameter orderId = new SqlParameter("@OrderId", SqlDbType.Int);
            SqlParameter companyId = new SqlParameter("@CompanyId", SqlDbType.Int);
            SqlParameter companyContact = new SqlParameter("@CompanyContact", SqlDbType.VarChar);
            SqlParameter orderDate = new SqlParameter("@OrderDate", SqlDbType.Date);
            SqlParameter orderStatus = new SqlParameter("@OrderStatus", SqlDbType.VarChar);
          

            orderId.Value = order.OrderId;
            companyId.Value = order.CompanyId;
            companyContact.Value = order.CompanyContact;
            orderDate.Value = order.OrderDate;
            orderStatus.Value = order.OrderStatus; ;
            
            dbParameters.Add(orderId);
            dbParameters.Add(companyId);
            dbParameters.Add(companyContact);
            dbParameters.Add(orderDate);
            dbParameters.Add(orderStatus);
           


            return dbParameters;
        }

    }
}
