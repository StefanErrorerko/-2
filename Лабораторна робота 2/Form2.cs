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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 100;
            dataGridView1.Rows.Clear();
            Random ran = new Random();
            try
            {
                n = Convert.ToInt16(textBox1.Text);
                Arrays a = new Arrays(n);
                for ( int i=0; i<n; i++)
                {
                    a[i] = ran.Next(-100, 100);
                    dataGridView1.Rows.Add(a[i].ToString());
                 }
                if (a.error) MessageBox.Show("oshibka vvoda dannych");
                label2.Text = "Сума" + a.Summa.ToString();
                label3.Text = "Сума позитивних" + a.Summa_plus.ToString();
                label4.Text = "Сума негативних" + a.Summa_minus.ToString();
                label5.Text = "Сума непарних" + a.Summa_nech.ToString();
            }
            catch
            {
                MessageBox.Show("oshibka vvoda dannych");
            }
        }
    }
}
