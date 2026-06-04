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
    public partial class Form3 : Form
    {
        WarehouseContext Warehouse;
        object Value;
        public Form3(object value, WarehouseContext warehouse)
        {
            InitializeComponent();
            Warehouse = warehouse;
            Value = value;
            if (Value is ProductType)
            {
                var allTypes = from type in Warehouse.ProductTypes
                               select type;
                foreach (var type in allTypes)
                    listBox1.Items.Add(type);
                Text = "Типи товарів";
                button1.Text = "Всі типи товарів";
                button2.Text = "Додати тип товару";
                button3.Text = "Видалити тип товару";
                button4.Text = "Редагувати тип товару";
            }
            else if (Value is Supplier)
            {
                var allSuppliers = from supplier in Warehouse.Suppliers
                               select supplier;
                foreach (var supplier in allSuppliers)
                    listBox1.Items.Add(supplier);
                Text = "Постачальники";
                button1.Text = "Всі постачальники";
                button2.Text = "Додати постачальника";
                button3.Text = "Видалити постачальника";
                button4.Text = "Редагувати постачальника";
            }
        }

        private void Click_AllTypesProducts(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (Value is ProductType)
            {
                var allTypes = from type in Warehouse.ProductTypes
                               select type;
                foreach (var type in allTypes)
                    listBox1.Items.Add(type);
            }
            else if (Value is Supplier)
            {
                var allSuppliers = from supplier in Warehouse.Suppliers
                                   select supplier;
                foreach (var supplier in allSuppliers)
                    listBox1.Items.Add(supplier);
            }
        }

        private void Click_AddType(object sender, EventArgs e)
        {
            if (Value is ProductType)
            {
                ProductType type = new();
                Form4 frm = new(type, true);
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Warehouse.ProductTypes.Add(type);
                    Warehouse.SaveChanges();
                }
            }
            else if (Value is Supplier)
            {
                Supplier supplier = new();
                Form4 frm = new(supplier, true);
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Warehouse.Suppliers.Add(supplier);
                    Warehouse.SaveChanges();
                }
            }
        }

        private void Click_EditProductType(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex + 1;
            if (index != 0)
            {
                if (Value is ProductType)
                {
                    ProductType? type = Warehouse.ProductTypes.Find(index);
                    if (type != null)
                    {
                        Form4 frm = new(type, false);
                        DialogResult result = frm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            Warehouse.SaveChanges();
                        }
                    }
                }
                else if (Value is Supplier)
                {
                    Supplier? supplier = Warehouse.Suppliers.Find(index);
                    if (supplier != null)
                    {
                        Form4 frm = new(supplier, false);
                        DialogResult result = frm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            Warehouse.SaveChanges();
                        }
                    }
                }
            }
            else
                MessageBox.Show("Оберіть позицію", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Click_Remove(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex + 1;
            if (index != 0)
            {
                DialogResult resault = MessageBox.Show("Бажаєте видалити", "Видалення", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);
                if (resault == DialogResult.OK)
                {
                    if (Value is ProductType)
                    {
                        ProductType? type = Warehouse.ProductTypes.Find(index);
                        if (type != null)
                            Warehouse.ProductTypes.RemoveRange(type);
                    }
                    if (Value is Supplier)
                    {
                        Supplier? supplier = Warehouse.Suppliers.Find(index);
                        if (supplier != null)
                            Warehouse.Suppliers.RemoveRange(supplier);
                    }
                    Warehouse.SaveChanges();
                }
            }
            else
                MessageBox.Show("Оберіть позицію", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
