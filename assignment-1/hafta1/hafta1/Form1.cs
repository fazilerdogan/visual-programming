using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double vizen, finaln, ortalama;
                vizen = Convert.ToDouble(numericUpDown1.Text);
                finaln = Convert.ToDouble(numericUpDown2.Text);

               
                    ortalama = vizen * 0.4 + finaln * 0.6;
                if(ortalama>=50)
                {
                    label3.ForeColor = Color.Green;
                    label3.Text = ortalama.ToString();
                }
                else
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = ortalama.ToString();
                }
                if(ortalama>=90 && ortalama<=100)
                {
                    label4.Text = "AA";
                }
                else if(ortalama >= 85 && ortalama <= 89)
                {
                    label4.Text = "BA";
                }
                else if (ortalama >= 80 && ortalama <= 84)
                {
                    label4.Text = "BB";
                }
                else if (ortalama >= 75 && ortalama <= 79)
                {
                    label4.Text = "CB";
                }
                else if (ortalama >= 70 && ortalama <= 75)
                {
                    label4.Text = "CC";
                }
                else if (ortalama >= 65 && ortalama <= 69)
                {
                    label4.Text = "DC";
                }
                else if (ortalama >= 60 && ortalama <= 64)
                {
                    label4.Text = "DD";
                }



            }
            catch (Exception ex)
            {
                if(numericUpDown1.Text=="" && numericUpDown2.Text=="")
                {
                    MessageBox.Show("geçerli değerler yazınız");
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
