namespace WindowsFormsApp1
{
    partial class Form_System
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
            this.tabControl_System = new System.Windows.Forms.TabControl();
            this.tabPage_Customers = new System.Windows.Forms.TabPage();
            this.dataGridView_Customers = new System.Windows.Forms.DataGridView();
            this.tabPage_Products = new System.Windows.Forms.TabPage();
            this.dataGridView_Products = new System.Windows.Forms.DataGridView();
            this.tabPage_Deliveries = new System.Windows.Forms.TabPage();
            this.dataGridView_Deliveries = new System.Windows.Forms.DataGridView();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_BranchInformation = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.tabControl_System.SuspendLayout();
            this.tabPage_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customers)).BeginInit();
            this.tabPage_Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).BeginInit();
            this.tabPage_Deliveries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Deliveries)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_System
            // 
            this.tabControl_System.Controls.Add(this.tabPage_Customers);
            this.tabControl_System.Controls.Add(this.tabPage_Products);
            this.tabControl_System.Controls.Add(this.tabPage_Deliveries);
            this.tabControl_System.Location = new System.Drawing.Point(1, 2);
            this.tabControl_System.Name = "tabControl_System";
            this.tabControl_System.SelectedIndex = 0;
            this.tabControl_System.Size = new System.Drawing.Size(533, 311);
            this.tabControl_System.TabIndex = 1;
            this.tabControl_System.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_System_Selected);
            // 
            // tabPage_Customers
            // 
            this.tabPage_Customers.Controls.Add(this.dataGridView_Customers);
            this.tabPage_Customers.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Customers.Name = "tabPage_Customers";
            this.tabPage_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Customers.Size = new System.Drawing.Size(525, 285);
            this.tabPage_Customers.TabIndex = 0;
            this.tabPage_Customers.Text = "Müşteriler";
            this.tabPage_Customers.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Customers
            // 
            this.dataGridView_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Customers.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Customers.Name = "dataGridView_Customers";
            this.dataGridView_Customers.ReadOnly = true;
            this.dataGridView_Customers.Size = new System.Drawing.Size(525, 285);
            this.dataGridView_Customers.TabIndex = 0;
            this.dataGridView_Customers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Customers_RowHeaderMouseDoubleClick);
            // 
            // tabPage_Products
            // 
            this.tabPage_Products.Controls.Add(this.dataGridView_Products);
            this.tabPage_Products.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Products.Name = "tabPage_Products";
            this.tabPage_Products.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Products.Size = new System.Drawing.Size(525, 285);
            this.tabPage_Products.TabIndex = 1;
            this.tabPage_Products.Text = "Ürünler";
            this.tabPage_Products.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Products
            // 
            this.dataGridView_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Products.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Products.Name = "dataGridView_Products";
            this.dataGridView_Products.ReadOnly = true;
            this.dataGridView_Products.Size = new System.Drawing.Size(525, 285);
            this.dataGridView_Products.TabIndex = 0;
            // 
            // tabPage_Deliveries
            // 
            this.tabPage_Deliveries.Controls.Add(this.dataGridView_Deliveries);
            this.tabPage_Deliveries.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Deliveries.Name = "tabPage_Deliveries";
            this.tabPage_Deliveries.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Deliveries.Size = new System.Drawing.Size(525, 285);
            this.tabPage_Deliveries.TabIndex = 4;
            this.tabPage_Deliveries.Text = "Teslimatlar";
            this.tabPage_Deliveries.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Deliveries
            // 
            this.dataGridView_Deliveries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Deliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Deliveries.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Deliveries.Name = "dataGridView_Deliveries";
            this.dataGridView_Deliveries.ReadOnly = true;
            this.dataGridView_Deliveries.Size = new System.Drawing.Size(525, 285);
            this.dataGridView_Deliveries.TabIndex = 1;
            // 
            // button_Exit
            // 
            this.button_Exit.Image = global::WindowsFormsApp1.Properties.Resources.close;
            this.button_Exit.Location = new System.Drawing.Point(540, 274);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(37, 35);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_BranchInformation
            // 
            this.button_BranchInformation.Image = global::WindowsFormsApp1.Properties.Resources.information;
            this.button_BranchInformation.Location = new System.Drawing.Point(540, 231);
            this.button_BranchInformation.Name = "button_BranchInformation";
            this.button_BranchInformation.Size = new System.Drawing.Size(37, 37);
            this.button_BranchInformation.TabIndex = 4;
            this.button_BranchInformation.UseVisualStyleBackColor = true;
            this.button_BranchInformation.Click += new System.EventHandler(this.button_BranchInformation_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Image = global::WindowsFormsApp1.Properties.Resources.refresh;
            this.button_Refresh.Location = new System.Drawing.Point(540, 24);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(37, 39);
            this.button_Refresh.TabIndex = 0;
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Update
            // 
            this.button_Update.Image = global::WindowsFormsApp1.Properties.Resources.update;
            this.button_Update.Location = new System.Drawing.Point(540, 162);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(37, 40);
            this.button_Update.TabIndex = 3;
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Image = global::WindowsFormsApp1.Properties.Resources.minus;
            this.button_Remove.Location = new System.Drawing.Point(540, 116);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(37, 40);
            this.button_Remove.TabIndex = 2;
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Add
            // 
            this.button_Add.Image = global::WindowsFormsApp1.Properties.Resources.plus;
            this.button_Add.Location = new System.Drawing.Point(540, 69);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(37, 41);
            this.button_Add.TabIndex = 1;
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Form_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 313);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_BranchInformation);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.tabControl_System);
            this.Name = "Form_System";
            this.Text = "Ana Sistem";
            this.Activated += new System.EventHandler(this.button_Refresh_Click);
            this.tabControl_System.ResumeLayout(false);
            this.tabPage_Customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customers)).EndInit();
            this.tabPage_Products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).EndInit();
            this.tabPage_Deliveries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Deliveries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl_System;
        private System.Windows.Forms.TabPage tabPage_Products;
        private System.Windows.Forms.DataGridView dataGridView_Products;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_BranchInformation;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TabPage tabPage_Customers;
        private System.Windows.Forms.DataGridView dataGridView_Customers;
        private System.Windows.Forms.TabPage tabPage_Deliveries;
        private System.Windows.Forms.DataGridView dataGridView_Deliveries;
        private System.Windows.Forms.Button button_Update;
    }
}