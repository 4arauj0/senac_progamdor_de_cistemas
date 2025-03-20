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
            label3 = new Label();
            rdb_juridica = new RadioButton();
            rdb_fisica = new RadioButton();
            ckb_sim = new CheckBox();
            cmb_etnia = new ComboBox();
            txb_email = new TextBox();
            cmb_genero = new ComboBox();
            label4 = new Label();
            txb_nomesocial = new TextBox();
            msk_nascimento = new MaskedTextBox();
            msk_numero = new MaskedTextBox();
            txb_nome = new TextBox();
            lbl_nome = new Label();
            lbl_email = new Label();
            lbl_numero = new Label();
            lbl_nomesocial = new Label();
            lbl_etnia = new Label();
            lbl_estrangeiro = new Label();
            lbl_nascimento = new Label();
            lbl_genero = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            cmb_estado = new ComboBox();
            label5 = new Label();
            txb_cep = new TextBox();
            txb_municipio = new TextBox();
            txb_bairro = new TextBox();
            txb_complemento = new TextBox();
            txb_numero = new TextBox();
            txb_lagradouro = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label1 = new Label();
            label2 = new Label();
            cadastrou = new Label();
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
            groupBox1.Controls.Add(rdb_juridica);
            groupBox1.Controls.Add(rdb_fisica);
            groupBox1.Controls.Add(ckb_sim);
            groupBox1.Controls.Add(cmb_etnia);
            groupBox1.Controls.Add(txb_email);
            groupBox1.Controls.Add(cmb_genero);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txb_nomesocial);
            groupBox1.Controls.Add(msk_nascimento);
            groupBox1.Controls.Add(msk_numero);
            groupBox1.Controls.Add(txb_nome);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 196);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 25;
            label3.Text = "pessoa";
            // 
            // rdb_juridica
            // 
            rdb_juridica.AutoSize = true;
            rdb_juridica.Location = new Point(264, 195);
            rdb_juridica.Name = "rdb_juridica";
            rdb_juridica.Size = new Size(64, 19);
            rdb_juridica.TabIndex = 10;
            rdb_juridica.TabStop = true;
            rdb_juridica.Text = "juridica";
            rdb_juridica.UseVisualStyleBackColor = true;
            // 
            // rdb_fisica
            // 
            rdb_fisica.AutoSize = true;
            rdb_fisica.Location = new Point(193, 194);
            rdb_fisica.Name = "rdb_fisica";
            rdb_fisica.Size = new Size(52, 19);
            rdb_fisica.TabIndex = 9;
            rdb_fisica.TabStop = true;
            rdb_fisica.Text = "fisica";
            rdb_fisica.UseVisualStyleBackColor = true;
            // 
            // ckb_sim
            // 
            ckb_sim.AutoSize = true;
            ckb_sim.Location = new Point(69, 195);
            ckb_sim.Name = "ckb_sim";
            ckb_sim.Size = new Size(46, 19);
            ckb_sim.TabIndex = 8;
            ckb_sim.Text = "Sim";
            ckb_sim.UseVisualStyleBackColor = true;
            // 
            // cmb_etnia
            // 
            cmb_etnia.FormattingEnabled = true;
            cmb_etnia.Items.AddRange(new object[] { "masculino", "femenino", "não binario\t\t\t" });
            cmb_etnia.Location = new Point(69, 160);
            cmb_etnia.Name = "cmb_etnia";
            cmb_etnia.Size = new Size(55, 23);
            cmb_etnia.TabIndex = 7;
            // 
            // txb_email
            // 
            txb_email.Location = new Point(223, 117);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(114, 23);
            txb_email.TabIndex = 6;
            // 
            // cmb_genero
            // 
            cmb_genero.FormattingEnabled = true;
            cmb_genero.Items.AddRange(new object[] { "masculino", "femenino", "não binario\t\t\t" });
            cmb_genero.Location = new Point(69, 117);
            cmb_genero.Name = "cmb_genero";
            cmb_genero.Size = new Size(55, 23);
            cmb_genero.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ImageKey = "(nenhum)";
            label4.Location = new Point(139, 11);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(62, 18);
            label4.TabIndex = 16;
            label4.Text = "cliente";
            // 
            // txb_nomesocial
            // 
            txb_nomesocial.Location = new Point(251, 44);
            txb_nomesocial.Name = "txb_nomesocial";
            txb_nomesocial.Size = new Size(86, 23);
            txb_nomesocial.TabIndex = 2;
            // 
            // msk_nascimento
            // 
            msk_nascimento.Location = new Point(70, 83);
            msk_nascimento.Mask = "00/00/0000";
            msk_nascimento.Name = "msk_nascimento";
            msk_nascimento.Size = new Size(94, 23);
            msk_nascimento.TabIndex = 3;
            msk_nascimento.ValidatingType = typeof(DateTime);
            // 
            // msk_numero
            // 
            msk_numero.Location = new Point(223, 83);
            msk_numero.Mask = "(00)00000-000";
            msk_numero.Name = "msk_numero";
            msk_numero.Size = new Size(114, 23);
            msk_numero.TabIndex = 4;
            // 
            // txb_nome
            // 
            txb_nome.Location = new Point(70, 44);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(94, 23);
            txb_nome.TabIndex = 1;
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
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(172, 120);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(41, 15);
            lbl_email.TabIndex = 11;
            lbl_email.Text = "E-mail";
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
            // lbl_nomesocial
            // 
            lbl_nomesocial.AutoSize = true;
            lbl_nomesocial.Location = new Point(172, 47);
            lbl_nomesocial.Name = "lbl_nomesocial";
            lbl_nomesocial.Size = new Size(73, 15);
            lbl_nomesocial.TabIndex = 9;
            lbl_nomesocial.Text = "Nome social";
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
            // lbl_estrangeiro
            // 
            lbl_estrangeiro.AutoSize = true;
            lbl_estrangeiro.Location = new Point(0, 196);
            lbl_estrangeiro.Name = "lbl_estrangeiro";
            lbl_estrangeiro.Size = new Size(66, 15);
            lbl_estrangeiro.TabIndex = 7;
            lbl_estrangeiro.Text = "Estrangeiro";
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
            // lbl_genero
            // 
            lbl_genero.AutoSize = true;
            lbl_genero.Location = new Point(22, 120);
            lbl_genero.Name = "lbl_genero";
            lbl_genero.Size = new Size(45, 15);
            lbl_genero.TabIndex = 5;
            lbl_genero.Text = "Genero";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cmb_estado);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txb_cep);
            groupBox2.Controls.Add(txb_municipio);
            groupBox2.Controls.Add(txb_bairro);
            groupBox2.Controls.Add(txb_complemento);
            groupBox2.Controls.Add(txb_numero);
            groupBox2.Controls.Add(txb_lagradouro);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(473, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 290);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 255);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 28;
            label6.Text = "estado";
            // 
            // cmb_estado
            // 
            cmb_estado.FormattingEnabled = true;
            cmb_estado.Location = new Point(140, 252);
            cmb_estado.Name = "cmb_estado";
            cmb_estado.Size = new Size(100, 23);
            cmb_estado.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ImageKey = "(nenhum)";
            label5.Location = new Point(105, 11);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(75, 18);
            label5.TabIndex = 26;
            label5.Text = "endereço";
            // 
            // txb_cep
            // 
            txb_cep.Location = new Point(140, 213);
            txb_cep.Name = "txb_cep";
            txb_cep.Size = new Size(100, 23);
            txb_cep.TabIndex = 22;
            // 
            // txb_municipio
            // 
            txb_municipio.Location = new Point(140, 171);
            txb_municipio.Name = "txb_municipio";
            txb_municipio.Size = new Size(100, 23);
            txb_municipio.TabIndex = 21;
            // 
            // txb_bairro
            // 
            txb_bairro.Location = new Point(140, 133);
            txb_bairro.Name = "txb_bairro";
            txb_bairro.Size = new Size(100, 23);
            txb_bairro.TabIndex = 20;
            // 
            // txb_complemento
            // 
            txb_complemento.Location = new Point(140, 101);
            txb_complemento.Name = "txb_complemento";
            txb_complemento.Size = new Size(100, 23);
            txb_complemento.TabIndex = 19;
            // 
            // txb_numero
            // 
            txb_numero.Location = new Point(140, 67);
            txb_numero.Name = "txb_numero";
            txb_numero.Size = new Size(100, 23);
            txb_numero.TabIndex = 18;
            // 
            // txb_lagradouro
            // 
            txb_lagradouro.Location = new Point(140, 33);
            txb_lagradouro.Name = "txb_lagradouro";
            txb_lagradouro.Size = new Size(100, 23);
            txb_lagradouro.TabIndex = 17;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(57, 171);
            label16.Name = "label16";
            label16.Size = new Size(61, 15);
            label16.TabIndex = 16;
            label16.Text = "Municipio";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(90, 213);
            label15.Name = "label15";
            label15.Size = new Size(28, 15);
            label15.TabIndex = 15;
            label15.Text = "Cep";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(49, 33);
            label14.Name = "label14";
            label14.Size = new Size(69, 15);
            label14.TabIndex = 14;
            label14.Text = "Logradouro";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(67, 68);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 13;
            label13.Text = "Numero";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(34, 101);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 12;
            label12.Text = "Complemento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(80, 133);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 11;
            label11.Text = "Bairro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageKey = "(nenhum)";
            label1.Location = new Point(563, 9);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(106, 24);
            label1.TabIndex = 5;
            label1.Text = "CADASTRO";
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
            // cadastrou
            // 
            cadastrou.AutoSize = true;
            cadastrou.BackColor = Color.White;
            cadastrou.Location = new Point(379, 297);
            cadastrou.Name = "cadastrou";
            cadastrou.Size = new Size(70, 15);
            cadastrou.TabIndex = 6;
            cadastrou.Text = "                     ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(794, 450);
            Controls.Add(cadastrou);
            Controls.Add(label1);
            Controls.Add(btn_cadastrar);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Form1";
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
        private MaskedTextBox msk_nascimento;
        private MaskedTextBox msk_numero;
        private TextBox txb_nome;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txb_nomesocial;
        private ComboBox cmb_genero;
        private Label label4;
        private TextBox txb_email;
        private ComboBox cmb_etnia;
        private CheckBox ckb_sim;
        private Label label3;
        private RadioButton rdb_juridica;
        private RadioButton rdb_fisica;
        private TextBox txb_cep;
        private TextBox txb_municipio;
        private TextBox txb_bairro;
        private TextBox txb_complemento;
        private TextBox txb_numero;
        private TextBox txb_lagradouro;
        private Label label1;
        private Label label5;
        private Label label6;
        private ComboBox cmb_estado;
        private Label cadastrou;
    }
}