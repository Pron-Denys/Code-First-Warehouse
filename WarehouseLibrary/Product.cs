using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual ProductType? Type { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public string? Delivery_date { get; set; }

        public override string ToString()
        {
            return $"Назва: {Name} Тип товару: {Type?.Name} Постачальник: {Supplier?.FullName} " +
                $"Кількість товару: {Quantity} Ціна: {Price} Дата поставки: {Delivery_date}";
        }
    }
}