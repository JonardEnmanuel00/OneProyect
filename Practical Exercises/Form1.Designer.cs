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
            Valor = new TextBox();
            Desde = new ComboBox();
            Hacia = new ComboBox();
            button1 = new Button();
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
            label1.Location = new Point(178, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 33);
            label1.TabIndex = 0;
            label1.Text = "Conversor De Unidades";
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
            // timer9
            // 
            timer9.Interval = 100;
            // 
            // Valor
            // 
            Valor.Font = new Font("Agency FB", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Valor.Location = new Point(178, 65);
            Valor.Name = "Valor";
            Valor.Size = new Size(262, 47);
            Valor.TabIndex = 2;
            Valor.TextAlign = HorizontalAlignment.Center;
            // 
            // Desde
            // 
            Desde.FormattingEnabled = true;
            Desde.Items.AddRange(new object[] { "Metros", "Centimetros", "", "", "Pulgadas" });
            Desde.Location = new Point(178, 139);
            Desde.Name = "Desde";
            Desde.Size = new Size(262, 28);
            Desde.TabIndex = 3;
            // 
            // Hacia
            // 
            Hacia.FormattingEnabled = true;
            Hacia.Items.AddRange(new object[] { "Metros", "", "", "Centimetros", "", "", "Pulgadas" });
            Hacia.Location = new Point(178, 192);
            Hacia.Name = "Hacia";
            Hacia.Size = new Size(262, 28);
            Hacia.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Font = new Font("Agency FB", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(253, 240);
            button1.Name = "button1";
            button1.Size = new Size(126, 56);
            button1.TabIndex = 5;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(650, 565);
            Controls.Add(button1);
            Controls.Add(Hacia);
            Controls.Add(Desde);
            Controls.Add(Valor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Z";
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
        private TextBox Valor;
        private ComboBox Desde;
        private ComboBox Hacia;
        private Button button1;
    }
}
