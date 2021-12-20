namespace WindowsFormsApp1
{
    partial class Form_UpdateDelivery
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
            this.label_Type = new System.Windows.Forms.Label();
            this.label_Situation = new System.Windows.Forms.Label();
            this.label_EstimatedDate = new System.Windows.Forms.Label();
            this.label_HappenedDate = new System.Windows.Forms.Label();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.comboBox_Situation = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_EstimatedDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_HappenedDate = new System.Windows.Forms.DateTimePicker();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Location = new System.Drawing.Point(12, 22);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(69, 13);
            this.label_Type.TabIndex = 0;
            this.label_Type.Text = "Teslimat Tipi:";
            // 
            // label_Situation
            // 
            this.label_Situation.AutoSize = true;
            this.label_Situation.Location = new System.Drawing.Point(12, 59);
            this.label_Situation.Name = "label_Situation";
            this.label_Situation.Size = new System.Drawing.Size(89, 13);
            this.label_Situation.TabIndex = 1;
            this.label_Situation.Text = "Teslimat Durumu:";
            // 
            // label_EstimatedDate
            // 
            this.label_EstimatedDate.AutoSize = true;
            this.label_EstimatedDate.Location = new System.Drawing.Point(12, 96);
            this.label_EstimatedDate.Name = "label_EstimatedDate";
            this.label_EstimatedDate.Size = new System.Drawing.Size(102, 13);
            this.label_EstimatedDate.TabIndex = 2;
            this.label_EstimatedDate.Text = "Tahmini Varış Tarihi:";
            // 
            // label_HappenedDate
            // 
            this.label_HappenedDate.AutoSize = true;
            this.label_HappenedDate.Location = new System.Drawing.Point(12, 130);
            this.label_HappenedDate.Name = "label_HappenedDate";
            this.label_HappenedDate.Size = new System.Drawing.Size(96, 13);
            this.label_HappenedDate.TabIndex = 3;
            this.label_HappenedDate.Text = "Teslim Ediliş Tarihi:";
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(142, 19);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(143, 21);
            this.comboBox_Type.TabIndex = 0;
            this.comboBox_Type.SelectedValueChanged += new System.EventHandler(this.comboBox_Type_SelectedValueChanged);
            // 
            // comboBox_Situation
            // 
            this.comboBox_Situation.FormattingEnabled = true;
            this.comboBox_Situation.Location = new System.Drawing.Point(142, 55);
            this.comboBox_Situation.Name = "comboBox_Situation";
            this.comboBox_Situation.Size = new System.Drawing.Size(143, 21);
            this.comboBox_Situation.TabIndex = 1;
            this.comboBox_Situation.SelectedValueChanged += new System.EventHandler(this.comboBox_Situation_SelectedValueChanged);
            // 
            // dateTimePicker_EstimatedDate
            // 
            this.dateTimePicker_EstimatedDate.Location = new System.Drawing.Point(142, 91);
            this.dateTimePicker_EstimatedDate.Name = "dateTimePicker_EstimatedDate";
            this.dateTimePicker_EstimatedDate.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker_EstimatedDate.TabIndex = 2;
            // 
            // dateTimePicker_HappenedDate
            // 
            this.dateTimePicker_HappenedDate.Enabled = false;
            this.dateTimePicker_HappenedDate.Location = new System.Drawing.Point(142, 126);
            this.dateTimePicker_HappenedDate.Name = "dateTimePicker_HappenedDate";
            this.dateTimePicker_HappenedDate.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker_HappenedDate.TabIndex = 3;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(62, 174);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.Text = "Çıkış";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(180, 174);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 4;
            this.button_Update.Text = "Güncelle";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // Form_UpdateDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 210);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.dateTimePicker_HappenedDate);
            this.Controls.Add(this.dateTimePicker_EstimatedDate);
            this.Controls.Add(this.comboBox_Situation);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.label_HappenedDate);
            this.Controls.Add(this.label_EstimatedDate);
            this.Controls.Add(this.label_Situation);
            this.Controls.Add(this.label_Type);
            this.Name = "Form_UpdateDelivery";
            this.Text = "Teslimat Bilgilerini Güncelleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.Label label_Situation;
        private System.Windows.Forms.Label label_EstimatedDate;
        private System.Windows.Forms.Label label_HappenedDate;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.ComboBox comboBox_Situation;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EstimatedDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_HappenedDate;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Update;
    }
}