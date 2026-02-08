
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
            label1 = new Label();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label4 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Pink Rose", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 26);
            label1.Name = "label1";
            label1.Size = new Size(686, 33);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido al formulario de Jonard Enmanuel LR-2024-02135!";
            label1.Click += label3_Click;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Agency FB", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(498, 86);
            label4.Name = "label4";
            label4.Size = new Size(319, 45);
            label4.TabIndex = 10;
            label4.Text = "¡Agrega un nuevo elemento!";
            label4.Click += label4_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Agency FB", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(331, 163);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(686, 102);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Agency FB", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(795, 286);
            button1.Name = "button1";
            button1.Size = new Size(222, 57);
            button1.TabIndex = 12;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Agency FB", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(331, 292);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 51);
            textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1340, 561);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Jonard";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private Label label4;
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
    }
}
