namespace Number_Systems
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Decimal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_Octal = new System.Windows.Forms.TextBox();
            this.Txt_Hex = new System.Windows.Forms.TextBox();
            this.Txt_Binary = new System.Windows.Forms.TextBox();
            this.Lab_d = new System.Windows.Forms.Label();
            this.Lab_H = new System.Windows.Forms.Label();
            this.Lab_O = new System.Windows.Forms.Label();
            this.Lab_B = new System.Windows.Forms.Label();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btm_Clear = new System.Windows.Forms.Button();
            this.Txtn_Decimal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtn_Decimal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number System Convert";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_Decimal
            // 
            this.Txt_Decimal.BackColor = System.Drawing.Color.White;
            this.Txt_Decimal.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Decimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Txt_Decimal.Location = new System.Drawing.Point(248, 161);
            this.Txt_Decimal.Name = "Txt_Decimal";
            this.Txt_Decimal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Decimal.Size = new System.Drawing.Size(487, 39);
            this.Txt_Decimal.TabIndex = 4;
            this.Txt_Decimal.TextChanged += new System.EventHandler(this.Txt_Decimal_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Number_Systems.Properties.Resources.Convert_HEX_to_Decimal_in_under_30_seconds_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1095, 623);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Txt_Octal
            // 
            this.Txt_Octal.BackColor = System.Drawing.Color.White;
            this.Txt_Octal.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Octal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Txt_Octal.Location = new System.Drawing.Point(248, 335);
            this.Txt_Octal.Name = "Txt_Octal";
            this.Txt_Octal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Octal.Size = new System.Drawing.Size(487, 39);
            this.Txt_Octal.TabIndex = 5;
            this.Txt_Octal.TextChanged += new System.EventHandler(this.Txt_Octal_TextChanged);
            // 
            // Txt_Hex
            // 
            this.Txt_Hex.BackColor = System.Drawing.Color.White;
            this.Txt_Hex.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Hex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Txt_Hex.Location = new System.Drawing.Point(248, 418);
            this.Txt_Hex.Name = "Txt_Hex";
            this.Txt_Hex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Hex.Size = new System.Drawing.Size(487, 39);
            this.Txt_Hex.TabIndex = 6;
            this.Txt_Hex.TextChanged += new System.EventHandler(this.Txt_Hex_TextChanged);
            // 
            // Txt_Binary
            // 
            this.Txt_Binary.BackColor = System.Drawing.Color.White;
            this.Txt_Binary.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Binary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Txt_Binary.Location = new System.Drawing.Point(248, 251);
            this.Txt_Binary.Name = "Txt_Binary";
            this.Txt_Binary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Binary.Size = new System.Drawing.Size(487, 39);
            this.Txt_Binary.TabIndex = 7;
            this.Txt_Binary.TextChanged += new System.EventHandler(this.Txt_Binary_TextChanged);
            // 
            // Lab_d
            // 
            this.Lab_d.AutoSize = true;
            this.Lab_d.BackColor = System.Drawing.Color.Black;
            this.Lab_d.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_d.Location = new System.Drawing.Point(20, 164);
            this.Lab_d.Name = "Lab_d";
            this.Lab_d.Size = new System.Drawing.Size(218, 36);
            this.Lab_d.TabIndex = 8;
            this.Lab_d.Text = "Decimal          :";
            // 
            // Lab_H
            // 
            this.Lab_H.AutoSize = true;
            this.Lab_H.BackColor = System.Drawing.Color.Black;
            this.Lab_H.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_H.Location = new System.Drawing.Point(25, 421);
            this.Lab_H.Name = "Lab_H";
            this.Lab_H.Size = new System.Drawing.Size(217, 36);
            this.Lab_H.TabIndex = 9;
            this.Lab_H.Text = "HexaDecimal :";
            // 
            // Lab_O
            // 
            this.Lab_O.AutoSize = true;
            this.Lab_O.BackColor = System.Drawing.Color.Black;
            this.Lab_O.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_O.Location = new System.Drawing.Point(25, 335);
            this.Lab_O.Name = "Lab_O";
            this.Lab_O.Size = new System.Drawing.Size(213, 36);
            this.Lab_O.TabIndex = 10;
            this.Lab_O.Text = "Octal              :";
            // 
            // Lab_B
            // 
            this.Lab_B.AutoSize = true;
            this.Lab_B.BackColor = System.Drawing.Color.Black;
            this.Lab_B.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_B.Location = new System.Drawing.Point(25, 254);
            this.Lab_B.Name = "Lab_B";
            this.Lab_B.Size = new System.Drawing.Size(216, 36);
            this.Lab_B.TabIndex = 11;
            this.Lab_B.Text = "Binary            :";
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.Red;
            this.Btn_Exit.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.Btn_Exit.Location = new System.Drawing.Point(248, 514);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(115, 48);
            this.Btn_Exit.TabIndex = 12;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btm_Clear
            // 
            this.Btm_Clear.BackColor = System.Drawing.Color.Teal;
            this.Btm_Clear.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm_Clear.ForeColor = System.Drawing.Color.Black;
            this.Btm_Clear.Location = new System.Drawing.Point(407, 514);
            this.Btm_Clear.Name = "Btm_Clear";
            this.Btm_Clear.Size = new System.Drawing.Size(328, 48);
            this.Btm_Clear.TabIndex = 13;
            this.Btm_Clear.Text = "Clear";
            this.Btm_Clear.UseVisualStyleBackColor = false;
            this.Btm_Clear.Click += new System.EventHandler(this.Btm_Clear_Click);
            // 
            // Txtn_Decimal
            // 
            this.Txtn_Decimal.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtn_Decimal.Location = new System.Drawing.Point(247, 116);
            this.Txtn_Decimal.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.Txtn_Decimal.Name = "Txtn_Decimal";
            this.Txtn_Decimal.Size = new System.Drawing.Size(351, 39);
            this.Txtn_Decimal.TabIndex = 14;
            this.Txtn_Decimal.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(825, 583);
            this.Controls.Add(this.Txtn_Decimal);
            this.Controls.Add(this.Btm_Clear);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Lab_B);
            this.Controls.Add(this.Lab_O);
            this.Controls.Add(this.Lab_H);
            this.Controls.Add(this.Lab_d);
            this.Controls.Add(this.Txt_Binary);
            this.Controls.Add(this.Txt_Hex);
            this.Controls.Add(this.Txt_Octal);
            this.Controls.Add(this.Txt_Decimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtn_Decimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Decimal;
        private System.Windows.Forms.TextBox Txt_Octal;
        private System.Windows.Forms.TextBox Txt_Hex;
        private System.Windows.Forms.TextBox Txt_Binary;
        private System.Windows.Forms.Label Lab_d;
        private System.Windows.Forms.Label Lab_H;
        private System.Windows.Forms.Label Lab_O;
        private System.Windows.Forms.Label Lab_B;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btm_Clear;
        private System.Windows.Forms.NumericUpDown Txtn_Decimal;

    }
}

