using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClasses
{
    public class clsLoggedin
    {
        public static int session { get; set; }
        public static int staff { get; set; }

        public static void clsLogout()
        {
            if (session != 0)
            {
                staff = 0;
                session = 0;
            };

        }

        public static int login(string login,string password)
            {
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@UserName", login);
            DB.AddParameter("@Password", password);
            
            int iss = DB.Execute("checkuser") ;
            if (iss == -1)
            {
                
                staff = 0;
                session = 0;
            }
            if (iss == 1)
            {
                clsDataConnection DBS = new clsDataConnection();
                DBS.AddParameter("@userstaff", 1);
                DBS.AddParameter("@UserName2", login);
                DBS.AddParameter("@Password2", password);
                int iss2 = DBS.Execute("checkuser2");
                staff = 0;
                session = iss2;
                return iss2;
                
            }
            if (iss == 2)
            {
                clsDataConnection DBS = new clsDataConnection();
                DBS.AddParameter("@userstaff", 2);
                DBS.AddParameter("@UserName2", login);
                DBS.AddParameter("@Password2", password);
                int iss3 = DBS.Execute("checkuser2");
                staff = 1;
                session = iss3;
                return iss3;
            }
            return iss;
        }


       


    }

    

}



