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
    public partial class Form1 : Form
    {
        //created so thta it can garuntee original primary keys
        int ContactKey = 0;
        public Form1()
        {
            InitializeComponent();
        }

//**********SAVE BUTTON
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Company aCompany = null;

                aCompany = new Company(0, nameTextBox.Text);
                aCompany.Id = ContactKey;
                ContactKey++;
                aCompany.Address = addrressTextBox.Text;
                aCompany.AltPhone = altPhoneTextBox.Text;
                aCompany.City = cityTextBox.Text;
                aCompany.CreationDate = DateTime.Now.ToString();
                aCompany.Fax = faxTextBox.Text;
                aCompany.emailAddress = emailTextBox.Text;
                aCompany.Phone = phoneTextBox.Text;
                aCompany.PostalCode = postalCodeTextBox.Text;
                aCompany.Province = provinceTextBox.Text;
                aCompany.Slogan = sloganTextBox.Text;
                aCompany.Name = nameTextBox.Text;
                aCompany.Notes = notesTextBox.Text;
                aCompany.MissionStatement = missionStateTextBox.Text;
                aCompany.Status = (Status)statusComboBox.SelectedIndex;
                CompanyMapper.InsertCompany(aCompany);
                displayCompaniesList(); //refresh listbox
                clearTextboxes(); //clear 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


//********DEFINE COMPANY FROM FORM
        public Company defineCompanyFromForm()
        {

            Company aCompany = null;
            aCompany = new Company(Convert.ToInt16(CompanyMapper.GetAllCompanys().Count), nameTextBox.Text);
            aCompany.Address = addrressTextBox.Text;
            aCompany.AltPhone = altPhoneTextBox.Text;
            aCompany.City = cityTextBox.Text;
            aCompany.CreationDate = creationDateTextBox.Text;
            aCompany.Fax = faxTextBox.Text;
            aCompany.EmailAddress = emailTextBox.Text;
            aCompany.Phone = phoneTextBox.Text;
            aCompany.PostalCode = postalCodeTextBox.Text;
            aCompany.Province = provinceTextBox.Text;
            aCompany.Slogan = sloganTextBox.Text;
            aCompany.Name = nameTextBox.Text;
            aCompany.Notes = notesTextBox.Text;
            aCompany.MissionStatement = missionStateTextBox.Text;
            aCompany.Status = (Status)statusComboBox.SelectedIndex;
            displayCompaniesList(); //refresh listbox
            return aCompany;

        }



//******** DISPLAY COMPANIES LIST
        public void displayCompaniesList()
        {
            try
            {
                listCompanies.Items.Clear();
                foreach (Company aCompany in CompanyMapper.GetAllCompanys())
                {
                    listCompanies.Items.Add(aCompany.Name);
                }//end for each
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


//**********DISPLAY COMPANY
        public void displayCompany(Company aCompany)
        {
            try
            {
                nameTextBox.Text = aCompany.Name;
                idTextBox.Text = aCompany.Id.ToString();
                altPhoneTextBox.Text = aCompany.AltPhone;
                addrressTextBox.Text = aCompany.Address;
                emailTextBox.Text = aCompany.emailAddress;
                cityTextBox.Text = aCompany.City;
                creationDateTextBox.Text = aCompany.CreationDate.ToString();
                faxTextBox.Text = aCompany.Fax;
                phoneTextBox.Text = aCompany.Phone;
                postalCodeTextBox.Text = aCompany.PostalCode;
                provinceTextBox.Text = aCompany.Province;
                sloganTextBox.Text = aCompany.Slogan;
                missionStateTextBox.Text = aCompany.MissionStatement;
                notesTextBox.Text = aCompany.Notes;
                statusComboBox.SelectedIndex = (int)aCompany.Status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

//*******CLEAR TEXT BOX
        public void clearTextboxes()
        {
            try
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr is TextBox) { ctr.Text = ""; }
                }//end for each
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


//********CLEAR BUTTON
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearTextboxes();
        }


//*********DELETE BUTTON
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Company company = new Company(Convert.ToInt16(idTextBox.Text), "");

                CompanyMapper.DeleteCompany(company);
                displayCompaniesList();
                clearTextboxes();
                refreshContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

 //*******UPDATE BUTTON
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Company aCompany = null;

                aCompany = new Company(0, nameTextBox.Text);
                aCompany.Id = CompanyMapper.GetAllCompanys()[listCompanies.SelectedIndex].Id;
                aCompany.Address = addrressTextBox.Text;
                aCompany.AltPhone = altPhoneTextBox.Text;
                aCompany.City = cityTextBox.Text;
                aCompany.CreationDate = DateTime.Now.ToString();
                aCompany.Fax = faxTextBox.Text;
                aCompany.emailAddress = emailTextBox.Text;
                aCompany.Phone = phoneTextBox.Text;
                aCompany.PostalCode = postalCodeTextBox.Text;
                aCompany.Province = provinceTextBox.Text;
                aCompany.Slogan = sloganTextBox.Text;
                aCompany.Name = nameTextBox.Text;
                aCompany.Notes = notesTextBox.Text;
                aCompany.MissionStatement = missionStateTextBox.Text;
                aCompany.Status = (Status)statusComboBox.SelectedIndex;
                CompanyMapper.UpdateCompany(aCompany);
                displayCompaniesList(); //refresh listbox
                clearTextboxes(); //clear 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


//*********LIST COMPANIES LIST BOX
        private void listCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                displayCompany(CompanyMapper.GetAllCompanys()[listCompanies.SelectedIndex]);
                refreshContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

//********ADD COMPANY CONTACT BUTTON
        private void addCompContactButton_Click(object sender, EventArgs e)
        {
            try
            {
                int companyId = CompanyMapper.GetAllCompanys()[listCompanies.SelectedIndex].Id;
                CompanyContact addContact = new CompanyContact();
                addContact.BranchId = ContactKey;
                ContactKey++;
                addContact.Extension = extensionTextBox.Text;
                addContact.FirstName = firstNameTextBox.Text;
                addContact.LastName = lastNameTextBox.Text;
                addContact.Salutation = (Salutation)salutationComboBox.SelectedIndex;
                addContact.CompanyId = companyId;

                CompanyContactMapper.InsertCompanyContact(addContact);

                clearTextboxes();
                refreshContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


//**********COMPANY CONTACT LIST BOX
        private void compContactListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int companyId = CompanyMapper.GetAllCompanys()[listCompanies.SelectedIndex].Id;


                CompanyContact showContact = CompanyContactMapper.GetAllCompanyContacts(companyId)[compContactListBox.SelectedIndex];

                branchIdTextBox.Text = showContact.BranchId.ToString();
                extensionTextBox.Text = showContact.Extension;
                firstNameTextBox.Text = showContact.FirstName;
                lastNameTextBox.Text = showContact.LastName;
                salutationComboBox.SelectedIndex = (int)showContact.Salutation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


//**********REFRESH CONTACTS
        private void refreshContacts()
        {
            //safe gaurd from getting an exception...because it kept showing a
            //negative symbol
            if (listCompanies.SelectedIndex >= 0)
            {
                try
                {
                    //for every company contact the company 
                    //has added to the list
                    //list it in listbox
                    compContactListBox.Items.Clear();
                    int companyId = CompanyMapper.GetAllCompanys()[listCompanies.SelectedIndex].Id;

                    foreach (CompanyContact contact in CompanyContactMapper.GetAllCompanyContacts(companyId))
                    {
                        compContactListBox.Items.Add(contact.FirstName + " " + contact.LastName);
                    }//end for each loop
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                compContactListBox.Items.Clear();
            }
        }


//**********DELETE CONTACT BUTTON
        private void delete_contact_button_Click(object sender, EventArgs e)
        {
            try
            {
                //
                int companyId = CompanyMapper.GetAllCompanys()[listCompanies.SelectedIndex].Id;
                CompanyContact contact = CompanyContactMapper.GetAllCompanyContacts(companyId)[compContactListBox.SelectedIndex];

                CompanyContactMapper.DeleteCompanyContact(contact);

                refreshContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
//*********UPDATE CONTACT BUTTON
        private void updateContactButton_Click(object sender, EventArgs e)
        {
            try
            {
                CompanyContact addContact = new CompanyContact();
                addContact.BranchId = Convert.ToInt16((branchIdTextBox.Text).ToString());
                addContact.Extension = extensionTextBox.Text;
                addContact.FirstName = firstNameTextBox.Text;
                addContact.LastName = lastNameTextBox.Text;
                addContact.Salutation = (Salutation)salutationComboBox.SelectedIndex;

                CompanyContactMapper.UpdateCompanyContact(addContact);

                clearTextboxes();
                refreshContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


//*******PRODUCT TOOL STRIP
        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm();
            prodForm.ShowDialog();
        }


//*******ORDER TOOL STRIP
        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm ordForm = new OrderForm(ProductMapper.GetAllProducts(), CompanyMapper.GetAllCompanys());
            ordForm.ShowDialog();
        }


//*********CATALOG TOOL STRIP
        private void catalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogForm catForm = new CatalogForm(ProductMapper.GetAllProducts());
            catForm.ShowDialog();
        }

    }
}
