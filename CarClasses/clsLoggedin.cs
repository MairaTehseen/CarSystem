﻿using System;
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
            if (session != 0 )
            {
                staff = 0;
                session = 0;
            };

        }
    }

    

}



