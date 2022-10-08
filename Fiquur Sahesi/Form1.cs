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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int r;
        double sahe, uzunluq;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                r = Convert.ToInt32(textBox1.Text);
                sahe = Math.PI * r * r;
                MessageBox.Show("Dairənin Sahəsi =" + sahe, "NƏTİCƏ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Müvəqqəti narahatçiliğa görə üzr istəyirik");
            }

        }

        private  void button1_Click(object sender, EventArgs e)
        {
            try
            {
                r = Convert.ToInt32(textBox1.Text);
                uzunluq = Math.PI * 2 * r;
                MessageBox.Show("Dairənin Uzunluğu =" + uzunluq, "NƏTİCƏ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch
            {
                MessageBox.Show("Müvəqqəti narahatçiliğa görə üzr istəyirik");
            }
        }
        int en,uzun;
        double sahee, perimetrr;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label6.Text = textBox3.Text + "cm";
            en = Convert.ToInt32(textBox3.Text);

            sahee = en * uzun;
            perimetrr = (2 * en) + (2 * uzun);
            button5.Visible = true;
            button6.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            btnKvPrm.Visible = false;
            button4.Visible = false;
        }



            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void label7_Click(object sender, EventArgs e)
            {

            }
            int teref;
            double perimetr;
            private void textBox2_TextChanged(object sender, EventArgs e)
            {
                label5.Text = textBox2.Text + "cm";
               // teref= Convert.ToInt32(textBox2.Text);

                //sahe = teref * teref;
                //perimetr = 4 * teref;
                btnKvPrm.Visible = true;
                button4.Visible = true;
                button2.Visible = false;
                button1.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                textBox1.Clear();
                textBox3.Clear();
                textBox4.Clear();
             

            if (textBox2.Text.Length==1)
            {
                button4.Visible = true;
                btnKvPrm.Visible=true;
            }





            }

        

            private void textBox4_TextChanged(object sender, EventArgs e)
            {
                label7.Text = textBox4.Text + "cm";


uzun = Convert.ToInt32(textBox4.Text);
                sahee = en * uzun;
                perimetrr = (en + uzun) * 2;
                button5.Visible = true;
                button6.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                btnKvPrm.Visible = false;
                button4.Visible = false;


            } 


        private void button3_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Kvadratın Perimetri=" + perimetr, "NƏTİCƏ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            teref = Convert.ToInt32(textBox2.Text);
            sahe = teref * teref;
            MessageBox.Show("Kvadratın Sahəsi=" + sahe, "NƏTİCƏ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)

        {

            if (char.IsDigit(e.KeyChar)==false && e.KeyChar!=(char) 08 ) 
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {   //1 ci Üsul 
           // if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
              //  MessageBox.Show("Uyğunsuz Simvol!","Xəbərdarlıq !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
             // 2 -ci Üsul
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar!=' ';
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {// 1 ci Üsul
               // if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
                  //  MessageBox.Show("Uyğunsuz Simvol", "Xəbərdarlıq !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  //2 ci Üsul
                if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
                    e.Handled = true;
            }
            catch
            {
                MessageBox.Show("Müvəqqəti narahatçiliğa görə üzr istəyirik" , "Bildiris!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            try {
                //if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
                // MessageBox.Show("Uyğunsuz Simvol", "Xəbərdarlıq !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
                    e.Handled = true;

            }


            catch
            {
                MessageBox.Show("Müvəqqəti narahatçiliğa görə üzr istəyirik", "Bildiris!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    Form2 yeni = new Form2();
        // yeni.Show();
        //    this.Hide();
        //}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();
        }
        int side;
        private void btnKvPrm_Click(object sender, EventArgs e)
        {
            side=Convert.ToInt32(textBox2.Text);
            //int side;
            double len;
          // len = Convert.ToInt32(textBox2);
            len = side * 4;
            MessageBox.Show("Kvadratin Perimetri ="+ len,"NƏTİCƏ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
           // btnKvPrm.Visible = true;
            //button4.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dördbucaqlınin perimetri= "+ perimetrr, "NƏTİCƏ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dördbucaqlınin Sahəsi=" + sahee, "NƏTİCƏ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text=textBox1.Text+"cm";
            button1.Visible=true;
            button2.Visible = true;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            btnKvPrm.Visible = false;



        }

       
    }
}
