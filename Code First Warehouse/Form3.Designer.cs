namespace Code_First_Warehouse
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(-2, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(581, 444);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(-2, 443);
            button1.Name = "button1";
            button1.Size = new Size(128, 86);
            button1.TabIndex = 1;
            button1.Text = "Всі типи товарів";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Click_AllTypesProducts;
            // 
            // button2
            // 
            button2.Location = new Point(119, 443);
            button2.Name = "button2";
            button2.Size = new Size(126, 86);
            button2.TabIndex = 2;
            button2.Text = "Додати тип товару";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Click_AddType;
            // 
            // button3
            // 
            button3.Location = new Point(240, 443);
            button3.Name = "button3";
            button3.Size = new Size(130, 86);
            button3.TabIndex = 3;
            button3.Text = "Видалити тип товару";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Click_Remove;
            // 
            // button4
            // 
            button4.Location = new Point(366, 443);
            button4.Name = "button4";
            button4.Size = new Size(139, 86);
            button4.TabIndex = 4;
            button4.Text = "Редагувати тип товару";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Click_EditProductType;
            // 
            // button5
            // 
            button5.DialogResult = DialogResult.OK;
            button5.Location = new Point(502, 443);
            button5.Name = "button5";
            button5.Size = new Size(77, 86);
            button5.TabIndex = 5;
            button5.Text = "Склад";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 528);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            Text = "Типи товарів";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}