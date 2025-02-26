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
            calendario = new MonthCalendar();
            pictureBox1 = new PictureBox();
            txb_email = new TextBox();
            lb_Email = new Label();
            lb_csenha = new Label();
            txb_cSenha = new TextBox();
            txb_senha = new TextBox();
            lb_senha = new Label();
            label5 = new Label();
            lbl_resultado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lb_nome
            // 
            lb_nome.AutoSize = true;
            lb_nome.Font = new Font("Showcard Gothic", 11.25F);
            lb_nome.ForeColor = SystemColors.ControlLightLight;
            lb_nome.Location = new Point(104, 63);
            lb_nome.Name = "lb_nome";
            lb_nome.Size = new Size(132, 18);
            lb_nome.TabIndex = 0;
            lb_nome.Text = "insira seu nome";
            lb_nome.Click += label1_Click_2;
            // 
            // btn_confirmar
            // 
            btn_confirmar.BackColor = SystemColors.ButtonHighlight;
            btn_confirmar.Font = new Font("Showcard Gothic", 11.25F);
            btn_confirmar.Location = new Point(104, 266);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(90, 37);
            btn_confirmar.TabIndex = 5;
            btn_confirmar.Text = "confirmar";
            btn_confirmar.UseVisualStyleBackColor = false;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // txb_name
            // 
            txb_name.AccessibleName = "txt_nome";
            txb_name.Font = new Font("Showcard Gothic", 11.25F);
            txb_name.Location = new Point(104, 84);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(170, 26);
            txb_name.TabIndex = 1;
            txb_name.TextChanged += txb_name_TextChanged;
            // 
            // calendario
            // 
            calendario.BackColor = SystemColors.InactiveBorder;
            calendario.Enabled = false;
            calendario.Location = new Point(303, 84);
            calendario.Name = "calendario";
            calendario.TabIndex = 3;
            calendario.TitleBackColor = SystemColors.ButtonFace;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1157, 618);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txb_email
            // 
            txb_email.AccessibleName = "txt_email";
            txb_email.Font = new Font("Showcard Gothic", 11.25F);
            txb_email.Location = new Point(104, 134);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(170, 26);
            txb_email.TabIndex = 2;
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Font = new Font("Showcard Gothic", 11.25F);
            lb_Email.ForeColor = SystemColors.ControlLightLight;
            lb_Email.Location = new Point(104, 113);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(52, 18);
            lb_Email.TabIndex = 6;
            lb_Email.Text = "email";
            // 
            // lb_csenha
            // 
            lb_csenha.AutoSize = true;
            lb_csenha.Font = new Font("Showcard Gothic", 11.25F);
            lb_csenha.ForeColor = SystemColors.ControlLightLight;
            lb_csenha.Location = new Point(104, 213);
            lb_csenha.Name = "lb_csenha";
            lb_csenha.Size = new Size(134, 18);
            lb_csenha.TabIndex = 10;
            lb_csenha.Text = "confimar senha";
            // 
            // txb_cSenha
            // 
            txb_cSenha.AccessibleName = "txt_cSenha";
            txb_cSenha.Font = new Font("Showcard Gothic", 11.25F);
            txb_cSenha.Location = new Point(104, 234);
            txb_cSenha.Name = "txb_cSenha";
            txb_cSenha.Size = new Size(170, 26);
            txb_cSenha.TabIndex = 4;
            // 
            // txb_senha
            // 
            txb_senha.AccessibleName = "txt_senha";
            txb_senha.Font = new Font("Showcard Gothic", 11.25F);
            txb_senha.Location = new Point(104, 184);
            txb_senha.Name = "txb_senha";
            txb_senha.Size = new Size(170, 26);
            txb_senha.TabIndex = 3;
            // 
            // lb_senha
            // 
            lb_senha.AutoSize = true;
            lb_senha.Font = new Font("Showcard Gothic", 11.25F);
            lb_senha.ForeColor = SystemColors.ControlLightLight;
            lb_senha.Location = new Point(104, 163);
            lb_senha.Name = "lb_senha";
            lb_senha.Size = new Size(56, 18);
            lb_senha.TabIndex = 7;
            lb_senha.Text = "senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(534, -1);
            label5.Name = "label5";
            label5.Size = new Size(112, 40);
            label5.TabIndex = 11;
            label5.Text = "login";
            label5.Click += label5_Click;
            // 
            // lbl_resultado
            // 
            lbl_resultado.AutoSize = true;
            lbl_resultado.BorderStyle = BorderStyle.Fixed3D;
            lbl_resultado.FlatStyle = FlatStyle.Popup;
            lbl_resultado.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_resultado.ForeColor = SystemColors.ButtonHighlight;
            lbl_resultado.Location = new Point(293, 273);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(221, 22);
            lbl_resultado.TabIndex = 13;
            lbl_resultado.Text = "                                                                      ";
            lbl_resultado.Click += label1_Click_3;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1157, 618);
            Controls.Add(lbl_resultado);
            Controls.Add(label5);
            Controls.Add(lb_csenha);
            Controls.Add(txb_cSenha);
            Controls.Add(txb_senha);
            Controls.Add(lb_senha);
            Controls.Add(lb_Email);
            Controls.Add(txb_email);
            Controls.Add(calendario);
            Controls.Add(txb_name);
            Controls.Add(btn_confirmar);
            Controls.Add(lb_nome);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_nome;
        private Button btn_confirmar;
        private TextBox txb_name;
        private MonthCalendar calendario;
        private PictureBox pictureBox1;
        private TextBox txb_email;
        private Label lb_Email;
        private Label lb_csenha;
        private TextBox txb_cSenha;
        private TextBox txb_senha;
        private Label lb_senha;
        private Label label5;
        private Label lbl_resultado;
    }
}
