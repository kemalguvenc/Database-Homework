namespace WindowsFormsApp1
{
    partial class Form_AddProduct
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.comboBox_Brand = new System.Windows.Forms.ComboBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label_Brand = new System.Windows.Forms.Label();
            this.label_Type = new System.Windows.Forms.Label();
            this.button_AddBrand = new System.Windows.Forms.Button();
            this.button_AddType = new System.Windows.Forms.Button();
            this.label_UnitPrice = new System.Windows.Forms.Label();
            this.textBox_UnitPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(12, 23);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(51, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Ürün Adı:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(99, 20);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(121, 20);
            this.textBox_Name.TabIndex = 0;
            // 
            // comboBox_Brand
            // 
            this.comboBox_Brand.FormattingEnabled = true;
            this.comboBox_Brand.Location = new System.Drawing.Point(99, 46);
            this.comboBox_Brand.Name = "comboBox_Brand";
            this.comboBox_Brand.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Brand.TabIndex = 1;
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(99, 73);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Type.TabIndex = 3;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(145, 143);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "Ekle";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(12, 143);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 7;
            this.button_Exit.Text = "Çıkış";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label_Brand
            // 
            this.label_Brand.AutoSize = true;
            this.label_Brand.Location = new System.Drawing.Point(12, 49);
            this.label_Brand.Name = "label_Brand";
            this.label_Brand.Size = new System.Drawing.Size(73, 13);
            this.label_Brand.TabIndex = 6;
            this.label_Brand.Text = "Ürün Markası:";
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Location = new System.Drawing.Point(12, 76);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(53, 13);
            this.label_Type.TabIndex = 7;
            this.label_Type.Text = "Ürün Tipi:";
            // 
            // button_AddBrand
            // 
            this.button_AddBrand.Location = new System.Drawing.Point(226, 44);
            this.button_AddBrand.Name = "button_AddBrand";
            this.button_AddBrand.Size = new System.Drawing.Size(107, 23);
            this.button_AddBrand.TabIndex = 2;
            this.button_AddBrand.Text = "Yeni Marka Ekle";
            this.button_AddBrand.UseVisualStyleBackColor = true;
            this.button_AddBrand.Click += new System.EventHandler(this.button_AddBrand_Click);
            // 
            // button_AddType
            // 
            this.button_AddType.Location = new System.Drawing.Point(226, 73);
            this.button_AddType.Name = "button_AddType";
            this.button_AddType.Size = new System.Drawing.Size(107, 23);
            this.button_AddType.TabIndex = 4;
            this.button_AddType.Text = "Yeni Ürün Tipi Ekle";
            this.button_AddType.UseVisualStyleBackColor = true;
            this.button_AddType.Click += new System.EventHandler(this.button_AddType_Click);
            // 
            // label_UnitPrice
            // 
            this.label_UnitPrice.AutoSize = true;
            this.label_UnitPrice.Location = new System.Drawing.Point(12, 103);
            this.label_UnitPrice.Name = "label_UnitPrice";
            this.label_UnitPrice.Size = new System.Drawing.Size(57, 13);
            this.label_UnitPrice.TabIndex = 10;
            this.label_UnitPrice.Text = "Birim Fiyat:";
            // 
            // textBox_UnitPrice
            // 
            this.textBox_UnitPrice.Location = new System.Drawing.Point(99, 100);
            this.textBox_UnitPrice.Name = "textBox_UnitPrice";
            this.textBox_UnitPrice.Size = new System.Drawing.Size(121, 20);
            this.textBox_UnitPrice.TabIndex = 5;
            // 
            // Form_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 173);
            this.Controls.Add(this.textBox_UnitPrice);
            this.Controls.Add(this.label_UnitPrice);
            this.Controls.Add(this.button_AddType);
            this.Controls.Add(this.button_AddBrand);
            this.Controls.Add(this.label_Type);
            this.Controls.Add(this.label_Brand);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.comboBox_Brand);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.Name = "Form_AddProduct";
            this.Text = "Ürün Ekleme";
            this.Activated += new System.EventHandler(this.Form_AddProduct_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ComboBox comboBox_Brand;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label_Brand;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.Button button_AddBrand;
        private System.Windows.Forms.Button button_AddType;
        private System.Windows.Forms.Label label_UnitPrice;
        private System.Windows.Forms.TextBox textBox_UnitPrice;
    }
}