using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClasses
{
    public class Payment
    {
        public void AddPayment( int PaymentMethod, int OrderId)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerId", clsLoggedin.session);
            DB.AddParameter("@PaymentMethod", PaymentMethod);
            DB.AddParameter("@PaymentDate", DateTime.Now);
            DB.AddParameter("@OrderId", OrderId);
            
            DB.Execute("PaymentAdd");

        }
    }
}

