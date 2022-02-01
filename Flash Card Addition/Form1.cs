using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flash_Card_Addition
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

           

        }

        private int x = 0;
        int exes;
        public void label1_Click(object sender, EventArgs e)
        {
      

        }

        public void button1_Click(object sender, EventArgs e)
        {
           

        }

        public void button3_Click(object sender, EventArgs e)
        {



            

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        public void label2_Click(object sender, EventArgs e)
        {
            
            

        }
       
     
        public void button5_Click(object sender, EventArgs e)
        {

              
           int Min = 0;

           int Max = 1000;

           Random randNum = new Random();

           int[] test2 = Enumerable

               .Repeat(0, 2)

               .Select(i => randNum.Next(Min, Max))

               .ToArray();


           exes = test2.Sum();

            textBox3.Text = test2[0].ToString();

            textBox4.Text = test2[1].ToString();


            
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
   
        }

        void button2_Click(object sender, EventArgs e)
        {
            int answ = Int32.Parse(s: textBox1.Text);

            if (exes == answ)
            {
                x++;
                textBox2.Text = x.ToString();
                label5.Text = "Not bad.";
            }
            else
            {
                label5.Text = "That's Funny.";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
