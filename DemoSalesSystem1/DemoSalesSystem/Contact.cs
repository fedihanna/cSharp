using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public abstract class Contact
    {

        public int id;
        public string name;
        public string address;
        public string city;
        public string province;
        public string postalCode;
        public string phone;
        public string altPhone;
        public string fax;
        public DateTime dateEntered;
        public string emailAddress;
        public Status status;
        public int type;
        public string creationDate;
        public string notes;


        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

      
    
        #region getters and setters

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
      

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public string City
        {
            get { return city; }
            set { city = value; }
        }


        public string Province
        {
            get { return province; }
            set { province = value; }
        }


        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }


        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
       
      
         public string AltPhone
         {
             get { return altPhone; }
             set { altPhone = value; }
         }


         public string Fax
         {
             get { return fax; }
             set { fax = value; }
         }

         public DateTime DateEntered
         {
             get { return dateEntered; }
             set { dateEntered = value; }
         }


         public string CreationDate
         {
             get { return creationDate; }
             set { creationDate = value; }
         }

        

         public string EmailAddress
         {
             get { return emailAddress; }
             set { emailAddress = value; }
         }
         
         public Status Status
         {
             get { return status; }
             set { status = value; }
         }


         public int Type
         {
             get { return type; }
             set { type = value; }
         }
#endregion

    }
}
