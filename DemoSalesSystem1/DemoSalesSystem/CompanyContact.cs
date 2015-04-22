using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public class CompanyContact : Contact
    {

        private int branchId;

        public int BranchId
        {
            get { return branchId; }
            set { branchId = value; }
        }
        
        public string extension;

        public string Extension
        {
            get { return extension; }
            set { extension = value; }
        }


        public string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }


        public string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public Salutation salutation;

        public Salutation Salutation
        {
            get { return salutation; }
            set { salutation = value; }
        }


        private int companyId;

        public int CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }
        
    }
}
