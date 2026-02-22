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
            numMinutos = new NumericUpDown();
            numSegundos = new NumericUpDown();
            button1 = new Button();
            tmrReloj = new System.Windows.Forms.Timer(components);
            timer6 = new System.Windows.Forms.Timer(components);
            timer7 = new System.Windows.Forms.Timer(components);
            timer8 = new System.Windows.Forms.Timer(components);
            timer9 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numMinutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSegundos).BeginInit();
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
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Pink Rose", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 9);
            label1.Name = "label1";
            label1.Size = new Size(167, 33);
            label1.TabIndex = 0;
            label1.Text = "Temporizador";
            label1.Click += Label3_Click;
            // 
            // numMinutos
            // 
            numMinutos.Font = new Font("Agency FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numMinutos.Location = new Point(131, 70);
            numMinutos.Name = "numMinutos";
            numMinutos.Size = new Size(150, 39);
            numMinutos.TabIndex = 2;
            numMinutos.TextAlign = HorizontalAlignment.Center;
            // 
            // numSegundos
            // 
            numSegundos.Font = new Font("Agency FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numSegundos.Location = new Point(367, 70);
            numSegundos.Name = "numSegundos";
            numSegundos.Size = new Size(150, 39);
            numSegundos.TabIndex = 3;
            numSegundos.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Agency FB", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(235, 130);
            button1.Name = "button1";
            button1.Size = new Size(167, 54);
            button1.TabIndex = 4;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // tmrReloj
            // 
            tmrReloj.Interval = 1000;
            // 
            // timer6
            // 
            timer6.Interval = 1000;
            // 
            // timer9
            // 
            timer9.Interval = 1000;
            timer9.Tick += timer9_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(650, 565);
            Controls.Add(button1);
            Controls.Add(numSegundos);
            Controls.Add(numMinutos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Z";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numMinutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSegundos).EndInit();
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
        private Button button1;
        private ListBox listBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numSegundos;
        private NumericUpDown numMinutos;
        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Timer timer9;
    }
}
