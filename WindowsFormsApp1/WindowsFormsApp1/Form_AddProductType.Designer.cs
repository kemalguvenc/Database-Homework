﻿namespace WindowsFormsApp1
{
    partial class Form_AddProductType
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
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(12, 19);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(53, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Ürün Tipi:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(94, 16);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 0;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(15, 45);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "Çıkış";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(119, 45);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Ekle";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Form_AddProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 82);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.Name = "Form_AddProductType";
            this.Text = "Ürün Tipi Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Add;
    }
}