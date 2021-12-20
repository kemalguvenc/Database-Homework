namespace WindowsFormsApp1
{
    partial class Form_AddSupplier
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
            this.label_Adress = new System.Windows.Forms.Label();
            this.label_ManagerName = new System.Windows.Forms.Label();
            this.label_ManagerSurname = new System.Windows.Forms.Label();
            this.label_ManagerAdress = new System.Windows.Forms.Label();
            this.label_ManagerPhone = new System.Windows.Forms.Label();
            this.label_ManagerEmail = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.textBox_ManagerName = new System.Windows.Forms.TextBox();
            this.textBox_ManagerSurname = new System.Windows.Forms.TextBox();
            this.textBox_ManagerAdress = new System.Windows.Forms.TextBox();
            this.textBox_ManagerPhone = new System.Windows.Forms.TextBox();
            this.textBox_ManagerEmail = new System.Windows.Forms.TextBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(22, 18);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(86, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Tedarikçinin Adı:";
            // 
            // label_Adress
            // 
            this.label_Adress.AutoSize = true;
            this.label_Adress.Location = new System.Drawing.Point(22, 48);
            this.label_Adress.Name = "label_Adress";
            this.label_Adress.Size = new System.Drawing.Size(100, 13);
            this.label_Adress.TabIndex = 1;
            this.label_Adress.Text = "Tedarikçinin Adresi:";
            // 
            // label_ManagerName
            // 
            this.label_ManagerName.AutoSize = true;
            this.label_ManagerName.Location = new System.Drawing.Point(22, 78);
            this.label_ManagerName.Name = "label_ManagerName";
            this.label_ManagerName.Size = new System.Drawing.Size(80, 13);
            this.label_ManagerName.TabIndex = 1;
            this.label_ManagerName.Text = "Temsilcinin Adı:";
            // 
            // label_ManagerSurname
            // 
            this.label_ManagerSurname.AutoSize = true;
            this.label_ManagerSurname.Location = new System.Drawing.Point(22, 108);
            this.label_ManagerSurname.Name = "label_ManagerSurname";
            this.label_ManagerSurname.Size = new System.Drawing.Size(97, 13);
            this.label_ManagerSurname.TabIndex = 1;
            this.label_ManagerSurname.Text = "Temsilcinin Soyadı:";
            // 
            // label_ManagerAdress
            // 
            this.label_ManagerAdress.AutoSize = true;
            this.label_ManagerAdress.Location = new System.Drawing.Point(22, 138);
            this.label_ManagerAdress.Name = "label_ManagerAdress";
            this.label_ManagerAdress.Size = new System.Drawing.Size(94, 13);
            this.label_ManagerAdress.TabIndex = 1;
            this.label_ManagerAdress.Text = "Temsilcinin Adresi:";
            // 
            // label_ManagerPhone
            // 
            this.label_ManagerPhone.AutoSize = true;
            this.label_ManagerPhone.Location = new System.Drawing.Point(22, 168);
            this.label_ManagerPhone.Name = "label_ManagerPhone";
            this.label_ManagerPhone.Size = new System.Drawing.Size(148, 13);
            this.label_ManagerPhone.TabIndex = 1;
            this.label_ManagerPhone.Text = "Temsilcinin Telefon Numarası:";
            // 
            // label_ManagerEmail
            // 
            this.label_ManagerEmail.AutoSize = true;
            this.label_ManagerEmail.Location = new System.Drawing.Point(22, 198);
            this.label_ManagerEmail.Name = "label_ManagerEmail";
            this.label_ManagerEmail.Size = new System.Drawing.Size(134, 13);
            this.label_ManagerEmail.TabIndex = 1;
            this.label_ManagerEmail.Text = "Temsilcinin E-Posta Adresi:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(198, 15);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 0;
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Location = new System.Drawing.Point(198, 45);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(100, 20);
            this.textBox_Adress.TabIndex = 1;
            // 
            // textBox_ManagerName
            // 
            this.textBox_ManagerName.Location = new System.Drawing.Point(198, 75);
            this.textBox_ManagerName.Name = "textBox_ManagerName";
            this.textBox_ManagerName.Size = new System.Drawing.Size(100, 20);
            this.textBox_ManagerName.TabIndex = 2;
            // 
            // textBox_ManagerSurname
            // 
            this.textBox_ManagerSurname.Location = new System.Drawing.Point(198, 105);
            this.textBox_ManagerSurname.Name = "textBox_ManagerSurname";
            this.textBox_ManagerSurname.Size = new System.Drawing.Size(100, 20);
            this.textBox_ManagerSurname.TabIndex = 3;
            // 
            // textBox_ManagerAdress
            // 
            this.textBox_ManagerAdress.Location = new System.Drawing.Point(198, 135);
            this.textBox_ManagerAdress.Name = "textBox_ManagerAdress";
            this.textBox_ManagerAdress.Size = new System.Drawing.Size(100, 20);
            this.textBox_ManagerAdress.TabIndex = 4;
            // 
            // textBox_ManagerPhone
            // 
            this.textBox_ManagerPhone.Location = new System.Drawing.Point(198, 165);
            this.textBox_ManagerPhone.Name = "textBox_ManagerPhone";
            this.textBox_ManagerPhone.Size = new System.Drawing.Size(100, 20);
            this.textBox_ManagerPhone.TabIndex = 5;
            // 
            // textBox_ManagerEmail
            // 
            this.textBox_ManagerEmail.Location = new System.Drawing.Point(198, 195);
            this.textBox_ManagerEmail.Name = "textBox_ManagerEmail";
            this.textBox_ManagerEmail.Size = new System.Drawing.Size(100, 20);
            this.textBox_ManagerEmail.TabIndex = 6;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(33, 237);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 8;
            this.button_Exit.Text = "Çıkış";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(214, 237);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "Ekle";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Form_AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 272);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.textBox_ManagerEmail);
            this.Controls.Add(this.textBox_ManagerPhone);
            this.Controls.Add(this.textBox_ManagerAdress);
            this.Controls.Add(this.textBox_ManagerSurname);
            this.Controls.Add(this.textBox_ManagerName);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_ManagerEmail);
            this.Controls.Add(this.label_ManagerPhone);
            this.Controls.Add(this.label_ManagerAdress);
            this.Controls.Add(this.label_ManagerSurname);
            this.Controls.Add(this.label_ManagerName);
            this.Controls.Add(this.label_Adress);
            this.Controls.Add(this.label_Name);
            this.Name = "Form_AddSupplier";
            this.Text = "Tedarikçi Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Adress;
        private System.Windows.Forms.Label label_ManagerName;
        private System.Windows.Forms.Label label_ManagerSurname;
        private System.Windows.Forms.Label label_ManagerAdress;
        private System.Windows.Forms.Label label_ManagerPhone;
        private System.Windows.Forms.Label label_ManagerEmail;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.TextBox textBox_ManagerName;
        private System.Windows.Forms.TextBox textBox_ManagerSurname;
        private System.Windows.Forms.TextBox textBox_ManagerAdress;
        private System.Windows.Forms.TextBox textBox_ManagerPhone;
        private System.Windows.Forms.TextBox textBox_ManagerEmail;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Add;
    }
}