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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
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
            label1.Click += label1_Click;
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
            // textBox1
            // 
            textBox1.Location = new Point(449, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(470, 27);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Pink Rose", 16.2F);
            label3.Location = new Point(646, 107);
            label3.Name = "label3";
            label3.Size = new Size(39, 33);
            label3.TabIndex = 3;
            label3.Text = "....";
            // 
            // button1
            // 
            button1.Font = new Font("Pink Rose", 16.2F);
            button1.Location = new Point(552, 185);
            button1.Name = "button1";
            button1.Size = new Size(274, 71);
            button1.TabIndex = 4;
            button1.Text = "Mostrar mensaje";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1340, 561);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label label3;
        private Button button1;
    }
}
