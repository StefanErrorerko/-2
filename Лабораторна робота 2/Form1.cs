using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторна_робота_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tline l1, l2,l3;
            try
            {
                int x1, x2, y1, y2, a, b ;
                x1 = Convert.ToInt16(textBox1.Text);
                x2 = Convert.ToInt16(textBox2.Text);
                y1 = Convert.ToInt16(textBox3.Text);
                y2 = Convert.ToInt16(textBox4.Text);
                a = Convert.ToInt16(textBox6.Text);
                b = Convert.ToInt16(textBox7.Text);
                l1 = new Tline(x1, x2, y1, y2);
                l2 = new Tline(a, b);
                l3 = new Tline();


                label5.Text = "Довжина=" + Convert.ToString(Math.Round(l1.Length, 2));
                label16.Text = "Довжина=" + Convert.ToString(Math.Round(l2.Length, 2));
                label6.Text = "Ширина=" + Convert.ToString(Math.Round(l1.Width, 2));
                label17.Text = "Ширина=" + Convert.ToString(Math.Round(l2.Width, 2));
                label25.Text = "Довжина=" + Convert.ToString(Math.Round(l3.Length, 2));
                label29.Text = "Ширина=" + Convert.ToString(Math.Round(l3.Width, 2));







                label12.Text = l2.X1.ToString();
                label13.Text = l2.X2.ToString();
                label14.Text = l2.Y1.ToString();
                label15.Text = l2.Y2.ToString();

                label21.Text = l3.X1.ToString();
                label22.Text = l3.X2.ToString();
                label23.Text = l3.Y1.ToString();
                label24.Text = l3.Y2.ToString();


            }
            catch
            {
                MessageBox.Show("Помилка введення");
            }
        }
    }

    class Tline
    {
        int x1;
        int x2;
        int y1;
        int y2;
        double length;
        double width;
       









        public Tline(int xx1, int xx2, int yy1, int yy2 )
        {
            x1 = xx1;
            x2 = xx2;
            y1 = yy1;
            y2 = yy2;
            
        }
        public Tline(int a, int b )
        {
            Random ran = new Random();
            x1 = ran.Next(a, b);
            y1 = ran.Next(a, b);
            x2 = ran.Next(a, b);
            y2 = ran.Next(a, b);
           
        }
        public Tline()
        {
            Random ran = new Random();
            x1 = ran.Next(0, 100);
            y1 = ran.Next(0, 100);
            x2 = ran.Next(0, 100);
            y2 = ran.Next(0, 100);

        }




        public double Length
        {
            get
            {
                length = 2*3.14*Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
                return length;
            }
        }
        public double Width
        {
            get
            {
                width = 3.14 * Math.Pow((Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)))),2);
                return width;
            }
        }

  



        public int X1
        {
            get { return x1; }

        }
        public int X2
        {
            get { return x2; }
        }
        public int Y1
        {
            get { return y1; }
        }
        public int Y2
        {
            get { return y2; }
        }


    }

    



}



