namespace WarehouseLibrary
{
    public class Supplier
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public virtual List<Product>? Products { get; set; }

        public override string ToString()
        {
            return $"{FullName}";
        }
    }
}

