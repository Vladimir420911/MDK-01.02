namespace DemoProject
{
    partial class AddOrderRecordForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SaleDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(27, 33);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(109, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // SaleDatePicker
            // 
            this.SaleDatePicker.Location = new System.Drawing.Point(27, 79);
            this.SaleDatePicker.Name = "SaleDatePicker";
            this.SaleDatePicker.Size = new System.Drawing.Size(109, 20);
            this.SaleDatePicker.TabIndex = 1;
            // 
            // PriceNumericUpDown
            // 
            this.PriceNumericUpDown.DecimalPlaces = 2;
            this.PriceNumericUpDown.Location = new System.Drawing.Point(27, 136);
            this.PriceNumericUpDown.Name = "PriceNumericUpDown";
            this.PriceNumericUpDown.Size = new System.Drawing.Size(109, 20);
            this.PriceNumericUpDown.TabIndex = 2;
            // 
            // CountNumericUpDown
            // 
            this.CountNumericUpDown.Location = new System.Drawing.Point(27, 187);
            this.CountNumericUpDown.Name = "CountNumericUpDown";
            this.CountNumericUpDown.Size = new System.Drawing.Size(109, 20);
            this.CountNumericUpDown.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(27, 236);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(109, 23);
            this.OkButton.TabIndex = 8;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AddOrderRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 288);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountNumericUpDown);
            this.Controls.Add(this.PriceNumericUpDown);
            this.Controls.Add(this.SaleDatePicker);
            this.Controls.Add(this.NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddOrderRecordForm";
            this.Text = "AddOrderRecordForm";
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.DateTimePicker SaleDatePicker;
        private System.Windows.Forms.NumericUpDown PriceNumericUpDown;
        private System.Windows.Forms.NumericUpDown CountNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OkButton;
    }
}