namespace Code_First_Warehouse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(-1, -1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1208, 344);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(-1, 337);
            button1.Name = "button1";
            button1.Size = new Size(195, 60);
            button1.TabIndex = 1;
            button1.Text = "Товар з макс. кількістю";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Click_MaxQuantityProduct;
            // 
            // button2
            // 
            button2.Location = new Point(192, 447);
            button2.Name = "button2";
            button2.Size = new Size(172, 56);
            button2.TabIndex = 2;
            button2.Text = "Весь товар";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Click_AllProducts;
            // 
            // button3
            // 
            button3.Location = new Point(-1, 447);
            button3.Name = "button3";
            button3.Size = new Size(195, 57);
            button3.TabIndex = 3;
            button3.Text = "Завершити роботу";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Click_EndProgram;
            // 
            // button4
            // 
            button4.Location = new Point(-1, 394);
            button4.Name = "button4";
            button4.Size = new Size(195, 56);
            button4.TabIndex = 4;
            button4.Text = "Товар з мін. кількістю";
            button4.UseVisualStyleBackColor = true;
            button4.Click += click_ProductMinQuantity;
            // 
            // button5
            // 
            button5.Location = new Point(192, 337);
            button5.Name = "button5";
            button5.Size = new Size(173, 60);
            button5.TabIndex = 5;
            button5.Text = "Товар з макс. собівартістю";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Click_MaxPriceProduct;
            // 
            // button6
            // 
            button6.Location = new Point(192, 394);
            button6.Name = "button6";
            button6.Size = new Size(173, 56);
            button6.TabIndex = 6;
            button6.Text = "Товар з мін. собівартістю";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Click_MinPriceProduct;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(831, 394);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 7;
            label1.Text = "Введіть тип товару :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(831, 417);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 27);
            textBox1.TabIndex = 8;
            textBox1.KeyDown += TypeProduct;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1006, 417);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 27);
            textBox2.TabIndex = 9;
            textBox2.KeyDown += SupplierProduct;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1006, 394);
            label2.Name = "label2";
            label2.Size = new Size(175, 20);
            label2.TabIndex = 10;
            label2.Text = "Введіть постачальника :";
            // 
            // button7
            // 
            button7.Location = new Point(360, 337);
            button7.Name = "button7";
            button7.Size = new Size(155, 60);
            button7.TabIndex = 11;
            button7.Text = "Середня кількість товару за кожним типом";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Click_AvgTypes;
            // 
            // button8
            // 
            button8.Location = new Point(360, 394);
            button8.Name = "button8";
            button8.Size = new Size(155, 56);
            button8.TabIndex = 12;
            button8.Text = "Найстаріший товар";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Click_OldProduct;
            // 
            // button9
            // 
            button9.Location = new Point(512, 337);
            button9.Name = "button9";
            button9.Size = new Size(155, 84);
            button9.TabIndex = 13;
            button9.Text = "Додати товар";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Click_AddProduct;
            // 
            // button10
            // 
            button10.Location = new Point(360, 446);
            button10.Name = "button10";
            button10.Size = new Size(155, 57);
            button10.TabIndex = 14;
            button10.Text = "Редагувати товар";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Click_EditProduct;
            // 
            // button11
            // 
            button11.Location = new Point(512, 417);
            button11.Name = "button11";
            button11.Size = new Size(155, 86);
            button11.TabIndex = 15;
            button11.Text = "Видалити товар";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Click_RemoveProduct;
            // 
            // button12
            // 
            button12.Location = new Point(664, 337);
            button12.Name = "button12";
            button12.Size = new Size(151, 84);
            button12.TabIndex = 16;
            button12.Text = "Типи товарів";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Click_ProductTypes;
            // 
            // button13
            // 
            button13.Location = new Point(664, 417);
            button13.Name = "button13";
            button13.Size = new Size(151, 86);
            button13.TabIndex = 17;
            button13.Text = "Постачальники";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Click_Suppliers;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 499);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Склад";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
    }
}
