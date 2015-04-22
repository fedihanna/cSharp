using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DemoSalesSystem
{
    class OrderDetailsMapper
    {
        //*******INSERT details
        public static void InsertOrderDetails(OrderDetails details)
        {
            List<SqlParameter> paras = GetOrderDetailsParameters(details);
            DataAccess.ExecuteScalar("InsertOrderProduct", paras);
        }

        //********UPDATE details
        public static void UpdateOrderDetails(OrderDetails details)
        {
            List<SqlParameter> paras = GetOrderDetailsParameters(details);

            DataAccess.ExecuteNonquery("UpdateOrderProduct", paras);
        }

        //******DELETE details
        public static void DeleteCompanyContact(OrderDetails details)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            SqlParameter id = new SqlParameter("@OrderProductId", DbType.Int16);
            id.Value = details.orderProductId;
            paras.Add(id);
            DataAccess.ExecuteNonquery("DeleteOrderProduct", paras);
        }

        //******GET ALL details
        public static List<OrderDetails> GetAllOrderDetails(int orderId)
        {
            List<OrderDetails> detailsArray = new List<OrderDetails>();
            DataTable myDataTable = DataAccess.GetDataTable("SelectAllOrderProducts");

            foreach (DataRow row in myDataTable.Rows)
            {
                OrderDetails details = new OrderDetails();

                details.orderProductId = Convert.ToInt16(row["orderProductId"]);
                details.orderId = Convert.ToInt16(row["orderId"]);
                details.productId = Convert.ToInt16(row["productId"]);
                details.quantity = Convert.ToInt16(row["qauntity"]);
                

                if (details.orderId == orderId)
                {
                    detailsArray.Add(details);
                }
            }
            return detailsArray;
        }

        //********GETTING details Parameters
        private static List<SqlParameter> GetOrderDetailsParameters(OrderDetails details)
        {
            List<SqlParameter> dbParameters = new List<SqlParameter>();
            SqlParameter orderProductId = new SqlParameter("@OrderProductId", SqlDbType.Int);
            SqlParameter orderId = new SqlParameter("@OrderId", SqlDbType.Int);
            SqlParameter productId = new SqlParameter("@ProductId", SqlDbType.Int);
            SqlParameter qauntity = new SqlParameter("@Qauntity", SqlDbType.Int);
           

            orderProductId.Value = details.orderProductId;
            orderId.Value = details.orderId;
            productId.Value = details.productId;
            qauntity.Value = details.quantity;


            dbParameters.Add(orderProductId);
            dbParameters.Add(orderId);
            dbParameters.Add(productId);
            dbParameters.Add(qauntity);
        


            return dbParameters;
        }

    }
}
