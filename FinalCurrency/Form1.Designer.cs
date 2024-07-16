namespace FinalCurrency
{
    partial class Form1
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
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.responseTxtBox = new System.Windows.Forms.TextBox();
            this.fromCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.toCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.amountInput = new System.Windows.Forms.TextBox();
            this.convertedResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.BackColor = System.Drawing.Color.White;
            this.fromLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(141, 276);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(50, 19);
            this.fromLabel.TabIndex = 3;
            this.fromLabel.Text = "From";
            this.fromLabel.Click += new System.EventHandler(this.fromLabel_Click);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.BackColor = System.Drawing.Color.White;
            this.toLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(597, 276);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(30, 19);
            this.toLabel.TabIndex = 4;
            this.toLabel.Text = "To";
            this.toLabel.Click += new System.EventHandler(this.toLabel_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.BackColor = System.Drawing.Color.White;
            this.amountLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(348, 185);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(73, 19);
            this.amountLabel.TabIndex = 6;
            this.amountLabel.Text = "Amount";
            this.amountLabel.Click += new System.EventHandler(this.amountLabel_Click);
            // 
            // responseTxtBox
            // 
            this.responseTxtBox.Location = new System.Drawing.Point(781, 452);
            this.responseTxtBox.Multiline = true;
            this.responseTxtBox.Name = "responseTxtBox";
            this.responseTxtBox.Size = new System.Drawing.Size(37, 10);
            this.responseTxtBox.TabIndex = 7;
            this.responseTxtBox.Visible = false;
            this.responseTxtBox.TextChanged += new System.EventHandler(this.responseTxtBox_TextChanged);
            // 
            // fromCurrencyComboBox
            // 
            this.fromCurrencyComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.fromCurrencyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fromCurrencyComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromCurrencyComboBox.FormattingEnabled = true;
            this.fromCurrencyComboBox.Location = new System.Drawing.Point(137, 298);
            this.fromCurrencyComboBox.Name = "fromCurrencyComboBox";
            this.fromCurrencyComboBox.Size = new System.Drawing.Size(164, 27);
            this.fromCurrencyComboBox.TabIndex = 10;
            this.fromCurrencyComboBox.SelectedIndexChanged += new System.EventHandler(this.fromCurrencyComboBox_SelectedIndexChanged);
            // 
            // toCurrencyComboBox
            // 
            this.toCurrencyComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.toCurrencyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toCurrencyComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toCurrencyComboBox.FormattingEnabled = true;
            this.toCurrencyComboBox.Location = new System.Drawing.Point(463, 298);
            this.toCurrencyComboBox.Name = "toCurrencyComboBox";
            this.toCurrencyComboBox.Size = new System.Drawing.Size(164, 27);
            this.toCurrencyComboBox.TabIndex = 11;
            this.toCurrencyComboBox.SelectedIndexChanged += new System.EventHandler(this.toCurrencyComboBox_SelectedIndexChanged);
            // 
            // amountInput
            // 
            this.amountInput.BackColor = System.Drawing.Color.White;
            this.amountInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.amountInput.Location = new System.Drawing.Point(300, 217);
            this.amountInput.Multiline = true;
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(164, 27);
            this.amountInput.TabIndex = 12;
            this.amountInput.WordWrap = false;
            this.amountInput.TextChanged += new System.EventHandler(this.amountInput_TextChanged);
            // 
            // convertedResult
            // 
            this.convertedResult.BackColor = System.Drawing.SystemColors.Window;
            this.convertedResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertedResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedResult.Location = new System.Drawing.Point(60, 315);
            this.convertedResult.Multiline = true;
            this.convertedResult.Name = "convertedResult";
            this.convertedResult.ReadOnly = true;
            this.convertedResult.Size = new System.Drawing.Size(428, 94);
            this.convertedResult.TabIndex = 15;
            this.convertedResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.convertedResult.TextChanged += new System.EventHandler(this.convertedResult_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(207, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "CURRENCY CONVERTER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.White;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.convertButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.ForeColor = System.Drawing.Color.Black;
            this.convertButton.Location = new System.Drawing.Point(396, 265);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(92, 34);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "⇄";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(469, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "💸💸\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(8, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "💸💸";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(353, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 42);
            this.label5.TabIndex = 19;
            this.label5.Text = "💱\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalCurrency.Properties.Resources.Currency_Converter;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.convertedResult);
            this.panel1.Controls.Add(this.convertButton);
            this.panel1.Location = new System.Drawing.Point(104, 90);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(557, 438);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 34);
            this.label2.TabIndex = 22;
            this.label2.Text = "JTP ProfElecFinalProject";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(767, 594);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountInput);
            this.Controls.Add(this.toCurrencyComboBox);
            this.Controls.Add(this.fromCurrencyComboBox);
            this.Controls.Add(this.responseTxtBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox responseTxtBox;
        private System.Windows.Forms.ComboBox fromCurrencyComboBox;
        private System.Windows.Forms.ComboBox toCurrencyComboBox;
        private System.Windows.Forms.TextBox convertedResult;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TextBox amountInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

