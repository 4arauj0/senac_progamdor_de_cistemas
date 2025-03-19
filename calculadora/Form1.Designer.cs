namespace calculadora
{
    partial class Form1
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
            lbl_diametro = new Label();
            lbl_area = new Label();
            lbl_perimetro = new Label();
            lbl_volume = new Label();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            lbl_largura = new Label();
            lbl_altura = new Label();
            lbl_comprimento = new Label();
            lbl_resulatdo = new Label();
            groupBox3 = new GroupBox();
            rdb_perimetro = new RadioButton();
            rdb_area = new RadioButton();
            rdb_volume = new RadioButton();
            btn_calcula = new Button();
            rdb_divisao = new RadioButton();
            rdb_adicao = new RadioButton();
            rdb_multiplicacao = new RadioButton();
            rdb_subtracao = new RadioButton();
            btn_calcular = new Button();
            txb_calculo1 = new TextBox();
            txb_calculo2 = new TextBox();
            lbl_contas = new Label();
            txb_resultado = new TextBox();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lbl_raio = new Label();
            lbl_resultado = new Label();
            rdb_volumi = new RadioButton();
            rdb_aria = new RadioButton();
            rdb_perimetru = new RadioButton();
            rdb_diametro = new RadioButton();
            button2 = new Button();
            txb_raio = new TextBox();
            txb_result = new TextBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_diametro
            // 
            lbl_diametro.AutoSize = true;
            lbl_diametro.Location = new Point(503, 124);
            lbl_diametro.Name = "lbl_diametro";
            lbl_diametro.Size = new Size(55, 15);
            lbl_diametro.TabIndex = 5;
            lbl_diametro.Text = "diametro";
            // 
            // lbl_area
            // 
            lbl_area.AutoSize = true;
            lbl_area.Location = new Point(503, 140);
            lbl_area.Name = "lbl_area";
            lbl_area.Size = new Size(29, 15);
            lbl_area.TabIndex = 6;
            lbl_area.Text = "area";
            // 
            // lbl_perimetro
            // 
            lbl_perimetro.AutoSize = true;
            lbl_perimetro.Location = new Point(503, 155);
            lbl_perimetro.Name = "lbl_perimetro";
            lbl_perimetro.Size = new Size(59, 15);
            lbl_perimetro.TabIndex = 7;
            lbl_perimetro.Text = "perimetro";
            // 
            // lbl_volume
            // 
            lbl_volume.AutoSize = true;
            lbl_volume.Location = new Point(503, 169);
            lbl_volume.Name = "lbl_volume";
            lbl_volume.Size = new Size(47, 15);
            lbl_volume.TabIndex = 8;
            lbl_volume.Text = "volume";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "circulo", "quadrado", "retangulo" });
            comboBox1.Location = new Point(179, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_calcula);
            groupBox2.Controls.Add(rdb_volume);
            groupBox2.Controls.Add(rdb_area);
            groupBox2.Controls.Add(rdb_perimetro);
            groupBox2.Controls.Add(lbl_resulatdo);
            groupBox2.Controls.Add(lbl_comprimento);
            groupBox2.Controls.Add(lbl_altura);
            groupBox2.Controls.Add(lbl_largura);
            groupBox2.Location = new Point(179, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 156);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // lbl_largura
            // 
            lbl_largura.AutoSize = true;
            lbl_largura.Location = new Point(6, 26);
            lbl_largura.Name = "lbl_largura";
            lbl_largura.Size = new Size(44, 15);
            lbl_largura.TabIndex = 0;
            lbl_largura.Text = "largura";
            // 
            // lbl_altura
            // 
            lbl_altura.AutoSize = true;
            lbl_altura.Location = new Point(6, 58);
            lbl_altura.Name = "lbl_altura";
            lbl_altura.Size = new Size(37, 15);
            lbl_altura.TabIndex = 1;
            lbl_altura.Text = "altura";
            // 
            // lbl_comprimento
            // 
            lbl_comprimento.AutoSize = true;
            lbl_comprimento.Location = new Point(6, 87);
            lbl_comprimento.Name = "lbl_comprimento";
            lbl_comprimento.Size = new Size(80, 15);
            lbl_comprimento.TabIndex = 2;
            lbl_comprimento.Text = "comprimento";
            // 
            // lbl_resulatdo
            // 
            lbl_resulatdo.AutoSize = true;
            lbl_resulatdo.Location = new Point(6, 124);
            lbl_resulatdo.Name = "lbl_resulatdo";
            lbl_resulatdo.Size = new Size(56, 15);
            lbl_resulatdo.TabIndex = 3;
            lbl_resulatdo.Text = "resultado";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txb_result);
            groupBox3.Controls.Add(txb_raio);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(rdb_diametro);
            groupBox3.Controls.Add(rdb_volumi);
            groupBox3.Controls.Add(rdb_aria);
            groupBox3.Controls.Add(rdb_perimetru);
            groupBox3.Controls.Add(lbl_resultado);
            groupBox3.Controls.Add(lbl_raio);
            groupBox3.Location = new Point(12, 243);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 156);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // rdb_perimetro
            // 
            rdb_perimetro.AutoSize = true;
            rdb_perimetro.Location = new Point(111, 22);
            rdb_perimetro.Name = "rdb_perimetro";
            rdb_perimetro.Size = new Size(77, 19);
            rdb_perimetro.TabIndex = 4;
            rdb_perimetro.TabStop = true;
            rdb_perimetro.Text = "perimetro";
            rdb_perimetro.UseVisualStyleBackColor = true;
            // 
            // rdb_area
            // 
            rdb_area.AutoSize = true;
            rdb_area.Location = new Point(111, 47);
            rdb_area.Name = "rdb_area";
            rdb_area.Size = new Size(47, 19);
            rdb_area.TabIndex = 5;
            rdb_area.TabStop = true;
            rdb_area.Text = "area";
            rdb_area.UseVisualStyleBackColor = true;
            // 
            // rdb_volume
            // 
            rdb_volume.AutoSize = true;
            rdb_volume.Location = new Point(111, 72);
            rdb_volume.Name = "rdb_volume";
            rdb_volume.Size = new Size(65, 19);
            rdb_volume.TabIndex = 6;
            rdb_volume.TabStop = true;
            rdb_volume.Text = "volume";
            rdb_volume.UseVisualStyleBackColor = true;
            // 
            // btn_calcula
            // 
            btn_calcula.Location = new Point(219, 26);
            btn_calcula.Name = "btn_calcula";
            btn_calcula.Size = new Size(75, 23);
            btn_calcula.TabIndex = 7;
            btn_calcula.Text = "calcular";
            btn_calcula.UseVisualStyleBackColor = true;
            btn_calcula.Click += btn_calcula_Click;
            // 
            // rdb_divisao
            // 
            rdb_divisao.AutoSize = true;
            rdb_divisao.BackColor = SystemColors.ButtonFace;
            rdb_divisao.Location = new Point(69, 149);
            rdb_divisao.Name = "rdb_divisao";
            rdb_divisao.Size = new Size(30, 19);
            rdb_divisao.TabIndex = 1;
            rdb_divisao.TabStop = true;
            rdb_divisao.Text = "/";
            rdb_divisao.UseVisualStyleBackColor = false;
            rdb_divisao.CheckedChanged += rdb_divisao_CheckedChanged;
            // 
            // rdb_adicao
            // 
            rdb_adicao.AutoSize = true;
            rdb_adicao.BackColor = SystemColors.ButtonFace;
            rdb_adicao.Location = new Point(68, 74);
            rdb_adicao.Name = "rdb_adicao";
            rdb_adicao.Size = new Size(33, 19);
            rdb_adicao.TabIndex = 0;
            rdb_adicao.TabStop = true;
            rdb_adicao.Text = "+";
            rdb_adicao.UseVisualStyleBackColor = false;
            // 
            // rdb_multiplicacao
            // 
            rdb_multiplicacao.AutoSize = true;
            rdb_multiplicacao.BackColor = SystemColors.ButtonFace;
            rdb_multiplicacao.Location = new Point(69, 124);
            rdb_multiplicacao.Name = "rdb_multiplicacao";
            rdb_multiplicacao.Size = new Size(30, 19);
            rdb_multiplicacao.TabIndex = 2;
            rdb_multiplicacao.TabStop = true;
            rdb_multiplicacao.Text = "*";
            rdb_multiplicacao.UseVisualStyleBackColor = false;
            rdb_multiplicacao.CheckedChanged += rdb_multiplicacao_CheckedChanged;
            // 
            // rdb_subtracao
            // 
            rdb_subtracao.AutoSize = true;
            rdb_subtracao.BackColor = SystemColors.ButtonFace;
            rdb_subtracao.Location = new Point(69, 99);
            rdb_subtracao.Name = "rdb_subtracao";
            rdb_subtracao.Size = new Size(30, 19);
            rdb_subtracao.TabIndex = 3;
            rdb_subtracao.TabStop = true;
            rdb_subtracao.Text = "-";
            rdb_subtracao.UseVisualStyleBackColor = false;
            rdb_subtracao.CheckedChanged += rdb_subtracao_CheckedChanged;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(48, 174);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(65, 29);
            btn_calcular.TabIndex = 5;
            btn_calcular.Text = "calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // txb_calculo1
            // 
            txb_calculo1.Location = new Point(13, 16);
            txb_calculo1.Name = "txb_calculo1";
            txb_calculo1.Size = new Size(47, 23);
            txb_calculo1.TabIndex = 6;
            // 
            // txb_calculo2
            // 
            txb_calculo2.Location = new Point(90, 16);
            txb_calculo2.Name = "txb_calculo2";
            txb_calculo2.Size = new Size(47, 23);
            txb_calculo2.TabIndex = 7;
            // 
            // lbl_contas
            // 
            lbl_contas.AutoSize = true;
            lbl_contas.BackColor = SystemColors.ButtonHighlight;
            lbl_contas.Location = new Point(68, 19);
            lbl_contas.Name = "lbl_contas";
            lbl_contas.Size = new Size(16, 15);
            lbl_contas.TabIndex = 4;
            lbl_contas.Text = "   ";
            // 
            // txb_resultado
            // 
            txb_resultado.Enabled = false;
            txb_resultado.Location = new Point(27, 45);
            txb_resultado.Name = "txb_resultado";
            txb_resultado.Size = new Size(100, 23);
            txb_resultado.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(txb_resultado);
            groupBox1.Controls.Add(lbl_contas);
            groupBox1.Controls.Add(txb_calculo2);
            groupBox1.Controls.Add(txb_calculo1);
            groupBox1.Controls.Add(btn_calcular);
            groupBox1.Controls.Add(rdb_subtracao);
            groupBox1.Controls.Add(rdb_multiplicacao);
            groupBox1.Controls.Add(rdb_adicao);
            groupBox1.Controls.Add(rdb_divisao);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(161, 217);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(radioButton1);
            groupBox4.Controls.Add(radioButton2);
            groupBox4.Controls.Add(radioButton3);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(318, 235);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(300, 156);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // button1
            // 
            button1.Location = new Point(219, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "calcular";
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(204, 108);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "volume";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(204, 83);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "area";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(204, 58);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(77, 19);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "perimetro";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 62);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 1;
            label3.Text = "resultado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 30);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 0;
            label4.Text = "lado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // lbl_raio
            // 
            lbl_raio.AutoSize = true;
            lbl_raio.Location = new Point(6, 27);
            lbl_raio.Name = "lbl_raio";
            lbl_raio.Size = new Size(27, 15);
            lbl_raio.TabIndex = 0;
            lbl_raio.Text = "raio";
            lbl_raio.Click += label1_Click;
            // 
            // lbl_resultado
            // 
            lbl_resultado.AutoSize = true;
            lbl_resultado.Location = new Point(6, 58);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(56, 15);
            lbl_resultado.TabIndex = 1;
            lbl_resultado.Text = "resultado";
            // 
            // rdb_volumi
            // 
            rdb_volumi.AutoSize = true;
            rdb_volumi.Location = new Point(137, 103);
            rdb_volumi.Name = "rdb_volumi";
            rdb_volumi.Size = new Size(65, 19);
            rdb_volumi.TabIndex = 10;
            rdb_volumi.TabStop = true;
            rdb_volumi.Text = "volume";
            rdb_volumi.UseVisualStyleBackColor = true;
            rdb_volumi.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // rdb_aria
            // 
            rdb_aria.AutoSize = true;
            rdb_aria.Location = new Point(137, 78);
            rdb_aria.Name = "rdb_aria";
            rdb_aria.Size = new Size(47, 19);
            rdb_aria.TabIndex = 9;
            rdb_aria.TabStop = true;
            rdb_aria.Text = "area";
            rdb_aria.UseVisualStyleBackColor = true;
            // 
            // rdb_perimetru
            // 
            rdb_perimetru.AutoSize = true;
            rdb_perimetru.Location = new Point(137, 53);
            rdb_perimetru.Name = "rdb_perimetru";
            rdb_perimetru.Size = new Size(77, 19);
            rdb_perimetru.TabIndex = 8;
            rdb_perimetru.TabStop = true;
            rdb_perimetru.Text = "perimetro";
            rdb_perimetru.UseVisualStyleBackColor = true;
            // 
            // rdb_diametro
            // 
            rdb_diametro.AutoSize = true;
            rdb_diametro.Location = new Point(137, 27);
            rdb_diametro.Name = "rdb_diametro";
            rdb_diametro.Size = new Size(73, 19);
            rdb_diametro.TabIndex = 11;
            rdb_diametro.TabStop = true;
            rdb_diametro.Text = "diametro";
            rdb_diametro.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(213, 27);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txb_raio
            // 
            txb_raio.Location = new Point(69, 26);
            txb_raio.Name = "txb_raio";
            txb_raio.Size = new Size(59, 23);
            txb_raio.TabIndex = 12;
            // 
            // txb_result
            // 
            txb_result.Location = new Point(67, 55);
            txb_result.Name = "txb_result";
            txb_result.Size = new Size(59, 23);
            txb_result.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(comboBox1);
            Controls.Add(groupBox2);
            Controls.Add(lbl_volume);
            Controls.Add(lbl_perimetro);
            Controls.Add(lbl_area);
            Controls.Add(lbl_diametro);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_diametro;
        private Label lbl_area;
        private Label lbl_perimetro;
        private Label lbl_volume;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private Label lbl_resulatdo;
        private Label lbl_comprimento;
        private Label lbl_altura;
        private Label lbl_largura;
        private Button btn_calcula;
        private RadioButton rdb_volume;
        private RadioButton rdb_area;
        private RadioButton rdb_perimetro;
        private GroupBox groupBox3;
        private RadioButton rdb_divisao;
        private RadioButton rdb_adicao;
        private RadioButton rdb_multiplicacao;
        private RadioButton rdb_subtracao;
        private Button btn_calcular;
        private TextBox txb_calculo1;
        private TextBox txb_calculo2;
        private Label lbl_contas;
        private TextBox txb_resultado;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label3;
        private Label label4;
        private Label lbl_resultado;
        private Label lbl_raio;
        private Button button2;
        private RadioButton rdb_diametro;
        private RadioButton rdb_volumi;
        private RadioButton rdb_aria;
        private RadioButton rdb_perimetru;
        private TextBox txb_result;
        private TextBox txb_raio;
    }
}