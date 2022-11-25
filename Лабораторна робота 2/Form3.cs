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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int n, m;
            try
            {
                n = Convert.ToInt16(textBox1.Text);
                m = Convert.ToInt16(textBox2.Text);
                DataGridViewTextBoxColumn dgvAge;// sozd nuznoe kolvo kolonok
                for(int i=0;i<m;i++)
                {
                    dgvAge = new DataGridViewTextBoxColumn();//shirina kolon
                    dgvAge.Width = 40;//dobav kolon
                    dataGridView1.Columns.Add(dgvAge);
                }
                dataGridView1.Rows.Clear();// kolvo strok i stolb
                dataGridView1.RowCount = n;
                dataGridView1.ColumnCount = m;
                Arrays2 a = new Arrays2(n, m);
                for(int i=0;i<n;i++)
                    for (int j=0;j<m;j++)
                    {
                        a[i, j] = ran.Next(-10, 10);
                        dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                    }
                if (a.error) MessageBox.Show("oshybka");
                label3.Text = "Добуток позитивних" + a.Pr.ToString();
                label4.Text = "Сума негативних" + a.Summ.ToString();
                label5.Text = "minsum" + a.Minsum.ToString();
            }
            catch
            {
                MessageBox.Show("Помилка введення данних");
            }
        }
    }
}
