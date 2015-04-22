using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DemoSalesSystem
{
    class CompanyMapper
    {
//*******INSERT COMPANY
        public static void InsertCompany(Company company)
        {
            List<SqlParameter> paras = GetCompanyParameters(company);
            DataAccess.ExecuteScalar("InsertCompany", paras);
        }

//********UPDATE COMPANY
        public static void UpdateCompany(Company company)
        {
            List<SqlParameter> paras = GetCompanyParameters(company);
           
            DataAccess.ExecuteNonquery("UpdateCompany", paras);
        }

//******DELETE COMPANY
        public static void DeleteCompany(Company company)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            SqlParameter id = new SqlParameter("@CompanyID", DbType.Int16);
            id.Value = company.Id;
            paras.Add(id);
            DataAccess.ExecuteNonquery("DeleteCompany", paras);
        }

//******GET ALL COMPANYS
        public static List<Company> GetAllCompanys()
        {
            List<Company> companys = new List<Company>();
            DataTable myDataTable = DataAccess.GetDataTable("SelectAllCompanies");

            foreach(DataRow row in myDataTable.Rows)
            {
                Company company = new Company(0, "");
                company.Id = Convert.ToInt16(row["company_Id"]);
                company.Name = row["name"].ToString();
                company.emailAddress = row["emailAddress"].ToString();
                company.City = row["city"].ToString();
                company.Address = row["address"].ToString();
                company.AltPhone = row["altPhone"].ToString();
                company.Notes = row["notes"].ToString();
                company.Province = row["province"].ToString();
                company.PostalCode = row["postalCode"].ToString();
                company.Slogan = row["slogan"].ToString();
                company.MissionStatement = row["missionStatement"].ToString();
                company.Status = (Status)Convert.ToInt16(row["status"]);
                company.Phone = row["phone"].ToString();
                company.Fax = row["fax"].ToString();
                company.CreationDate = row["creationDate"].ToString();

                companys.Add(company);
            }
            return companys;
        }

//********GETTING COMPANY PARAMETRS
        private static List<SqlParameter> GetCompanyParameters(Company company)
        {
            List<SqlParameter> dbParameters = new List<SqlParameter>();
            SqlParameter name = new SqlParameter("@Name", SqlDbType.VarChar);
            SqlParameter city = new SqlParameter("@City", SqlDbType.VarChar);
            SqlParameter address = new SqlParameter("@Address", SqlDbType.VarChar);
            SqlParameter alternatePhone = new SqlParameter("@AlternatePhone", SqlDbType.VarChar);
            SqlParameter email = new SqlParameter("@Email", SqlDbType.VarChar);
            SqlParameter notes = new SqlParameter("@Notes", SqlDbType.VarChar);
            SqlParameter province = new SqlParameter("@Province", SqlDbType.VarChar);
            SqlParameter postalCode = new SqlParameter("@PostalCode", SqlDbType.VarChar);
            SqlParameter slogan = new SqlParameter("@Slogan", SqlDbType.VarChar);
            SqlParameter missionStatement = new SqlParameter("@MissionStatement", SqlDbType.VarChar);
            SqlParameter status = new SqlParameter("@Status", SqlDbType.VarChar);
            SqlParameter phone = new SqlParameter("@Phone", SqlDbType.VarChar);
            SqlParameter fax = new SqlParameter("@Fax", SqlDbType.VarChar);
            SqlParameter creationDate = new SqlParameter("@CreationDate", SqlDbType.VarChar);
            SqlParameter id = new SqlParameter("@CompanyId", SqlDbType.Int);

            id.Value = company.Id;
            name.Value = company.Name;
            city.Value = company.City;
            address.Value = company.Address;
            alternatePhone.Value = company.AltPhone;
            email.Value = company.emailAddress;
            notes.Value = company.Notes;
            province.Value = company.Province;
            postalCode.Value = company.PostalCode;
            slogan.Value = company.Slogan;
            missionStatement.Value = company.MissionStatement;
                //casting to int before a string because
                //its a numerated type
            status.Value = ((int)company.Status).ToString();
            phone.Value = company.Phone;
            fax.Value = company.Fax;
            creationDate.Value = company.CreationDate;

            dbParameters.Add(name);
            dbParameters.Add(city);
            dbParameters.Add(address);
            dbParameters.Add(alternatePhone);
            dbParameters.Add(notes);
            dbParameters.Add(province);
            dbParameters.Add(postalCode);
            dbParameters.Add(slogan);
            dbParameters.Add(missionStatement);
            dbParameters.Add(status);
            dbParameters.Add(phone);
            dbParameters.Add(fax);
            dbParameters.Add(creationDate);
            dbParameters.Add(id);
            dbParameters.Add(email);

            return dbParameters;
        }

    }
}
