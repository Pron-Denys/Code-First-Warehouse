using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary
{
    public class ProductType
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual List<Product>? Products { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
