namespace calculadora
{
    partial class Form2
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
            txb_calculo1 = new TextBox();
            txb_calculo2 = new TextBox();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            lbl_resultado = new Label();
            button2 = new Button();
            btn_resultado = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txb_calculo1
            // 
            txb_calculo1.Location = new Point(60, 56);
            txb_calculo1.Name = "txb_calculo1";
            txb_calculo1.Size = new Size(100, 23);
            txb_calculo1.TabIndex = 2;
            // 
            // txb_calculo2
            // 
            txb_calculo2.Location = new Point(60, 85);
            txb_calculo2.Name = "txb_calculo2";
            txb_calculo2.Size = new Size(100, 23);
            txb_calculo2.TabIndex = 3;
            txb_calculo2.TextChanged += txb_calculo2_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(lbl_resultado);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btn_resultado);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txb_calculo1);
            groupBox1.Controls.Add(txb_calculo2);
            groupBox1.Location = new Point(276, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 321);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(193, 294);
            button4.Name = "button4";
            button4.Size = new Size(29, 21);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(60, 170);
            button3.Name = "button3";
            button3.Size = new Size(45, 43);
            button3.TabIndex = 6;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lbl_resultado
            // 
            lbl_resultado.AutoSize = true;
            lbl_resultado.BackColor = SystemColors.ActiveCaptionText;
            lbl_resultado.ForeColor = SystemColors.ButtonHighlight;
            lbl_resultado.Location = new Point(60, 216);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(76, 15);
            lbl_resultado.TabIndex = 1;
            lbl_resultado.Text = "                       ";
            lbl_resultado.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(115, 168);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 5;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_resultado
            // 
            btn_resultado.Location = new Point(60, 118);
            btn_resultado.Name = "btn_resultado";
            btn_resultado.Size = new Size(45, 44);
            btn_resultado.TabIndex = 0;
            btn_resultado.Text = "x";
            btn_resultado.UseVisualStyleBackColor = true;
            btn_resultado.Click += btn_resultado_Click;
            // 
            // button1
            // 
            button1.Location = new Point(115, 118);
            button1.Name = "button1";
            button1.Size = new Size(45, 44);
            button1.TabIndex = 4;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txb_calculo1;
        private TextBox txb_calculo2;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Label lbl_resultado;
        private Button button2;
        private Button btn_resultado;
        private Button button1;
    }
}
