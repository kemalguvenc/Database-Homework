namespace WindowsFormsApp1
{
    partial class Form_AddWorker
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
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Salary = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Salary = new System.Windows.Forms.TextBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.label_Mission = new System.Windows.Forms.Label();
            this.comboBox_Mission = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(12, 16);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(70, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Çalışanın Adı:";
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Location = new System.Drawing.Point(12, 50);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(87, 13);
            this.label_Surname.TabIndex = 1;
            this.label_Surname.Text = "Çalışanın Soyadı:";
            // 
            // label_Adress
            // 
            this.label_Adress.AutoSize = true;
            this.label_Adress.Location = new System.Drawing.Point(12, 84);
            this.label_Adress.Name = "label_Adress";
            this.label_Adress.Size = new System.Drawing.Size(84, 13);
            this.label_Adress.TabIndex = 2;
            this.label_Adress.Text = "Çalışanın Adresi:";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(12, 118);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(138, 13);
            this.label_Phone.TabIndex = 3;
            this.label_Phone.Text = "Çalışanın Telefon Numarası:";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(12, 152);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(124, 13);
            this.label_Email.TabIndex = 4;
            this.label_Email.Text = "Çalışanın E-Posta Adresi:";
            // 
            // label_Salary
            // 
            this.label_Salary.AutoSize = true;
            this.label_Salary.Location = new System.Drawing.Point(12, 186);
            this.label_Salary.Name = "label_Salary";
            this.label_Salary.Size = new System.Drawing.Size(83, 13);
            this.label_Salary.TabIndex = 5;
            this.label_Salary.Text = "Çalışanın Maaşı:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(155, 13);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 0;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(155, 47);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(100, 20);
            this.textBox_Surname.TabIndex = 1;
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Location = new System.Drawing.Point(155, 81);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(100, 20);
            this.textBox_Adress.TabIndex = 2;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(155, 115);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(100, 20);
            this.textBox_Phone.TabIndex = 3;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(155, 149);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(100, 20);
            this.textBox_Email.TabIndex = 4;
            // 
            // textBox_Salary
            // 
            this.textBox_Salary.Location = new System.Drawing.Point(155, 183);
            this.textBox_Salary.Name = "textBox_Salary";
            this.textBox_Salary.Size = new System.Drawing.Size(100, 20);
            this.textBox_Salary.TabIndex = 5;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(21, 256);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 8;
            this.button_Exit.Text = "Çıkış";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(164, 256);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "Ekle";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label_Mission
            // 
            this.label_Mission.AutoSize = true;
            this.label_Mission.Location = new System.Drawing.Point(12, 220);
            this.label_Mission.Name = "label_Mission";
            this.label_Mission.Size = new System.Drawing.Size(86, 13);
            this.label_Mission.TabIndex = 14;
            this.label_Mission.Text = "Çalışanın Görevi:";
            // 
            // comboBox_Mission
            // 
            this.comboBox_Mission.FormattingEnabled = true;
            this.comboBox_Mission.Location = new System.Drawing.Point(155, 217);
            this.comboBox_Mission.Name = "comboBox_Mission";
            this.comboBox_Mission.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Mission.TabIndex = 6;
            // 
            // Form_AddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 289);
            this.Controls.Add(this.comboBox_Mission);
            this.Controls.Add(this.label_Mission);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.textBox_Salary);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Salary);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.label_Adress);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.label_Name);
            this.Name = "Form_AddWorker";
            this.Text = "Çalışan Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_Adress;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Salary;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Salary;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label_Mission;
        private System.Windows.Forms.ComboBox comboBox_Mission;
    }
}