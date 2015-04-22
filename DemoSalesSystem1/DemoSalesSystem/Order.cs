using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public class Order
    {
        #region class level variables
        private int orderId;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        private int companyId;

        public int CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }


        public DateTime orderDate;
        public Company company;
        public List<Product> products = new List<Product>();


        private string orderStatus;

        public string OrderStatus
        {
            get { return orderStatus; }
            set { orderStatus = value; }
        }
       

       


        private string note;

        public string Note1
        {
            get { return note; }
            set { note = value; }
        }
        #endregion
        #region getters and setters;




        public Company Company
        {
            get { return company; }
            set { company = value; }
        }


        private string companyContact;

       public string CompanyContact
        {
            get { return companyContact; }
            set { companyContact = value; }
        }




        public string Note
        {
            get { return note; }
            set { note = value; }
        }




        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        #endregion
    }
}

