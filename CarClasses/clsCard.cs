using System;

namespace CarClasses
{
    public class clsCard
    {
        public bool Active { get; set; }
        public Double CardNr { get; set; }
        public string CardHolder { get; set; }
        public int CardSecurityNumber { get; set; }
        public int ExpireDateYear { get; set; }
        public int ExpireDateMonth { get; set; }

        public string Valid(string text1, string text2, string text3, string text4, string text5)
        {
            throw new NotImplementedException();
        }

        public void Find(double primaryKey)
        {
            throw new NotImplementedException();
        }
    }
}