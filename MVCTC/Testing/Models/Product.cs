using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models;

namespace Testing.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }
        public int CategoryID { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string orderby{get; set;}
    }
}
