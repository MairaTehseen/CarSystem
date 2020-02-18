using System;

namespace CarClasses
{
    public class clsStock
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int StockNo { get; set; }
        public int CarNo { get; set; }
        public string Manufacturer { get; set; }
        public string Make { get; set; }
        public string Colour { get; set; }
        public int Price { get; set; }
    }
}