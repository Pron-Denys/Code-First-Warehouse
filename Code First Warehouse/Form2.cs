using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Code_First_Warehouse
{
    using WarehouseContext;
    using WarehouseLibrary;
    public partial class Form2 : Form
    {
        WarehouseContext Warehouse;
        Product Product;
        bool Add;
        public Form2(Product product, bool add, WarehouseContext warehouse)
        {
            InitializeComponent();
            Product = product;
            Add = add;
            Warehouse = warehouse;
            if (add)
            {
                Text = "Додавання товару";
                button1.Text = "Додати товар";
            }
            else
            {
                Text = "Редагування товару";
                button1.Text = "Редагувати товар";
                textBox1.Text = Product.Name;
                textBox2.Text = Product.Type.Name;
                textBox3.Text = Product.Supplier.FullName;
                textBox4.Text = Product.Quantity.ToString();
                textBox5.Text = Product.Price.ToString();
                textBox6.Text = Product.Delivery_date;
            }
        }

        private void Click_InputProduct(object sender, EventArgs e)
        {
            try
            {
                if (Add)
                {
                    if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "")
                            && (textBox5.Text != "") && (textBox6.Text != ""))
                    {
                        Product.Name = textBox1.Text;
                        var temp_type = from product_type in Warehouse.ProductTypes
                                        where product_type.Name == textBox2.Text
                                        select product_type;
                        ProductType? type = temp_type as ProductType;
                        if (type == null)
                        {
                            type = new ProductType { Name = textBox2.Text };
                            Warehouse.ProductTypes.Add(type);
                        }
                        Product.Type = type;
                        var temp_supplier = from supplier_products in Warehouse.Suppliers
                                            where supplier_products.FullName == textBox3.Text
                                            select supplier_products;
                        Supplier? supplier = temp_supplier as Supplier;
                        if (supplier == null)
                        {
                            supplier = new Supplier { FullName = textBox3.Text };
                            Warehouse.Suppliers.Add(supplier);
                        }
                        Product.Supplier = supplier;
                        Product.Quantity = int.Parse(textBox4.Text);
                        Product.Price = double.Parse(textBox5.Text);
                        Product.Delivery_date = textBox6.Text;
                    }
                    else
                        MessageBox.Show("Заповніть всі поля");
                }
                else
                {
                    Product.Name = textBox1.Text;
                    var temp_type = from product_type in Warehouse.ProductTypes
                                    where product_type.Name == textBox2.Text
                                    select product_type;
                    ProductType? type = temp_type as ProductType;
                    if (type == null)
                    {
                        type = new ProductType { Name = textBox2.Text };
                        Warehouse.ProductTypes.Add(type);
                    }
                    Product.Type = type;
                    var temp_supplier = from supplier_products in Warehouse.Suppliers
                                        where supplier_products.FullName == textBox3.Text
                                        select supplier_products;

                    Supplier? supplier = temp_supplier as Supplier;
                    if (supplier == null)
                    {
                        supplier = new Supplier { FullName = textBox3.Text };
                        Warehouse.Suppliers.Add(supplier);
                    }
                    Product.Supplier = supplier;
                    Product.Quantity = int.Parse(textBox4.Text);
                    Product.Price = double.Parse(textBox5.Text);
                    Product.Delivery_date = textBox6.Text;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
