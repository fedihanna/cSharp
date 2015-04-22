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
    public partial class ProductForm : Form
    {
        //passing the list of products in the main form
        public ProductForm()
        {
            InitializeComponent();
            displayProductList();
        }


//*******DISPLAY PRODUCTS LIST
        public void displayProductList()
        {
            try
            {
                pformListBox.Items.Clear();
                foreach (Product aProduct in ProductMapper.GetAllProducts())
                {
                    pformListBox.Items.Add(aProduct.Name);
                }//end for each
            }
            catch (Exception)
            {
                
            }

        }

        public void pformListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductIDTextbox.Text = ProductMapper.GetAllProducts()[pformListBox.SelectedIndex].ProductID.ToString();
            ProductNameTextbox.Text = ProductMapper.GetAllProducts()[pformListBox.SelectedIndex].Name;
        }
    }
}
