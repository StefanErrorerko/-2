using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторна_робота_2//Зарецька Катерина КСМ_21
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
            Tline l1, l2, l3;
            try
            {
                int x1, x2, y1, y2, a, b;
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
                label6.Text = "Площа=" + Convert.ToString(Math.Round(l1.Width, 2));
                label17.Text = "Площа=" + Convert.ToString(Math.Round(l2.Width, 2));
                label25.Text = "Довжина=" + Convert.ToString(Math.Round(l3.Length, 2));
                label29.Text = "Площа=" + Convert.ToString(Math.Round(l3.Width, 2));







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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void одномірнийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void двомірнийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void роботаЗРядкамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
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

        public Tline(int xx1, int xx2, int yy1, int yy2)
        {
            x1 = xx1;
            x2 = xx2;
            y1 = yy1;
            y2 = yy2;

        }
        public Tline(int a, int b)
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
                length = 2 * 3.14 * Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
                return length;
            }
        }
        public double Width
        {
            get
            {
                width = 3.14 * Math.Pow((Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)))), 2);
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
    class Arrays
    {
        public bool error = false; // prisnak oshibki
        int[] a; //zakr massyv
        int length; // zaryt razmernost
        public Arrays(int size) // konstr klassa
        { a = new int[size]; length = size; }
        public int Length //svoistvo razmer
        { get { return length; } }
        public int Summa
        {
            get
            {
                int S = 0;
                for (int i = 0; i < length; i++)
                    S = S + a[i];
                return S;
            }
        }
        public int Summa_plus
        {
            get
            {
                int S = 0;
                for (int i = 0; i < length; i++)
                    if (a[i] >= 0)
                        S = S + a[i];
                return S;
            }
        }

        public int Summa_minus
        {
            get
            {
                int S = 0;
                for (int i = 0; i < length; i++)
                    if (a[i] <= 0)
                        S = S + a[i];
                return S;
            }
        }
        public int Summa_nech
        {
            get
            {
                int S = 0;
                for (int i = 0; i < length; i++)
                    if (a[i] % 2 != 0)
                        S = S + a[i];
                return S;
            }
        }
        
public int this [int i]
        {
            get { if (i >= 0 && i < length) return a[i] ;
            else { error = true;return 0; }
            }
            set
            { if (i >= 0 && i < length && value >= -100 && value <= 100)
                    a[i] = value;
                else error = true;

            }
        }
    }
    class Arrays2
    {
        public bool error = false;
        int[,] a;
        
        int length1;// razm po stolb
        int length2;//razm po strokam
        
        public Arrays2(int size1, int size2)// konstruktor klassa
        { a = new int[size1, size2]; length1 = size1; length2 = size2; 
          }
    public int Length1//svostvo razm
        { get { return length1; } }
        public int Length2//svostvo razm
        { get { return length2; } }
        public int this[int i, int j]
        { get
            {
                if ((i >= 0 && i < length1) && (j >= 0 && j <= length2))
                    return a[i, j];
                else
                {
                    error = true;
                    return 0;
                }
            }set
            {
                if (i >= 0 && i < length1 && j >= 0 && j <= length2 && value >= -10 && value <= 10)
                    a[i, j] = value;
                else error = true;
            }
        }
        public int Summ
        {
            get
            {
                int S = 0;
                for (int i = 0; i < length1; i++)
                    for (int j = 0; j < length2; j++)
                    {
                        if (a[i, j] <= 0)
                            S = S + a[i, j];
                    } return S;
            }
        }

        public int Pr
        {
            get
            {
                int P = 1;
                for (int i = 0; i < length1; i++)
                    for (int j = 0; j < length2; j++)
                    {
                        if (a[i, j] > 0)
                            P = P * a[i, j];
                    }
                return P;
            }
        }
        public int Minsum
        {
            get
            {
                int  summm=0,  minSum = -1000; // minsum dolzna byt menshe iznachalno luboi iz sum v stolbach


                for (int i = 1; i < length1; i++)
                    for (int j = 1; j < length2; j++)
                    {
                        if (a[i, j] <= minSum)
                            summm = +i;

                    }  
                return summm;
            }
        }
    }
}




