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
    }
}