using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarClasses
{
    public class clsCounty
    {
        public string County { get; set; }

        public int CountyNo { get; set; }

        public string Valid(string someCounty)
        {
            //string variable to store the error message
            string Error = "";
            //if the name of the county is more than 50 characters
            if (someCounty.Length > 50)
            {
                //return an error message
                Error = "The county name cannot have more than 50 characters";
            }
            if (someCounty.Length == 0)
            {
                //return an error message
                Error = "The county name may not be blank!";
            }
            return Error;
        }
    }
}
