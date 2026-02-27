using System.Diagnostics.Eventing.Reader;

namespace Practical_Exercises
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            timer5 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            tmrReloj = new System.Windows.Forms.Timer(components);
            timer6 = new System.Windows.Forms.Timer(components);
            timer7 = new System.Windows.Forms.Timer(components);
            timer8 = new System.Windows.Forms.Timer(components);
            timer9 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Pink Rose", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(603, 284);
            label2.Name = "label2";
            label2.Size = new Size(0, 27);
            label2.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Pink Rose", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 33);
            label1.TabIndex = 0;
            label1.Text = "Rango de Números Primos";
            label1.Click += Label3_Click;
            // 
            // tmrReloj
            // 
            tmrReloj.Interval = 1000;
            // 
            // timer6
            // 
            timer6.Interval = 1000;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(275, 71);
            label3.Name = "label3";
            label3.Size = new Size(0, 36);
            label3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Agency FB", 18F);
            textBox2.Location = new Point(99, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 43);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Agency FB", 18F);
            textBox3.Location = new Point(393, 71);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 43);
            textBox3.TabIndex = 6;
            // 
            // button2
            // 
            button2.Font = new Font("Agency FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(169, 146);
            button2.Name = "button2";
            button2.Size = new Size(270, 44);
            button2.TabIndex = 7;
            button2.Text = "Calcular Numeros Primos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Agency FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(99, 228);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(419, 260);
            listBox2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(650, 565);
            Controls.Add(listBox2);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Jonard";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        public System.Windows.Forms.Timer timer4;
        public System.Windows.Forms.Timer timer5;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private ListBox listBox1;
        private NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Timer timer9;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private ListBox listBox2;
    }
}
