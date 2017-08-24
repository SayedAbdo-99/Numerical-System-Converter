using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decimal_to_Bainary_And_opposite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Reverse(string Rev)
        {
            char[] arr = Rev.ToCharArray();
            Array.Reverse(arr);
            string x=string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                x+= arr[i];
            }
            return x;
        }
        
        private void Btn_D_to_B_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_Decimal.ReadOnly = false;
                Txt_Binary.ReadOnly = true;
                Txt_Decimal.BackColor = Color.White;
                Txt_Binary.BackColor = Color.DarkGray;
                if (Txt_Decimal.Text != "")
                {
                   ulong val_Decimal = Convert.ToUInt64(Txt_Decimal.Text);
                    //convert from Decimal to Bainary
                    string val_Binary = string.Empty;
                    while (val_Decimal > 0)
                    {
                        val_Binary += (val_Decimal % 2).ToString();
                        val_Decimal /= 2;
                    }
                    // val_Binary=Reverse(val_Binary);
                    Txt_Binary.Text = Reverse(val_Binary);

                }
                else if (Txt_Decimal.Text == "")
                {
                    Txt_Decimal.Text = "";
                    Txt_Binary.Text = "";
                }
            }
            catch (FormatException)
            {
                Txt_Decimal.BackColor = Color.Red;
                MessageBox.Show("Sorry,Can not Enter flouting Number or Char or String!!!\nPlease Enter Only unsigned intger or unsigned long Numbers!");
            }
            catch (OverflowException)
            {
                Txt_Decimal.BackColor = Color.Yellow;
                MessageBox.Show("You Must by Enter Number less then 9999999999999999999 .");
            }
            catch (Exception f)
            {
                Txt_Decimal.BackColor = Color.Green;
                MessageBox.Show("Error!!!!\n" + f.Message);
            }
        }

        private void Btn_B_to_D_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_Decimal.ReadOnly = true;
                Txt_Binary.ReadOnly = false;
                Txt_Binary.BackColor = Color.White;
                Txt_Decimal.BackColor = Color.DarkGray;
                ulong Val_Binary = 0;
                Txt_Binary.Text = Reverse(Txt_Binary.Text);
                if (Txt_Binary.Text != "")
                {
                    for (int i = 0; i < Txt_Binary.Text.Length; i++)
                    {
                        if (Txt_Binary.Text[i] != '1' && Txt_Binary.Text[i] != '0')
                            throw new FormatException("Sorry!!,Can not Eneter Any Number Other 1,0.\nPlease Enter Only Zeros And Ones..");
                        if (Txt_Binary.Text[i] == '1')
                            if (i == 0) Val_Binary += 1;
                            else
                                Val_Binary += Convert.ToUInt64(Math.Pow(2, i));
                    }
                    Txt_Decimal.Text = Val_Binary.ToString();
                    Txt_Binary.Text = Reverse(Txt_Binary.Text);
                }
                else if (Txt_Binary.Text == "")
                {
                    Txt_Decimal.Text = "";
                    Txt_Binary.Text = "";
                }
            }
            catch (FormatException f) //throw Exception
            {
                Txt_Binary.BackColor = Color.Red;
                MessageBox.Show(f.Message);
            }
            catch (OverflowException o)
            {
                Txt_Binary.BackColor = Color.Yellow;
                MessageBox.Show("Sorry!!, You Entered very Large Number\n" + o.Message);
            }
            catch (Exception uoKnow)
            {
                Txt_Binary.BackColor = Color.Green;
                MessageBox.Show("Error!!!\n"+uoKnow.Message);
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Txt_Decimal.Text = String.Empty;
            Txt_Binary.Text = String.Empty;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
