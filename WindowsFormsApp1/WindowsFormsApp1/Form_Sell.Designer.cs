namespace WindowsFormsApp1
{
    partial class Form_Sell
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label_Adress = new System.Windows.Forms.Label();
            this.label_Product = new System.Windows.Forms.Label();
            this.label_UnitPrice = new System.Windows.Forms.Label();
            this.label_Type = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.comboBox_Product = new System.Windows.Forms.ComboBox();
            this.textBox_UnitPrice = new System.Windows.Forms.TextBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Sell = new System.Windows.Forms.Button();
            this.label_Stock = new System.Windows.Forms.Label();
            this.textBox_Stock = new System.Windows.Forms.TextBox();
            this.label_Unit = new System.Windows.Forms.Label();
            this.numericUpDown_Unit = new System.Windows.Forms.NumericUpDown();
            this.label_Worker = new System.Windows.Forms.Label();
            this.comboBox_Worker = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Unit)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(12, 20);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(76, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Müşterinin Adı:";
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Location = new System.Drawing.Point(12, 51);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(93, 13);
            this.label_Surname.TabIndex = 1;
            this.label_Surname.Text = "Müşterinin Soyadı:";
            // 
            // label_Adress
            // 
            this.label_Adress.AutoSize = true;
            this.label_Adress.Location = new System.Drawing.Point(12, 82);
            this.label_Adress.Name = "label_Adress";
            this.label_Adress.Size = new System.Drawing.Size(90, 13);
            this.label_Adress.TabIndex = 2;
            this.label_Adress.Text = "Müşterinin Adresi:";
            // 
            // label_Product
            // 
            this.label_Product.AutoSize = true;
            this.label_Product.Location = new System.Drawing.Point(12, 113);
            this.label_Product.Name = "label_Product";
            this.label_Product.Size = new System.Drawing.Size(33, 13);
            this.label_Product.TabIndex = 3;
            this.label_Product.Text = "Ürün:";
            // 
            // label_UnitPrice
            // 
            this.label_UnitPrice.Location = new System.Drawing.Point(12, 140);
            this.label_UnitPrice.Name = "label_UnitPrice";
            this.label_UnitPrice.Size = new System.Drawing.Size(86, 13);
            this.label_UnitPrice.TabIndex = 0;
            this.label_UnitPrice.Text = "Ürün Birim Fiyatı:";
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Location = new System.Drawing.Point(12, 218);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(75, 13);
            this.label_Type.TabIndex = 4;
            this.label_Type.Text = "Teslimat Şekli:";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(12, 272);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(75, 13);
            this.label_Total.TabIndex = 5;
            this.label_Total.Text = "Toplam Bedel:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(114, 17);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 6;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(114, 48);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.ReadOnly = true;
            this.textBox_Surname.Size = new System.Drawing.Size(100, 20);
            this.textBox_Surname.TabIndex = 7;
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Location = new System.Drawing.Point(114, 79);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.ReadOnly = true;
            this.textBox_Adress.Size = new System.Drawing.Size(100, 20);
            this.textBox_Adress.TabIndex = 8;
            // 
            // comboBox_Product
            // 
            this.comboBox_Product.FormattingEnabled = true;
            this.comboBox_Product.Location = new System.Drawing.Point(114, 110);
            this.comboBox_Product.Name = "comboBox_Product";
            this.comboBox_Product.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Product.TabIndex = 0;
            this.comboBox_Product.SelectedIndexChanged += new System.EventHandler(this.comboBox_Product_SelectedIndexChanged);
            // 
            // textBox_UnitPrice
            // 
            this.textBox_UnitPrice.Location = new System.Drawing.Point(114, 137);
            this.textBox_UnitPrice.Name = "textBox_UnitPrice";
            this.textBox_UnitPrice.ReadOnly = true;
            this.textBox_UnitPrice.Size = new System.Drawing.Size(100, 20);
            this.textBox_UnitPrice.TabIndex = 9;
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(114, 215);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Type.TabIndex = 2;
            // 
            // textBox_Total
            // 
            this.textBox_Total.Location = new System.Drawing.Point(115, 269);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.ReadOnly = true;
            this.textBox_Total.Size = new System.Drawing.Size(100, 20);
            this.textBox_Total.TabIndex = 11;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(12, 295);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.Text = "Çıkış";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Sell
            // 
            this.button_Sell.Location = new System.Drawing.Point(139, 295);
            this.button_Sell.Name = "button_Sell";
            this.button_Sell.Size = new System.Drawing.Size(75, 23);
            this.button_Sell.TabIndex = 4;
            this.button_Sell.Text = "Satış";
            this.button_Sell.UseVisualStyleBackColor = true;
            this.button_Sell.Click += new System.EventHandler(this.button_Sell_Click);
            // 
            // label_Stock
            // 
            this.label_Stock.AutoSize = true;
            this.label_Stock.Location = new System.Drawing.Point(12, 166);
            this.label_Stock.Name = "label_Stock";
            this.label_Stock.Size = new System.Drawing.Size(61, 13);
            this.label_Stock.TabIndex = 15;
            this.label_Stock.Text = "Ürün Stoku";
            // 
            // textBox_Stock
            // 
            this.textBox_Stock.Location = new System.Drawing.Point(114, 163);
            this.textBox_Stock.Name = "textBox_Stock";
            this.textBox_Stock.ReadOnly = true;
            this.textBox_Stock.Size = new System.Drawing.Size(100, 20);
            this.textBox_Stock.TabIndex = 10;
            // 
            // label_Unit
            // 
            this.label_Unit.AutoSize = true;
            this.label_Unit.Location = new System.Drawing.Point(12, 192);
            this.label_Unit.Name = "label_Unit";
            this.label_Unit.Size = new System.Drawing.Size(63, 13);
            this.label_Unit.TabIndex = 17;
            this.label_Unit.Text = "Ürün Adedi:";
            // 
            // numericUpDown_Unit
            // 
            this.numericUpDown_Unit.Location = new System.Drawing.Point(114, 189);
            this.numericUpDown_Unit.Name = "numericUpDown_Unit";
            this.numericUpDown_Unit.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_Unit.TabIndex = 1;
            this.numericUpDown_Unit.ValueChanged += new System.EventHandler(this.numericUpDown_Unit_ValueChanged);
            // 
            // label_Worker
            // 
            this.label_Worker.AutoSize = true;
            this.label_Worker.Location = new System.Drawing.Point(12, 245);
            this.label_Worker.Name = "label_Worker";
            this.label_Worker.Size = new System.Drawing.Size(103, 13);
            this.label_Worker.TabIndex = 19;
            this.label_Worker.Text = "Satış Yapan Görevli:";
            // 
            // comboBox_Worker
            // 
            this.comboBox_Worker.FormattingEnabled = true;
            this.comboBox_Worker.Location = new System.Drawing.Point(115, 242);
            this.comboBox_Worker.Name = "comboBox_Worker";
            this.comboBox_Worker.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Worker.TabIndex = 3;
            // 
            // Form_Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 324);
            this.Controls.Add(this.comboBox_Worker);
            this.Controls.Add(this.label_Worker);
            this.Controls.Add(this.numericUpDown_Unit);
            this.Controls.Add(this.label_Unit);
            this.Controls.Add(this.textBox_Stock);
            this.Controls.Add(this.label_Stock);
            this.Controls.Add(this.button_Sell);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.textBox_Total);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.textBox_UnitPrice);
            this.Controls.Add(this.comboBox_Product);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.label_Type);
            this.Controls.Add(this.label_UnitPrice);
            this.Controls.Add(this.label_Product);
            this.Controls.Add(this.label_Adress);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.label_Name);
            this.Name = "Form_Sell";
            this.Text = "Ürün Satışı";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Unit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_Adress;
        private System.Windows.Forms.Label label_Product;
        private System.Windows.Forms.Label label_UnitPrice;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.ComboBox comboBox_Product;
        private System.Windows.Forms.TextBox textBox_UnitPrice;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Sell;
        private System.Windows.Forms.Label label_Stock;
        private System.Windows.Forms.TextBox textBox_Stock;
        private System.Windows.Forms.Label label_Unit;
        private System.Windows.Forms.NumericUpDown numericUpDown_Unit;
        private System.Windows.Forms.Label label_Worker;
        private System.Windows.Forms.ComboBox comboBox_Worker;
    }
}