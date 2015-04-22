using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DemoSalesSystem
{
   public class CompanyContactMapper
    {
        //*******INSERT COMPANY
        public static void InsertCompanyContact(CompanyContact contact)
        {
            List<SqlParameter> paras = GetCompanyContactParameters(contact);
            DataAccess.ExecuteScalar("InsertCompanyContact", paras);
        }

        //********UPDATE COMPANY
        public static void UpdateCompanyContact(CompanyContact contact)
        {
            List<SqlParameter> paras = GetCompanyContactParameters(contact);

            DataAccess.ExecuteNonquery("UpdateCompanyContacts", paras);
        }

        //******DELETE COMPANY
        public static void DeleteCompanyContact(CompanyContact contact)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            SqlParameter id = new SqlParameter("@BranchID", DbType.Int16);
            id.Value = contact.BranchId;
            paras.Add(id);
            DataAccess.ExecuteNonquery("DeleteCompanyContact", paras);
        }

        //******GET ALL COMPANYS
        public static List<CompanyContact> GetAllCompanyContacts(int companyId)
        {
            List<CompanyContact> contacts = new List<CompanyContact>();
            DataTable myDataTable = DataAccess.GetDataTable("SelectAllCompanyContacts");

            foreach (DataRow row in myDataTable.Rows)
            {
                CompanyContact contact = new CompanyContact();

                contact.BranchId = Convert.ToInt16(row["branch_id"]);
                contact.Extension = row["extension"].ToString();
                contact.FirstName = row["firstName"].ToString();
                contact.LastName = row["lastName"].ToString();            
                contact.Salutation = (Salutation)Convert.ToInt16(row["salutation"]);
                contact.CompanyId = Convert.ToInt16(row["companyId"]);

                if (contact.CompanyId == companyId)
                {
                    contacts.Add(contact);
                }
            }
            return contacts;
        }



        //******GET ALL COMPANY 
        public static List<CompanyContact> GetAllCompanyContact()
        {
            List<CompanyContact> contacts = new List<CompanyContact>();
            DataTable myDataTable = DataAccess.GetDataTable("SelectAllCompanyContacts");

            foreach (DataRow row in myDataTable.Rows)
            {
                CompanyContact contact = new CompanyContact();

                contact.BranchId = Convert.ToInt16(row["branch_id"]);
                contact.Extension = row["extension"].ToString();
                contact.FirstName = row["firstName"].ToString();
                contact.LastName = row["lastName"].ToString();
                contact.Salutation = (Salutation)Convert.ToInt16(row["salutation"]);
                contact.CompanyId = Convert.ToInt16(row["companyId"]);
                contacts.Add(contact);
            }
            return contacts;
        }


        //********GETTING COMPANY PARAMETRS
        private static List<SqlParameter> GetCompanyContactParameters(CompanyContact contact)
        {
            List<SqlParameter> dbParameters = new List<SqlParameter>();
            SqlParameter branch_id = new SqlParameter("@BranchId", SqlDbType.VarChar);
            SqlParameter extension = new SqlParameter("@Extension", SqlDbType.VarChar);
            SqlParameter firstName = new SqlParameter("@FirstName", SqlDbType.VarChar);
            SqlParameter lastName = new SqlParameter("@LastName", SqlDbType.VarChar);
            SqlParameter salutation = new SqlParameter("@Salutation", SqlDbType.VarChar);
            SqlParameter companyId = new SqlParameter("@CompanyId", SqlDbType.Int);

            branch_id.Value = contact.BranchId;
            extension.Value = contact.Extension;
            firstName.Value = contact.FirstName;
            lastName.Value = contact.LastName;
            salutation.Value = ((int)contact.Salutation).ToString();
            companyId.Value = contact.CompanyId;

            dbParameters.Add(branch_id);
            dbParameters.Add(extension);
            dbParameters.Add(firstName);
            dbParameters.Add(lastName);
            dbParameters.Add(salutation);
            dbParameters.Add(companyId);


            return dbParameters;
        }

    }
}
