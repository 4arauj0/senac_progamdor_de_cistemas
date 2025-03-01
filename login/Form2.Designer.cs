namespace login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lb_nome = new Label();
            btn_confirmar = new Button();
            txb_name = new TextBox();
            txb_email = new TextBox();
            lb_Email = new Label();
            lb_csenha = new Label();
            txb_cSenha = new TextBox();
            txb_senha = new TextBox();
            lb_senha = new Label();
            label5 = new Label();
            lbl_resultado = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txb_Ncadastro = new TextBox();
            txb_confirmac1 = new TextBox();
            label4 = new Label();
            txb_senhac = new TextBox();
            btn_cadastra = new Button();
            label2 = new Label();
            txb_Ecadastro = new TextBox();
            label3 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lb_nome
            // 
            lb_nome.AutoSize = true;
            lb_nome.Font = new Font("Showcard Gothic", 11.25F);
            lb_nome.ForeColor = SystemColors.ControlLightLight;
            lb_nome.Location = new Point(239, 63);
            lb_nome.Name = "lb_nome";
            lb_nome.Size = new Size(132, 18);
            lb_nome.TabIndex = 0;
            lb_nome.Text = "insira seu nome";
            lb_nome.UseWaitCursor = true;
            // 
            // btn_confirmar
            // 
            btn_confirmar.BackColor = SystemColors.ButtonHighlight;
            btn_confirmar.Font = new Font("Showcard Gothic", 11.25F);
            btn_confirmar.Location = new Point(239, 266);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(90, 37);
            btn_confirmar.TabIndex = 5;
            btn_confirmar.Text = "confirmar";
            btn_confirmar.UseVisualStyleBackColor = false;
            btn_confirmar.UseWaitCursor = true;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // txb_name
            // 
            txb_name.AccessibleName = "txt_nome";
            txb_name.Font = new Font("Showcard Gothic", 11.25F);
            txb_name.Location = new Point(239, 84);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(170, 26);
            txb_name.TabIndex = 1;
            txb_name.UseWaitCursor = true;
            // 
            // txb_email
            // 
            txb_email.AccessibleName = "txt_email";
            txb_email.Font = new Font("Showcard Gothic", 11.25F);
            txb_email.Location = new Point(239, 134);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(170, 26);
            txb_email.TabIndex = 2;
            txb_email.UseWaitCursor = true;
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Font = new Font("Showcard Gothic", 11.25F);
            lb_Email.ForeColor = SystemColors.ControlLightLight;
            lb_Email.Location = new Point(239, 113);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(52, 18);
            lb_Email.TabIndex = 6;
            lb_Email.Text = "email";
            lb_Email.UseWaitCursor = true;
            // 
            // lb_csenha
            // 
            lb_csenha.AutoSize = true;
            lb_csenha.Font = new Font("Showcard Gothic", 11.25F);
            lb_csenha.ForeColor = SystemColors.ControlLightLight;
            lb_csenha.Location = new Point(239, 213);
            lb_csenha.Name = "lb_csenha";
            lb_csenha.Size = new Size(134, 18);
            lb_csenha.TabIndex = 10;
            lb_csenha.Text = "confimar senha";
            lb_csenha.UseWaitCursor = true;
            // 
            // txb_cSenha
            // 
            txb_cSenha.AccessibleName = "txt_cSenha";
            txb_cSenha.Font = new Font("Showcard Gothic", 11.25F);
            txb_cSenha.Location = new Point(239, 234);
            txb_cSenha.Name = "txb_cSenha";
            txb_cSenha.Size = new Size(170, 26);
            txb_cSenha.TabIndex = 4;
            txb_cSenha.UseWaitCursor = true;
            // 
            // txb_senha
            // 
            txb_senha.AccessibleName = "txt_senha";
            txb_senha.Font = new Font("Showcard Gothic", 11.25F);
            txb_senha.Location = new Point(239, 184);
            txb_senha.Name = "txb_senha";
            txb_senha.Size = new Size(170, 26);
            txb_senha.TabIndex = 3;
            txb_senha.UseWaitCursor = true;
            // 
            // lb_senha
            // 
            lb_senha.AutoSize = true;
            lb_senha.Font = new Font("Showcard Gothic", 11.25F);
            lb_senha.ForeColor = SystemColors.ControlLightLight;
            lb_senha.Location = new Point(239, 163);
            lb_senha.Name = "lb_senha";
            lb_senha.Size = new Size(56, 18);
            lb_senha.TabIndex = 7;
            lb_senha.Text = "senha";
            lb_senha.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(259, 25);
            label5.Name = "label5";
            label5.Size = new Size(97, 35);
            label5.TabIndex = 11;
            label5.Text = "login";
            label5.UseWaitCursor = true;
            label5.Click += label5_Click;
            // 
            // lbl_resultado
            // 
            lbl_resultado.AutoSize = true;
            lbl_resultado.BackColor = Color.Violet;
            lbl_resultado.BorderStyle = BorderStyle.Fixed3D;
            lbl_resultado.FlatStyle = FlatStyle.Popup;
            lbl_resultado.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_resultado.ForeColor = SystemColors.ButtonHighlight;
            lbl_resultado.Location = new Point(335, 273);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(164, 22);
            lbl_resultado.TabIndex = 6;
            lbl_resultado.Text = "                                                   ";
            lbl_resultado.UseWaitCursor = true;
            lbl_resultado.Click += lbl_resultado_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1475, 618);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txb_Ncadastro);
            groupBox1.Controls.Add(txb_confirmac1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txb_senhac);
            groupBox1.Controls.Add(btn_cadastra);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txb_Ecadastro);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(505, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(188, 248);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11.25F);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(28, 159);
            label1.Name = "label1";
            label1.Size = new Size(134, 18);
            label1.TabIndex = 23;
            label1.Text = "confimar senha";
            label1.UseWaitCursor = true;
            // 
            // txb_Ncadastro
            // 
            txb_Ncadastro.AccessibleName = "txt_nome";
            txb_Ncadastro.BackColor = Color.Purple;
            txb_Ncadastro.Font = new Font("Showcard Gothic", 11.25F);
            txb_Ncadastro.ForeColor = Color.FromArgb(192, 0, 192);
            txb_Ncadastro.Location = new Point(10, 30);
            txb_Ncadastro.Name = "txb_Ncadastro";
            txb_Ncadastro.Size = new Size(170, 26);
            txb_Ncadastro.TabIndex = 7;
            txb_Ncadastro.UseWaitCursor = true;
            // 
            // txb_confirmac1
            // 
            txb_confirmac1.AccessibleName = "txt_cSenha";
            txb_confirmac1.BackColor = Color.Purple;
            txb_confirmac1.Font = new Font("Showcard Gothic", 11.25F);
            txb_confirmac1.ForeColor = Color.FromArgb(192, 0, 192);
            txb_confirmac1.Location = new Point(10, 180);
            txb_confirmac1.Name = "txb_confirmac1";
            txb_confirmac1.Size = new Size(170, 26);
            txb_confirmac1.TabIndex = 10;
            txb_confirmac1.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 11.25F);
            label4.ForeColor = Color.FromArgb(192, 0, 192);
            label4.Location = new Point(29, 9);
            label4.Name = "label4";
            label4.Size = new Size(132, 18);
            label4.TabIndex = 15;
            label4.Text = "insira seu nome";
            label4.UseWaitCursor = true;
            label4.Click += label4_Click;
            // 
            // txb_senhac
            // 
            txb_senhac.AccessibleName = "txt_senha";
            txb_senhac.BackColor = Color.Purple;
            txb_senhac.Font = new Font("Showcard Gothic", 11.25F);
            txb_senhac.ForeColor = Color.FromArgb(192, 0, 192);
            txb_senhac.Location = new Point(10, 130);
            txb_senhac.Name = "txb_senhac";
            txb_senhac.Size = new Size(170, 26);
            txb_senhac.TabIndex = 9;
            txb_senhac.UseWaitCursor = true;
            // 
            // btn_cadastra
            // 
            btn_cadastra.BackColor = SystemColors.ActiveCaptionText;
            btn_cadastra.Font = new Font("Showcard Gothic", 11.25F);
            btn_cadastra.ForeColor = Color.FromArgb(192, 0, 192);
            btn_cadastra.Location = new Point(51, 210);
            btn_cadastra.Name = "btn_cadastra";
            btn_cadastra.Size = new Size(90, 30);
            btn_cadastra.TabIndex = 11;
            btn_cadastra.Text = "cadastra";
            btn_cadastra.UseVisualStyleBackColor = false;
            btn_cadastra.UseWaitCursor = true;
            btn_cadastra.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 11.25F);
            label2.ForeColor = Color.FromArgb(192, 0, 192);
            label2.Location = new Point(44, 109);
            label2.Name = "label2";
            label2.Size = new Size(102, 18);
            label2.TabIndex = 22;
            label2.Text = "criar senha";
            label2.UseWaitCursor = true;
            // 
            // txb_Ecadastro
            // 
            txb_Ecadastro.AccessibleName = "txt_email";
            txb_Ecadastro.BackColor = Color.Purple;
            txb_Ecadastro.Font = new Font("Showcard Gothic", 11.25F);
            txb_Ecadastro.ForeColor = Color.FromArgb(192, 0, 192);
            txb_Ecadastro.Location = new Point(10, 80);
            txb_Ecadastro.Name = "txb_Ecadastro";
            txb_Ecadastro.Size = new Size(170, 26);
            txb_Ecadastro.TabIndex = 8;
            txb_Ecadastro.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 11.25F);
            label3.ForeColor = Color.FromArgb(192, 0, 192);
            label3.Location = new Point(69, 59);
            label3.Name = "label3";
            label3.Size = new Size(52, 18);
            label3.TabIndex = 21;
            label3.Text = "email";
            label3.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.FlatStyle = FlatStyle.System;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(556, 38);
            label6.Name = "label6";
            label6.Size = new Size(95, 22);
            label6.TabIndex = 15;
            label6.Text = "cadastro";
            label6.UseWaitCursor = true;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Purple;
            ClientSize = new Size(1475, 618);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(lbl_resultado);
            Controls.Add(label5);
            Controls.Add(lb_csenha);
            Controls.Add(txb_cSenha);
            Controls.Add(txb_senha);
            Controls.Add(lb_senha);
            Controls.Add(lb_Email);
            Controls.Add(txb_email);
            Controls.Add(txb_name);
            Controls.Add(btn_confirmar);
            Controls.Add(lb_nome);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "login";
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_nome;
        private Button btn_confirmar;
        private TextBox txb_name;
        private TextBox txb_email;
        private Label lb_Email;
        private Label lb_csenha;
        private TextBox txb_cSenha;
        private TextBox txb_senha;
        private Label lb_senha;
        private Label label5;
        private Label lbl_resultado;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txb_Ncadastro;
        private TextBox txb_confirmac1;
        private Label label4;
        private TextBox txb_senhac;
        private Button btn_cadastra;
        private Label label2;
        private TextBox txb_Ecadastro;
        private Label label3;
        public GroupBox groupBox1;
        private Label label6;
    }
}
