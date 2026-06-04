namespace WarehouseContext
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.EntityFrameworkCore.SqlServer;
    using Microsoft.EntityFrameworkCore.Proxies;
    using Microsoft.EntityFrameworkCore;
    using WarehouseLibrary;
    public class WarehouseContext : DbContext
    {
        static DbContextOptions<WarehouseContext> _options;
        static WarehouseContext()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string? connectionString = config.GetConnectionString("DefaultConnection");
            var optionsBuilder = new DbContextOptionsBuilder<WarehouseContext>();
            _options = optionsBuilder.UseSqlServer(connectionString).Options;
        }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }

        public WarehouseContext()
            : base(_options)
        {
            if (Database.EnsureCreated())
            {
                ProductType type_1 = new ProductType { Name = "Одяг" };
                ProductType type_2 = new ProductType { Name = "Продукти харчування" };
                ProductType type_3 = new ProductType { Name = "Товари для дому" };
                ProductType type_4 = new ProductType { Name = "Побутова хімія" };
                ProductType type_5 = new ProductType { Name = "Канцелярія" };
                ProductTypes?.Add(type_1);
                ProductTypes?.Add(type_2);
                ProductTypes?.Add(type_3);
                ProductTypes?.Add(type_4);
                ProductTypes?.Add(type_5);
                Supplier supplier_1 = new Supplier { FullName = "Олександр Іванович Коваленко" };
                Supplier supplier_2 = new Supplier { FullName = "Максим Сергійович Бондар" };
                Supplier supplier_3 = new Supplier { FullName = "Андрій Петрович Мельник" };
                Supplier supplier_4 = new Supplier { FullName = "Дмитро Олегович Ткаченко" };
                Supplier supplier_5 = new Supplier { FullName = "Владислав Миколайович Шевченко" };
                Suppliers?.Add(supplier_1);
                Suppliers?.Add(supplier_2);
                Suppliers?.Add(supplier_3);
                Suppliers?.Add(supplier_4);
                Suppliers?.Add(supplier_5);
                Products?.Add(new Product { Name = "Футболка чорного кольору", Type = type_1, Quantity = 1249, Price = 1800, Supplier = supplier_1, Delivery_date = "22.05.2026" });
                Products?.Add(new Product { Name = "Кавун", Type = type_2, Quantity = 80, Price = 170, Supplier = supplier_2, Delivery_date = "09.05.2026" });
                Products?.Add(new Product { Name = "Стілець", Type = type_3, Quantity = 850, Price = 1500, Supplier = supplier_3, Delivery_date = "10.05.2026" });
                Products?.Add(new Product { Name = "Пральний порошок", Type = type_4, Quantity = 246, Price = 486, Supplier = supplier_4, Delivery_date = "14.05.2026" });
                Products?.Add(new Product { Name = "Ручка", Type = type_5, Quantity = 1700, Price = 16, Supplier = supplier_5, Delivery_date = "15.05.2026" });
                SaveChanges();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
