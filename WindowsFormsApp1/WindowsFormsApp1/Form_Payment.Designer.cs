namespace WindowsFormsApp1
{
    partial class Form_Payment
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
            this.label_Payment = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Payment = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_Payment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(12, 15);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(76, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Müşterinin Adı:";
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Location = new System.Drawing.Point(12, 41);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(93, 13);
            this.label_Surname.TabIndex = 1;
            this.label_Surname.Text = "Müşterinin Soyadı:";
            // 
            // label_Payment
            // 
            this.label_Payment.AutoSize = true;
            this.label_Payment.Location = new System.Drawing.Point(12, 67);
            this.label_Payment.Name = "label_Payment";
            this.label_Payment.Size = new System.Drawing.Size(92, 13);
            this.label_Payment.TabIndex = 2;
            this.label_Payment.Text = "Ödenecek Miktar:";
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(15, 104);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "Çıkış";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Payment
            // 
            this.button_Payment.Location = new System.Drawing.Point(135, 104);
            this.button_Payment.Name = "button_Payment";
            this.button_Payment.Size = new System.Drawing.Size(75, 23);
            this.button_Payment.TabIndex = 1;
            this.button_Payment.Text = "Ödeme";
            this.button_Payment.UseVisualStyleBackColor = true;
            this.button_Payment.Click += new System.EventHandler(this.button_Payment_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(110, 12);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 3;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(111, 38);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.ReadOnly = true;
            this.textBox_Surname.Size = new System.Drawing.Size(100, 20);
            this.textBox_Surname.TabIndex = 4;
            // 
            // textBox_Payment
            // 
            this.textBox_Payment.Location = new System.Drawing.Point(110, 64);
            this.textBox_Payment.Name = "textBox_Payment";
            this.textBox_Payment.Size = new System.Drawing.Size(100, 20);
            this.textBox_Payment.TabIndex = 0;
            // 
            // Form_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 139);
            this.Controls.Add(this.textBox_Payment);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.button_Payment);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.label_Payment);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.label_Name);
            this.Name = "Form_Payment";
            this.Text = "Ödeme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_Payment;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Payment;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_Payment;
    }
}