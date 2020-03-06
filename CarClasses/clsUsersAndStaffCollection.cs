using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClasses
{
    public class  clsUsersAndStaffCollection
    {

        public static void AddUser(string first,string last, string country, string city, string street, string house, string post, string user, string pass, string email)
        {
            //update an existing record based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FirstName", first);
            DB.AddParameter("@LastName", last);
            DB.AddParameter("@Country", country);
            DB.AddParameter("@City", city);
            DB.AddParameter("@Street", street);
            DB.AddParameter("@HouseNumber", house);
            DB.AddParameter("@PostCode", post);
            DB.AddParameter("@UserName", user);
            DB.AddParameter("@Password", pass);
            DB.AddParameter("@Email", email);
           
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_Update");
        }

        public static void AddStaff(string first, string last, string country, string city, string street, string house, string post, string user, string pass, string email)
        {
            //update an existing record based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FirstName", first);
            DB.AddParameter("@LastName", last);
            DB.AddParameter("@Country", country);
            DB.AddParameter("@City", city);
            DB.AddParameter("@Street", street);
            DB.AddParameter("@HouseNumber", house);
            DB.AddParameter("@PostCode", post);
            DB.AddParameter("@UserName", user);
            DB.AddParameter("@Password", pass);
            DB.AddParameter("@Email", email);

            //execute the stored procedure
            DB.Execute("sproc_tblAddress_Update");
        }

    }
}
