using System;

namespace CarClasses
{
    public class clsPayment
    {
        public bool Active { get; set; }
        public DateTime PaymentDate { get; set; }
        public int CountyNo { get; set; }
        public string Payment_Customer_Id { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentId { get; set; }
        public int AddressNo { get; set; }
        public string PaymentOrderId { get; set; }

        public bool Find(int addressNo)
        {
            throw new NotImplementedException();
        }

        public string Valid(string payment_Customer_Id, string paymentId, string paymentOrderId, string paymentMethod, string paymentDate)
        {
            throw new NotImplementedException();
        }
    }
}