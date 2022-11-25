namespace Лабораторна_робота_2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutputStandard = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutputUsual = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStandardClear = new System.Windows.Forms.Button();
            this.buttonUsualClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сортувати (стандартні функції) ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSortStandard_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Сортувати (без станд. функцій)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonSortUsual_Click);
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(51, 40);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(687, 96);
            this.richTextBoxInput.TabIndex = 2;
            this.richTextBoxInput.Text = "";
            // 
            // richTextBoxOutputStandard
            // 
            this.richTextBoxOutputStandard.Enabled = false;
            this.richTextBoxOutputStandard.Location = new System.Drawing.Point(51, 298);
            this.richTextBoxOutputStandard.Name = "richTextBoxOutputStandard";
            this.richTextBoxOutputStandard.Size = new System.Drawing.Size(328, 96);
            this.richTextBoxOutputStandard.TabIndex = 3;
            this.richTextBoxOutputStandard.Text = "";
            // 
            // richTextBoxOutputUsual
            // 
            this.richTextBoxOutputUsual.Enabled = false;
            this.richTextBoxOutputUsual.Location = new System.Drawing.Point(410, 298);
            this.richTextBoxOutputUsual.Name = "richTextBoxOutputUsual";
            this.richTextBoxOutputUsual.Size = new System.Drawing.Size(328, 96);
            this.richTextBoxOutputUsual.TabIndex = 4;
            this.richTextBoxOutputUsual.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введіть ваш текст. Будь ласка, відділяйте слова пробілом";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Відсортований текст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Відсортований текст:";
            // 
            // buttonStandardClear
            // 
            this.buttonStandardClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStandardClear.Location = new System.Drawing.Point(207, 202);
            this.buttonStandardClear.Name = "buttonStandardClear";
            this.buttonStandardClear.Size = new System.Drawing.Size(172, 43);
            this.buttonStandardClear.TabIndex = 8;
            this.buttonStandardClear.Text = "Очистити поле";
            this.buttonStandardClear.UseVisualStyleBackColor = false;
            this.buttonStandardClear.Click += new System.EventHandler(this.buttonStandardClear_Click);
            // 
            // buttonUsualClear
            // 
            this.buttonUsualClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUsualClear.Location = new System.Drawing.Point(566, 202);
            this.buttonUsualClear.Name = "buttonUsualClear";
            this.buttonUsualClear.Size = new System.Drawing.Size(172, 43);
            this.buttonUsualClear.TabIndex = 9;
            this.buttonUsualClear.Text = "Очистити поле";
            this.buttonUsualClear.UseVisualStyleBackColor = false;
            this.buttonUsualClear.Click += new System.EventHandler(this.buttonUsualClear_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUsualClear);
            this.Controls.Add(this.buttonStandardClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxOutputUsual);
            this.Controls.Add(this.richTextBoxOutputStandard);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.RichTextBox richTextBoxOutputStandard;
        private System.Windows.Forms.RichTextBox richTextBoxOutputUsual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStandardClear;
        private System.Windows.Forms.Button buttonUsualClear;
    }
}