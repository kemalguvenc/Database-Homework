namespace WindowsFormsApp1
{
    partial class Form_BranchInformation
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
            this.tabControl_BranchInformation = new System.Windows.Forms.TabControl();
            this.tabPage_Sells = new System.Windows.Forms.TabPage();
            this.dataGridView_Sells = new System.Windows.Forms.DataGridView();
            this.tabPage_Purchases = new System.Windows.Forms.TabPage();
            this.dataGridView_Purchases = new System.Windows.Forms.DataGridView();
            this.tabPage_Suppliers = new System.Windows.Forms.TabPage();
            this.dataGridView_Suppliers = new System.Windows.Forms.DataGridView();
            this.tabPage_Workers = new System.Windows.Forms.TabPage();
            this.dataGridView_Workers = new System.Windows.Forms.DataGridView();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.tabControl_BranchInformation.SuspendLayout();
            this.tabPage_Sells.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sells)).BeginInit();
            this.tabPage_Purchases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Purchases)).BeginInit();
            this.tabPage_Suppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Suppliers)).BeginInit();
            this.tabPage_Workers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Workers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_BranchInformation
            // 
            this.tabControl_BranchInformation.Controls.Add(this.tabPage_Sells);
            this.tabControl_BranchInformation.Controls.Add(this.tabPage_Purchases);
            this.tabControl_BranchInformation.Controls.Add(this.tabPage_Suppliers);
            this.tabControl_BranchInformation.Controls.Add(this.tabPage_Workers);
            this.tabControl_BranchInformation.ItemSize = new System.Drawing.Size(57, 18);
            this.tabControl_BranchInformation.Location = new System.Drawing.Point(1, 2);
            this.tabControl_BranchInformation.Name = "tabControl_BranchInformation";
            this.tabControl_BranchInformation.SelectedIndex = 0;
            this.tabControl_BranchInformation.Size = new System.Drawing.Size(533, 311);
            this.tabControl_BranchInformation.TabIndex = 0;
            this.tabControl_BranchInformation.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_BranchInformation_Selected);
            // 
            // tabPage_Sells
            // 
            this.tabPage_Sells.Controls.Add(this.dataGridView_Sells);
            this.tabPage_Sells.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Sells.Name = "tabPage_Sells";
            this.tabPage_Sells.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Sells.Size = new System.Drawing.Size(525, 285);
            this.tabPage_Sells.TabIndex = 0;
            this.tabPage_Sells.Text = "Satışlar";
            this.tabPage_Sells.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Sells
            // 
            this.dataGridView_Sells.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Sells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sells.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Sells.Name = "dataGridView_Sells";
            this.dataGridView_Sells.Size = new System.Drawing.Size(525, 285);
            this.dataGridView_Sells.TabIndex = 2;
            // 
            // tabPage_Purchases
            // 
            this.tabPage_Purchases.Controls.Add(this.dataGridView_Purchases);
            this.tabPage_Purchases.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Purchases.Name = "tabPage_Purchases";
            this.tabPage_Purchases.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Purchases.Size = new System.Drawing.Size(525, 285);
            this.tabPage_Purchases.TabIndex = 1;
            this.tabPage_Purchases.Text = "Alışlar";
            this.tabPage_Purchases.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Purchases
            // 
            this.dataGridView_Purchases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Purchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Purchases.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Purchases.Name = "dataGridView_Purchases";
            this.dataGridView_Purchases.Size = new System.Drawing.Size(525, 285);
            this.dataGridView_Purchases.TabIndex = 2;
            // 
            // tabPage_Suppliers
            // 
            this.tabPage_Suppliers.Controls.Add(this.dataGridView_Suppliers);
            this.tabPage_Suppliers.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Suppliers.Name = "tabPage_Suppliers";
            this.tabPage_Suppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Suppliers.Size = new System.Drawing.Size(525, 285);
            this.tabPage_Suppliers.TabIndex = 2;
            this.tabPage_Suppliers.Text = "Tedarikçiler";
            this.tabPage_Suppliers.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Suppliers
            // 
            this.dataGridView_Suppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Suppliers.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Suppliers.Name = "dataGridView_Suppliers";
            this.dataGridView_Suppliers.Size = new System.Drawing.Size(525, 285);
            this.dataGridView_Suppliers.TabIndex = 1;
            // 
            // tabPage_Workers
            // 
            this.tabPage_Workers.Controls.Add(this.dataGridView_Workers);
            this.tabPage_Workers.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Workers.Name = "tabPage_Workers";
            this.tabPage_Workers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Workers.Size = new System.Drawing.Size(525, 285);
            this.tabPage_Workers.TabIndex = 3;
            this.tabPage_Workers.Text = "Çalışanlar";
            this.tabPage_Workers.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Workers
            // 
            this.dataGridView_Workers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Workers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Workers.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Workers.Name = "dataGridView_Workers";
            this.dataGridView_Workers.Size = new System.Drawing.Size(525, 285);
            this.dataGridView_Workers.TabIndex = 1;
            // 
            // button_Exit
            // 
            this.button_Exit.Image = global::WindowsFormsApp1.Properties.Resources.close;
            this.button_Exit.Location = new System.Drawing.Point(540, 274);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(37, 35);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
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
            // Form_BranchInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 313);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.tabControl_BranchInformation);
            this.Name = "Form_BranchInformation";
            this.Text = "Şube Bilgileri";
            this.Activated += new System.EventHandler(this.button_Refresh_Click);
            this.tabControl_BranchInformation.ResumeLayout(false);
            this.tabPage_Sells.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sells)).EndInit();
            this.tabPage_Purchases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Purchases)).EndInit();
            this.tabPage_Suppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Suppliers)).EndInit();
            this.tabPage_Workers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Workers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_BranchInformation;
        private System.Windows.Forms.TabPage tabPage_Sells;
        private System.Windows.Forms.TabPage tabPage_Purchases;
        private System.Windows.Forms.TabPage tabPage_Suppliers;
        private System.Windows.Forms.TabPage tabPage_Workers;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridView dataGridView_Suppliers;
        private System.Windows.Forms.DataGridView dataGridView_Workers;
        private System.Windows.Forms.DataGridView dataGridView_Sells;
        private System.Windows.Forms.DataGridView dataGridView_Purchases;
        private System.Windows.Forms.Button button_Update;
    }
}