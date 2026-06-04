namespace Code_First_Warehouse
{
    using WarehouseContext;
    using WarehouseLibrary;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    public partial class Form1 : Form
    {
        WarehouseContext warehouse;
        public Form1()
        {
            InitializeComponent();
            warehouse = new WarehouseContext();
            var allProducts = from p in warehouse.Products
                              select p;
            foreach (var p in allProducts)
                listBox1.Items.Add(p.ToString());
        }

        private void Click_MaxQuantityProduct(object sender, EventArgs e)
        {
            int? max_quantity = (from product in warehouse.Products
                                 select product).Max(product => product.Quantity);
            var max_product = from product in warehouse.Products
                              where product.Quantity == max_quantity
                              select product;
            listBox1.Items.Clear();
            foreach (var product in max_product)
                listBox1.Items.Add((Product)product);
        }

        private void Click_AllProducts(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var allProducts = from p in warehouse.Products
                              select p;
            foreach (var p in allProducts)
                listBox1.Items.Add(p.ToString());
        }

        private void Click_EndProgram(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Бажаєте завершити роботу", "Завершення роботи", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                warehouse.Dispose();
                Application.Exit();
            }
        }

        private void click_ProductMinQuantity(object sender, EventArgs e)
        {
            int? min_quantity = (from product in warehouse.Products
                                 select product).Min(product => product.Quantity);
            var min_product = from product in warehouse.Products
                              where product.Quantity == min_quantity
                              select product;
            listBox1.Items.Clear();
            foreach (var product in min_product)
                listBox1.Items.Add((Product)product);
        }

        private void Click_MaxPriceProduct(object sender, EventArgs e)
        {
            double? max_price = (from product in warehouse.Products
                                 select product).Max(product => product.Price);
            var max_price_product = from product in warehouse.Products
                                    where product.Price == max_price
                                    select product;
            listBox1.Items.Clear();
            foreach (var product in max_price_product)
                listBox1.Items.Add((Product)product);
        }

        private void Click_MinPriceProduct(object sender, EventArgs e)
        {
            double? min_price = (from product in warehouse.Products
                                 select product).Min(product => product.Price);
            var min_price_product = from product in warehouse.Products
                                    where product.Price == min_price
                                    select product;
            listBox1.Items.Clear();
            foreach (var product in min_price_product)
                listBox1.Items.Add((Product)product);
        }

        private void TypeProduct(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var type_products = from product in warehouse.Products
                                    where product.Type.Name == textBox1.Text
                                    select product;
                int counter = 0;
                listBox1.Items.Clear();
                foreach (var product in type_products)
                {
                    listBox1.Items.Add((Product)product);
                    ++counter;
                }
                textBox1.Clear();
                if (counter == 0)
                    MessageBox.Show("Товарів такого типу не знайдено", "Не знайдено",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SupplierProduct(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var type_products = from product in warehouse.Products
                                    where product.Supplier.FullName == textBox2.Text
                                    select product;
                int counter = 0;
                listBox1.Items.Clear();
                foreach (var product in type_products)
                {
                    listBox1.Items.Add((Product)product);
                    ++counter;
                }
                textBox2.Clear();
                if (counter == 0)
                    MessageBox.Show("Товарів цього постачальника не знайдено", "Не знайдено",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Click_AvgTypes(object sender, EventArgs e)
        {
            var avg_types = from product in warehouse.Products
                            group product.Quantity by product.Type.Name into ProductType
                            select new
                            {
                                Type = ProductType.Key,
                                Quantity = ProductType.Average()
                            };
            listBox1.Items.Clear();
            foreach (var product in avg_types)
                listBox1.Items.Add($"{product.Type}  Середня кількість товару: {product.Quantity}");
        }

        private void Click_OldProduct(object sender, EventArgs e)
        {
            try
            {
                var allProducts = from product in warehouse.Products
                                  select product;
                Product? oldProduct = null;
                int old_date = 0;
                int temp_day = 1;
                int temp_month = 1;
                int temp_year = 1;
                int[] leap_year = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int[] ordinary_year = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int days_leap_year = 366;
                int days_ordinary_year = 365;
                int days = 0;
                int year = 1;
                int month = 1;
                foreach (var product in allProducts)
                {
                    if (product.Delivery_date != null)
                    {
                        temp_day = int.Parse(product.Delivery_date.Substring(0, 2));
                        temp_month = int.Parse(product.Delivery_date.Substring(3, 2));
                        temp_year = int.Parse(product.Delivery_date.Substring(6));
                    }
                    month = 1;
                    year = 1;
                    days = 0;
                    while (temp_month != month)
                    {

                        while (temp_year != year)
                        {
                            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
                            {
                                days += days_leap_year;
                                year += 1;
                            }
                            else
                            {
                                days += days_ordinary_year;
                                year += 1;
                            }
                        }
                        if ((temp_year % 4 == 0) && (temp_year % 100 != 0) || (temp_year % 400 == 0))
                        {
                            for (int i = temp_month - 1; temp_month != month; i--)
                            {
                                days += ordinary_year[i];
                                month += 1;
                            }
                        }
                        else
                        {
                            for (int i = temp_month - 1; temp_month != month; i--)
                            {
                                days += ordinary_year[i];
                                month += 1;
                            }
                        }
                    }
                    days += temp_day - 1;
                    if (oldProduct == null)
                    {
                        old_date = days;
                        oldProduct = product as Product;
                    }
                    else
                    {
                        if (old_date > days)
                        {
                            old_date = days;
                            oldProduct = product as Product;
                        }
                    }
                }
                if (oldProduct != null)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(oldProduct);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Click_AddProduct(object sender, EventArgs e)
        {
            Product product = new();
            Form2 frm = new(product, true, warehouse);
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                warehouse.Products.Add(product);
                warehouse.SaveChanges();
            }
        }

        private void Click_EditProduct(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex + 1;
            if (index != 0)
            {
                Product? product = warehouse.Products.Find(index);
                if (product != null)
                {
                    Form2 frm = new(product, false, warehouse);
                    DialogResult result = frm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        warehouse.SaveChanges();
                    }
                }
            }
            else
                MessageBox.Show("Оберіть товар", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Click_RemoveProduct(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex + 1;
            if (index != 0)
            {
                DialogResult resault = MessageBox.Show("Бажаєте видалити товар", "Видалення товару", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (resault == DialogResult.OK)
                {
                    Product? product = warehouse.Products.Find(index);
                    if (product != null)
                    {
                        warehouse.Products.RemoveRange(product);
                        warehouse.SaveChanges();
                    }
                }
            }
            else
                MessageBox.Show("Оберіть товар", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Click_ProductTypes(object sender, EventArgs e)
        {
            Form3 frm = new(new ProductType(), warehouse);
            DialogResult result = frm.ShowDialog();
        }

        private void Click_Suppliers(object sender, EventArgs e)
        {
            Form3 frm = new(new Supplier(), warehouse);
            DialogResult result = frm.ShowDialog();
        }
    }
}
