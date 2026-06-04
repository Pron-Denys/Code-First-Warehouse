using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Code_First_Warehouse
{
    using WarehouseLibrary;
    public partial class Form4 : Form
    {
        object Value;
        bool Add;
        public Form4(object value, bool add)
        {
            InitializeComponent();
            Value = value;
            Add = add;
            if (!Add)
            {
                if (Value is ProductType)
                {
                    Text = "Редагування типу товарів";
                    button1.Text = "Редагувати тип";
                    Value = (ProductType)Value as ProductType;
                    ProductType? product_type = Value as ProductType;
                    textBox1.Text = product_type?.Name;
                }
                else if (Value is Supplier)
                {
                    Text = "Редагування постачальника";
                    button1.Text = "Редагувати постачальника";
                    Value = (Supplier)Value as Supplier;
                    Supplier? supplier = Value as Supplier;
                    textBox1.Text = supplier?.FullName;
                }
            }
            else
            {
                if (Value is ProductType)
                {
                    Text = "Додаваня типу товарів";
                    label1.Text = "Введіть назву типу :";
                    button1.Text = "Додати тип";
                }
                else if (Value is Supplier)
                {
                    Text = "Додаваня постачальника";
                    label1.Text = "Введіть постачальника :";
                    button1.Text = "Додати постачальника";
                }
            }
        }

        private void Click_Input(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Value is ProductType)
                {
                    Value = (ProductType)Value as ProductType;
                    ProductType? product_type = Value as ProductType;
                    product_type?.Name = textBox1.Text;
                }
                else if (Value is Supplier)
                {
                    Value = (Supplier)Value as Supplier;
                    Supplier? supplier = Value as Supplier;
                    supplier?.FullName = textBox1.Text;
                }
            }
        }
    }
}
