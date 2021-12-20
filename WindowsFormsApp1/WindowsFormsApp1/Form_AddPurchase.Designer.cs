namespace WindowsFormsApp1
{
    partial class Form_AddPurchase
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
            this.label_Product = new System.Windows.Forms.Label();
            this.label_Supplier = new System.Windows.Forms.Label();
            this.label_Unit = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.comboBox_Product = new System.Windows.Forms.ComboBox();
            this.numericUpDown_Unit = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Supplier = new System.Windows.Forms.ComboBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Purchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Unit)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Product
            // 
            this.label_Product.AutoSize = true;
            this.label_Product.Location = new System.Drawing.Point(13, 15);
            this.label_Product.Name = "label_Product";
            this.label_Product.Size = new System.Drawing.Size(33, 13);
            this.label_Product.TabIndex = 0;
            this.label_Product.Text = "Ürün:";
            // 
            // label_Supplier
            // 
            this.label_Supplier.AutoSize = true;
            this.label_Supplier.Location = new System.Drawing.Point(13, 68);
            this.label_Supplier.Name = "label_Supplier";
            this.label_Supplier.Size = new System.Drawing.Size(51, 13);
            this.label_Supplier.TabIndex = 1;
            this.label_Supplier.Text = "Tedarikçi";
            // 
            // label_Unit
            // 
            this.label_Unit.AutoSize = true;
            this.label_Unit.Location = new System.Drawing.Point(13, 41);
            this.label_Unit.Name = "label_Unit";
            this.label_Unit.Size = new System.Drawing.Size(32, 13);
            this.label_Unit.TabIndex = 3;
            this.label_Unit.Text = "Adet:";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(13, 95);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(74, 13);
            this.label_Price.TabIndex = 4;
            this.label_Price.Text = "Toplam Ücret:";
            // 
            // comboBox_Product
            // 
            this.comboBox_Product.FormattingEnabled = true;
            this.comboBox_Product.Location = new System.Drawing.Point(118, 12);
            this.comboBox_Product.Name = "comboBox_Product";
            this.comboBox_Product.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Product.TabIndex = 0;
            // 
            // numericUpDown_Unit
            // 
            this.numericUpDown_Unit.Location = new System.Drawing.Point(118, 39);
            this.numericUpDown_Unit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Unit.Name = "numericUpDown_Unit";
            this.numericUpDown_Unit.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown_Unit.TabIndex = 1;
            this.numericUpDown_Unit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_Supplier
            // 
            this.comboBox_Supplier.FormattingEnabled = true;
            this.comboBox_Supplier.Location = new System.Drawing.Point(118, 65);
            this.comboBox_Supplier.Name = "comboBox_Supplier";
            this.comboBox_Supplier.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Supplier.TabIndex = 2;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(118, 92);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(121, 20);
            this.textBox_Price.TabIndex = 4;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(16, 128);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.Text = "Çıkış";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Purchase
            // 
            this.button_Purchase.Location = new System.Drawing.Point(164, 128);
            this.button_Purchase.Name = "button_Purchase";
            this.button_Purchase.Size = new System.Drawing.Size(75, 23);
            this.button_Purchase.TabIndex = 5;
            this.button_Purchase.Text = "Alım";
            this.button_Purchase.UseVisualStyleBackColor = true;
            this.button_Purchase.Click += new System.EventHandler(this.button_Purchase_Click);
            // 
            // Form_AddPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 158);
            this.Controls.Add(this.button_Purchase);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.comboBox_Supplier);
            this.Controls.Add(this.numericUpDown_Unit);
            this.Controls.Add(this.comboBox_Product);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.label_Unit);
            this.Controls.Add(this.label_Supplier);
            this.Controls.Add(this.label_Product);
            this.Name = "Form_AddPurchase";
            this.Text = "Ürün Alımı";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Unit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Product;
        private System.Windows.Forms.Label label_Supplier;
        private System.Windows.Forms.Label label_Unit;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.ComboBox comboBox_Product;
        private System.Windows.Forms.NumericUpDown numericUpDown_Unit;
        private System.Windows.Forms.ComboBox comboBox_Supplier;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Purchase;
    }
}