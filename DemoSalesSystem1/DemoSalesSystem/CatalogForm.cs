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
    public partial class CatalogForm : Form
    {
        private List<Product> products = null;
        private List<Catalog> catalogs = null;

        //passing the list of products in the main form
        public CatalogForm(List<Product> inProducts)
        {
            //passing a list of products to the subforms
            products = inProducts;
            InitializeComponent();
            resetComboProductBox();
            catalogs = new List<Catalog>();
        }

        private void catFormAddButton_Click(object sender, EventArgs e)
        {

            Catalog newcatalog = new Catalog();
            newcatalog.id = Convert.ToInt16(catFormIDtextBox.Text);
            newcatalog.name = catFormNameTextBox.Text;
            newcatalog.startDate = catFormdateTimePicker.Value;
            newcatalog.endDate = catFormEnddateTimePicker.Value;
            newcatalog.description = catFormDescripTextBox.Text;
            newcatalog.note = catFormNoteTextBox.Text;
            catalogs.Add(newcatalog);

        // catListBox;
            resetCatalogs();
        }

        public void resetCatalogs()
        {
            catformCatalogsListBox.Items.Clear();
            for(int i=0; i < catalogs.Count(); i++)
            {
                //going through all the catalogs and putting them in the listbox
                catformCatalogsListBox.Items.Add(catalogs[i].name);
            }
            
        }

        private void catFormUpdateButton_Click(object sender, EventArgs e)
        {

            Catalog newcatalog = new Catalog();
            newcatalog.id = Convert.ToInt16(catFormIDtextBox.Text);
            newcatalog.name = catFormNameTextBox.Text;
            newcatalog.startDate = catFormdateTimePicker.Value;
            newcatalog.endDate = catFormEnddateTimePicker.Value;
            newcatalog.description = catFormDescripTextBox.Text;
            newcatalog.note = catFormNoteTextBox.Text;
            catalogs[catformCatalogsListBox.SelectedIndex] = (newcatalog);

            // catListBox;
            resetCatalogs();
        }

        private void catFormDeleteButton_Click(object sender, EventArgs e)
        {
            //removes from the listbox
            //resets the catalogs
            catalogs.RemoveAt(catformCatalogsListBox.SelectedIndex);
            resetCatalogs();
        }

        public void resetComboProductBox()
        {
             for(int i=0; i < products.Count(); i++)
            {
                //going through all the productss and putting them in the listbox
                catProductsComboBox.Items.Add(products[i].name);
            }
            //submits a value so you cant add anything
            //0 is the boots
             catProductsComboBox.SelectedIndex = 0;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            //products in combox get added to current catalog
            Product newProduct = products[catProductsComboBox.SelectedIndex];
            catalogs[catformCatalogsListBox.SelectedIndex].products.Add(newProduct);
            resetProuctsListBox();
        }

        public void resetProuctsListBox()
        {
            catProductListBox.Items.Clear();
            for (int i = 0; i < catalogs[catformCatalogsListBox.SelectedIndex].products.Count(); i++)
            {
                //going through all the products and putting them in the listbox
                catProductListBox.Items.Add(catalogs[catformCatalogsListBox.SelectedIndex].products[i].name);
            }
        }

        private void catformCatalogsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetProuctsListBox();
        }
    }
}
