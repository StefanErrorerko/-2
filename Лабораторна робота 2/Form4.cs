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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonSortStandard_Click(object sender, EventArgs e)
        {
            String EditableText = richTextBoxInput.Text;
            richTextBoxOutputStandard_Clear();
            if (!String.IsNullOrEmpty(EditableText))
            {
                var Processor = new StringProcesser(EditableText);
                richTextBoxOutputStandard.Text = Processor.SortStandard();
            }
            
        }

        private void buttonSortUsual_Click(object sender, EventArgs e)
        {
            String EditableText = richTextBoxInput.Text;
            richTextBoxOutputUsual_Clear();
            if (!String.IsNullOrEmpty(EditableText))
            {
                var Processor = new StringProcesser(EditableText);
                richTextBoxOutputUsual.Text = Processor.SortUsual();
            }
        }

        private void richTextBoxOutputStandard_Clear()
        {
            richTextBoxOutputStandard.Text = String.Empty;
        }
        private void richTextBoxOutputUsual_Clear()
        {
            richTextBoxOutputUsual.Text = String.Empty;
        }

        private void buttonStandardClear_Click(object sender, EventArgs e)
        {
            richTextBoxOutputStandard_Clear();
        }

        private void buttonUsualClear_Click(object sender, EventArgs e)
        {
            richTextBoxOutputUsual_Clear();
        }
    }
}
