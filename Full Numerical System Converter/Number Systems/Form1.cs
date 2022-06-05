using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Systems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btm_Clear_Click(object sender, EventArgs e)
        {
            Txt_Decimal.Text = String.Empty;
            Txt_Binary.Text = String.Empty;
            Txt_Octal.Text = String.Empty;
            Txt_Hex.Text = String.Empty;
        }

        private void Txt_Decimal_TextChanged(object sender, EventArgs e)
        {
            Txt_Decimal.ReadOnly = false;
            Txt_Binary.ReadOnly = true;
            if (Txt_Decimal.Text != "")
            {
                int val_Decimal = Convert.ToInt32(Txt_Decimal.Text);
                //convert from Decimal to Bainary
                string val_Binary = string.Empty;
                while (val_Decimal > 0)
                {
                    val_Binary += (val_Decimal % 2).ToString();
                    val_Decimal /= 2;
                }
                Txt_Binary.Text = Reverse(val_Binary);
                //convert Decimal to Octal
                val_Decimal = Convert.ToInt32(Txt_Decimal.Text);
                string val_Octal = string.Empty;
                while (val_Decimal > 0)
                {
                    val_Octal += (val_Decimal % 8).ToString();
                    val_Decimal /= 8;
                }
                Txt_Octal.Text = Reverse(val_Octal);

                //convert Decimal to Octal
                val_Decimal = Convert.ToInt32(Txt_Decimal.Text);
                string val_HexaDecimal = string.Empty;
                while (val_Decimal > 0)
                {
                    if (val_Decimal % 16 == 10) val_HexaDecimal += "A";
                    else if (val_Decimal % 16 == 11) val_HexaDecimal += "B";
                    else if (val_Decimal % 16 == 12) val_HexaDecimal += "C";
                    else if (val_Decimal % 16 == 13) val_HexaDecimal += "D";
                    else if (val_Decimal % 16 == 14) val_HexaDecimal += "E";
                    else if (val_Decimal % 16 == 15) val_HexaDecimal += "F";
                    else val_HexaDecimal += (val_Decimal % 16).ToString();
                    val_Decimal /= 16;
                }
                Txt_Hex.Text = Reverse(val_HexaDecimal);
            }
            else if (Txt_Decimal.Text == "" )
            {
                Txt_Decimal.Text = "";
                Txt_Binary.Text = "";
                Txt_Octal.Text = "";
                Txt_Hex.Text = "";
            }
        }
        
        private void Txt_Binary_TextChanged(object sender, EventArgs e)
        {
            //Txt_Decimal.ReadOnly = true;
            //Txt_Binary.ReadOnly = false;
            //int val_Decimall = 0;
            //if (Txt_Binary.Text != "")
            //{
            //    char[] arr = Txt_Binary.Text.ToCharArray();
            //    Array.Reverse(arr);
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[0] == '0')
            //            val_Decimall = 0;
            //        else if (arr[i] == '1')
            //            val_Decimall += Convert.ToInt32(Math.Pow(2, i));
            //    }
            //    Txt_Decimal.Text = val_Decimall.ToString();

            //}
            //else if (Txt_Binary.Text == "" || Txt_Binary.Text == "0")
            //{
            //    Txt_Decimal.Text = "";
            //    Txt_Binary.Text = "";
            //    Txt_Octal.Text = "";
            //    Txt_Hex.Text = "";
            //}
        }

        private void Txt_Octal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Hex_TextChanged(object sender, EventArgs e)
        {

        }
        public string Reverse(string Rev)
        {
            char[] arr = Rev.ToCharArray();
            Array.Reverse(arr);
            string x = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                x += arr[i];
            }
            return x;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            Txtn_Decimal.ReadOnly = false;
            Txt_Binary.ReadOnly = true;
            if (Txtn_Decimal.Text != "")
            {
                int val_Decimal = Convert.ToInt32(Txtn_Decimal.Text);
                //convert from Decimal to Bainary
                string val_Binary = string.Empty;
                while (val_Decimal > 0)
                {
                    val_Binary += (val_Decimal % 2).ToString();
                    val_Decimal /= 2;
                }
                Txt_Binary.Text = Reverse(val_Binary);
                //convert Decimal to Octal
                val_Decimal = Convert.ToInt32(Txtn_Decimal.Text);
                string val_Octal = string.Empty;
                while (val_Decimal > 0)
                {
                    val_Octal += (val_Decimal % 8).ToString();
                    val_Decimal /= 8;
                }
                Txt_Octal.Text = Reverse(val_Octal);

                //convert Decimal to Octal
                val_Decimal = Convert.ToInt32(Txtn_Decimal.Text);
                string val_HexaDecimal = string.Empty;
                while (val_Decimal > 0)
                {
                    if (val_Decimal % 16 == 10) val_HexaDecimal += "A";
                    else if (val_Decimal % 16 == 11) val_HexaDecimal += "B";
                    else if (val_Decimal % 16 == 12) val_HexaDecimal += "C";
                    else if (val_Decimal % 16 == 13) val_HexaDecimal += "D";
                    else if (val_Decimal % 16 == 14) val_HexaDecimal += "E";
                    else if (val_Decimal % 16 == 15) val_HexaDecimal += "F";
                    else val_HexaDecimal += (val_Decimal % 16).ToString();
                    val_Decimal /= 16;
                }
                Txt_Hex.Text = Reverse(val_HexaDecimal);
            }
            else if (Txtn_Decimal.Text == "")
            {
                Txt_Decimal.Text = "";
                Txt_Binary.Text = "";
                Txt_Octal.Text = "";
                Txt_Hex.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
