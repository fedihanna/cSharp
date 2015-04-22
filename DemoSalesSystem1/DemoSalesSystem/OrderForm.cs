using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSalesSystem
{

    public partial class OrderForm : Form
    {
      public List<Order> orders = null;
      public List<Product> products = null;
        public Order currentOrders;
        public List<Company> companies = null;
        public int pKey = 0; //keeps primary key original because I did not make primary keys auto incrementing

        //passing the list of products in the main form
        public OrderForm(List<Product> inProducts, List<Company> inCompanies)
        {
            //passing a list of products to the subforms
            products = inProducts;
            InitializeComponent();
            orders = new List<Order>();
            companies = inCompanies;
            resetCompanyComboBox();
            resetComboProductBox();
        }

//*****PRODUCT LIST BOX ADD BUTTON
        public void oformAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Order order = new Order();
             
                //order.CompanyId = OrderMapper.GetAllOrders()[OrdersListBox.SelectedIndex].OrderId;
                
                //OrderMapper.DeleteOrder(order);

                resetProductsList();
            }
            catch (Exception)
            {

            }
        }


//*******PRODUCT LIST BOX DELETE BUTTON
        public void oformDeleteButton_Click(object sender, EventArgs e)
        {
            orders[OrdersListBox.SelectedIndex].products.RemoveAt(oformProductsListBox.SelectedIndex);
            resetProductsList();
        }


        public void resetProductsList()
        {
            oformProductsListBox.Items.Clear();
            for (int i = 0; i < orders[OrdersListBox.SelectedIndex].products.Count; i++)
            {
                oformProductsListBox.Items.Add(orders[OrdersListBox.SelectedIndex].products[i].name);
            }
        }

        public void resetOrdersList()
        {
            OrdersListBox.Items.Clear();
            int counter = 1;
            foreach(Order order in OrderMapper.GetAllOrders())
            {
                OrdersListBox.Items.Add(counter.ToString() + ":" + order.CompanyContact);
                counter++;
            }
        }


//*********ADD ORDER BUTTON
        public void AddOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = new Order();
                order.OrderId = pKey;
                pKey++;
                order.orderDate = ordFormDateTimePicker.Value;
                order.OrderStatus = orderStatusTextBox.Text;
                order.CompanyId = CompanyMapper.GetAllCompanys()[orFormContactComboBox.SelectedIndex].id;
                order.CompanyContact = orFormContactComboBox.Text;

                OrderMapper.InsertOrder(order);
                resetOrdersList();
            }
            catch (Exception)
            {
                
                
            }
        }

//********UPDATE ORDER BUTTON
        public void UpdateOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = new Order();
                order.OrderId = OrderMapper.GetAllOrders()[OrdersListBox.SelectedIndex].OrderId;
                order.orderDate = ordFormDateTimePicker.Value;
                order.OrderStatus = orderStatusTextBox.Text;
                order.CompanyId = CompanyMapper.GetAllCompanys()[orFormContactComboBox.SelectedIndex].id;
                order.CompanyContact = orFormContactComboBox.Text;
                OrderMapper.UpdateOrder(order);
                resetOrdersList();
            }
            catch (Exception)
            {
                
               
            }
        }

        public void resetComboProductBox()
        {
            for (int i = 0; i < products.Count(); i++)
            {
                //going through all the productss and putting them in the listbox
                orderProductComboBox.Items.Add(products[i].name);
            }
            //submits a value so you cant add anything
            //0 is the boots
            orderProductComboBox.SelectedIndex = 0;
        }

    
//*******DELETE ORDER BUTTON
        public void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.OrderId = OrderMapper.GetAllOrders()[OrdersListBox.SelectedIndex].OrderId;

            OrderMapper.DeleteOrder(order);
            resetOrdersList();
        }

//******REST COMPANY COMBO BOX
        public void resetCompanyComboBox()
        {
            for (int i = 0; i < companies.Count; i++)
            {
                ordFormCompComboBox.Items.Add(companies[i].name);
            }

        }

//********ORDER FORM COMPANY COMBO BOX
        private void ordFormCompComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            orFormContactComboBox.Items.Clear();
            //every company caontac belonging to the selected company 
            //in the drop down add to the Contacts drop down
            for (int i = 0; i < CompanyContactMapper.GetAllCompanyContacts(CompanyMapper.GetAllCompanys()[ordFormCompComboBox.SelectedIndex].Id).Count(); i++) 
            {
                orFormContactComboBox.Items.Add(CompanyContactMapper.GetAllCompanyContacts(CompanyMapper.GetAllCompanys()[ordFormCompComboBox.SelectedIndex].Id)[i].firstName);
            }
           // orFormContactComboBox.SelectedIndex = 0;
        }

//******ORDER LIST BOX
        private void OrdersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetProductsList();
        }   
    }
}
