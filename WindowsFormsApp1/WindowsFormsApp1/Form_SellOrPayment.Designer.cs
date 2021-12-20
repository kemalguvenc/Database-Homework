namespace WindowsFormsApp1
{
    partial class Form_SellOrPayment
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
            this.button_Sell = new System.Windows.Forms.Button();
            this.button_Payment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Sell
            // 
            this.button_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Sell.Location = new System.Drawing.Point(12, 12);
            this.button_Sell.Name = "button_Sell";
            this.button_Sell.Size = new System.Drawing.Size(86, 38);
            this.button_Sell.TabIndex = 0;
            this.button_Sell.Text = "Satış";
            this.button_Sell.UseVisualStyleBackColor = true;
            this.button_Sell.Click += new System.EventHandler(this.button_Sell_Click);
            // 
            // button_Payment
            // 
            this.button_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Payment.Location = new System.Drawing.Point(104, 12);
            this.button_Payment.Name = "button_Payment";
            this.button_Payment.Size = new System.Drawing.Size(86, 38);
            this.button_Payment.TabIndex = 1;
            this.button_Payment.Text = "Ödeme";
            this.button_Payment.UseVisualStyleBackColor = true;
            this.button_Payment.Click += new System.EventHandler(this.button_Payment_Click);
            // 
            // Form_SellOrPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 61);
            this.Controls.Add(this.button_Payment);
            this.Controls.Add(this.button_Sell);
            this.Name = "Form_SellOrPayment";
            this.Text = "Satış/Ödeme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Sell;
        private System.Windows.Forms.Button button_Payment;
    }
}