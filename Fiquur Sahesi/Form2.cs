using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiquur_Sahesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int kKatet, bKatet;
        double area, length;

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear(); 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2 != null) 
            textBox1.Clear();
            


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            label1.Visible=false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            
            

                if (textBox1.Text == "")

                {   //int kKatet, bKatet;
                    //double area, length;
                    kKatet = Convert.ToInt32(textBox2.Text);
                    //area = Convert.ToDouble(textBox3.Text);
                    //length = Convert.ToDouble(textBox1.Text);
                    bKatet = Convert.ToInt32(textBox3.Text);
                    area = bKatet * kKatet / 2;
                    length = bKatet + kKatet + Math.Sqrt((bKatet * bKatet) + (kKatet * kKatet));
                    label2.Text = "Fiqurun sahəsi=" + area.ToString() + "  " + "Perimetri=" + length.ToString();
                }
            

            



            else
            {








                int teref;
                double sahe, perimetr;
                teref = Convert.ToInt32(textBox1.Text);
                sahe = Convert.ToDouble(textBox1.Text);
                perimetr = Convert.ToDouble(textBox1.Text);
                sahe = Math.Sqrt(3) * 3 / 2 * teref * teref;
                perimetr = 6 * teref;

                label1.Text = "Fiqurun sahəsi=" + sahe.ToString() + "   " + "Perimetri=" + perimetr.ToString();
            }

            //int kKatet, bKatet;
            //double area, length;
            //kKatet = Convert.ToInt32(textBox2.Text);
            //area = Convert.ToDouble(textBox3.Text);
            //length = Convert.ToDouble(textBox1.Text);
            //bKatet = Convert.ToInt32(textBox3.Text);
            //area = bKatet * kKatet;
            //length=bKatet+kKatet+Math.Sqrt((bKatet*bKatet)+(kKatet*kKatet));
            //label2.Text= "Fiqurun sahəsi="+area.ToString()+ "Perimetri="+length.ToString();







        }
    }
}
