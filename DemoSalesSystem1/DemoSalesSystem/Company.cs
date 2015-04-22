using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    

    public class Company : Contact
    {
        public string slogan;
        public string description;
        public string missionStatement;
        public List<CompanyContact> companyContacts = new List<CompanyContact>();

        public List<CompanyContact> CompanyContacts
        {
            get { return companyContacts; }
            set { companyContacts = value; }
        }


        public Company(short num, string word){
            base.Id = num;
            base.Name = word;
        }

        

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
       

        public string MissionStatement
        {
            get { return missionStatement; }
            set { missionStatement = value; }
        }
        

        public string Slogan
        {
            get { return slogan; }
            set { slogan = value; }
        }

        public List<CompanyContact> getCompanyContacts()
        {
       
            {
              return companyContacts;
            }
        }

        public void addCompanyContactToList(CompanyContact aCompanyContact)
        {
            companyContacts.Add(aCompanyContact);
        }
           
    }
}
