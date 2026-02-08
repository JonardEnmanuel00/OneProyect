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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Pink Rose", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(331, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 51);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Pink Rose", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(748, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(269, 51);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Font = new Font("Pink Rose", 16.2F);
            button1.Location = new Point(606, 97);
            button1.Name = "button1";
            button1.Size = new Size(136, 62);
            button1.TabIndex = 4;
            button1.Text = "Sumar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Pink Rose", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(606, 185);
            label3.Name = "label3";
            label3.Size = new Size(140, 40);
            label3.TabIndex = 5;
            label3.Text = "Resultado";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1340, 561);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
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
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
    }
}
