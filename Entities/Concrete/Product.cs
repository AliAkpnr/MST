using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public String Name { get; set; }
        //public int UnitsInStok{ get; set; }
        public int Barcode { get; set; }
        public string Description { get; set; }
        
        //public int UnitPrice { get; set; }
        //public int UnirsInStok { get; set; }
    }
}
