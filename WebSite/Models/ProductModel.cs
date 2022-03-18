using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public String CategoryName { get; set; }
        public String Name { get; set; }
        public int Barcode { get; set; }
        public string Description { get; set; }
    }
}
