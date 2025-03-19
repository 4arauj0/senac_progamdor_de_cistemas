namespace Cadastro_cliente
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
            btn_cadastrar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            lbl_genero = new Label();
            lbl_nascimento = new Label();
            lbl_estrangeiro = new Label();
            lbl_etnia = new Label();
            lbl_nomesocial = new Label();
            lbl_numero = new Label();
            lbl_email = new Label();
            lbl_nome = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            textBox1 = new TextBox();
            msk_numero = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            checkBox1 = new CheckBox();
            checkBox3 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.Black;
            btn_cadastrar.Font = new Font("Stencil", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cadastrar.ForeColor = SystemColors.ButtonHighlight;
            btn_cadastrar.Location = new Point(355, 318);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(118, 32);
            btn_cadastrar.TabIndex = 0;
            btn_cadastrar.Text = "cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(msk_numero);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lbl_nome);
            groupBox1.Controls.Add(lbl_email);
            groupBox1.Controls.Add(lbl_numero);
            groupBox1.Controls.Add(lbl_nomesocial);
            groupBox1.Controls.Add(lbl_etnia);
            groupBox1.Controls.Add(lbl_estrangeiro);
            groupBox1.Controls.Add(lbl_nascimento);
            groupBox1.Controls.Add(lbl_genero);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 290);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(473, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 290);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ImageKey = "(nenhum)";
            label2.Location = new Point(133, 9);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(106, 24);
            label2.TabIndex = 4;
            label2.Text = "CADASTRO";
            // 
            // lbl_genero
            // 
            lbl_genero.AutoSize = true;
            lbl_genero.Location = new Point(22, 120);
            lbl_genero.Name = "lbl_genero";
            lbl_genero.Size = new Size(45, 15);
            lbl_genero.TabIndex = 5;
            lbl_genero.Text = "Genero";
            // 
            // lbl_nascimento
            // 
            lbl_nascimento.AutoSize = true;
            lbl_nascimento.Location = new Point(2, 86);
            lbl_nascimento.Name = "lbl_nascimento";
            lbl_nascimento.Size = new Size(66, 15);
            lbl_nascimento.TabIndex = 6;
            lbl_nascimento.Text = "Nacimento";
            // 
            // lbl_estrangeiro
            // 
            lbl_estrangeiro.AutoSize = true;
            lbl_estrangeiro.Location = new Point(0, 196);
            lbl_estrangeiro.Name = "lbl_estrangeiro";
            lbl_estrangeiro.Size = new Size(66, 15);
            lbl_estrangeiro.TabIndex = 7;
            lbl_estrangeiro.Text = "Estrangeiro";
            // 
            // lbl_etnia
            // 
            lbl_etnia.AutoSize = true;
            lbl_etnia.Location = new Point(33, 163);
            lbl_etnia.Name = "lbl_etnia";
            lbl_etnia.Size = new Size(33, 15);
            lbl_etnia.TabIndex = 8;
            lbl_etnia.Text = "Etnia";
            // 
            // lbl_nomesocial
            // 
            lbl_nomesocial.AutoSize = true;
            lbl_nomesocial.Location = new Point(172, 47);
            lbl_nomesocial.Name = "lbl_nomesocial";
            lbl_nomesocial.Size = new Size(73, 15);
            lbl_nomesocial.TabIndex = 9;
            lbl_nomesocial.Text = "Nome social";
            // 
            // lbl_numero
            // 
            lbl_numero.AutoSize = true;
            lbl_numero.Location = new Point(172, 86);
            lbl_numero.Name = "lbl_numero";
            lbl_numero.Size = new Size(51, 15);
            lbl_numero.TabIndex = 10;
            lbl_numero.Text = "Numero";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(172, 120);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(41, 15);
            lbl_email.TabIndex = 11;
            lbl_email.Text = "E-mail";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(28, 47);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(40, 15);
            lbl_nome.TabIndex = 12;
            lbl_nome.Text = "Nome";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 133);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 11;
            label11.Text = "label11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 101);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 12;
            label12.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 68);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 13;
            label13.Text = "label13";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(19, 33);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 14;
            label14.Text = "label14";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(19, 213);
            label15.Name = "label15";
            label15.Size = new Size(44, 15);
            label15.TabIndex = 15;
            label15.Text = "label15";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(19, 171);
            label16.Name = "label16";
            label16.Size = new Size(44, 15);
            label16.TabIndex = 16;
            label16.Text = "label16";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 23);
            textBox1.TabIndex = 3;
            // 
            // msk_numero
            // 
            msk_numero.Location = new Point(223, 83);
            msk_numero.Mask = "(00)00000-000";
            msk_numero.Name = "msk_numero";
            msk_numero.Size = new Size(114, 23);
            msk_numero.TabIndex = 13;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(70, 83);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(94, 23);
            maskedTextBox2.TabIndex = 14;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // textBox3
            // 
            textBox3.Location = new Point(251, 44);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(86, 23);
            textBox3.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ImageKey = "(nenhum)";
            label4.Location = new Point(142, 9);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(62, 18);
            label4.TabIndex = 16;
            label4.Text = "cliente";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "masculino", "femenino", "não binario\t\t\t" });
            comboBox1.Location = new Point(69, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(55, 23);
            comboBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(223, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 23);
            textBox2.TabIndex = 18;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "masculino", "femenino", "não binario\t\t\t" });
            comboBox2.Location = new Point(69, 160);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(55, 23);
            comboBox2.TabIndex = 19;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(69, 195);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(46, 19);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "Sim";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(121, 195);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(48, 19);
            checkBox3.TabIndex = 22;
            checkBox3.Text = "Não";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(206, 194);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(52, 19);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "fisica";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(264, 196);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(64, 19);
            radioButton2.TabIndex = 24;
            radioButton2.TabStop = true;
            radioButton2.Text = "juridica";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 168);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 25;
            label3.Text = "pessoa";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(69, 30);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(69, 64);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(69, 98);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(69, 130);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 20;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(69, 168);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 21;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(69, 210);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(794, 450);
            Controls.Add(groupBox2);
            Controls.Add(btn_cadastrar);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cadastrar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lbl_nome;
        private Label lbl_email;
        private Label lbl_numero;
        private Label lbl_nomesocial;
        private Label lbl_etnia;
        private Label lbl_estrangeiro;
        private Label lbl_nascimento;
        private Label lbl_genero;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox msk_numero;
        private TextBox textBox1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private CheckBox checkBox1;
        private Label label3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckBox checkBox3;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
    }
}