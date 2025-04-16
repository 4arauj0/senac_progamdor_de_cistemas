namespace listas_atividades
{
    partial class ListaDeAtividade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDeAtividade));
            txt_atividade_em_andamento = new TextBox();
            btn_finalizar = new Button();
            dgv_atividade = new DataGridView();
            btn_atualizar = new Button();
            btn_criar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_atividade).BeginInit();
            SuspendLayout();
            // 
            // txt_atividade_em_andamento
            // 
            txt_atividade_em_andamento.Location = new Point(39, 31);
            txt_atividade_em_andamento.Name = "txt_atividade_em_andamento";
            txt_atividade_em_andamento.ReadOnly = true;
            txt_atividade_em_andamento.Size = new Size(407, 23);
            txt_atividade_em_andamento.TabIndex = 0;
            // 
            // btn_finalizar
            // 
            btn_finalizar.Location = new Point(452, 31);
            btn_finalizar.Name = "btn_finalizar";
            btn_finalizar.Size = new Size(75, 23);
            btn_finalizar.TabIndex = 1;
            btn_finalizar.Text = "Finalizar";
            btn_finalizar.UseVisualStyleBackColor = true;
            // 
            // dgv_atividade
            // 
            dgv_atividade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_atividade.Location = new Point(39, 88);
            dgv_atividade.Name = "dgv_atividade";
            dgv_atividade.Size = new Size(407, 307);
            dgv_atividade.TabIndex = 2;
            // 
            // btn_atualizar
            // 
            btn_atualizar.Location = new Point(452, 88);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(75, 23);
            btn_atualizar.TabIndex = 3;
            btn_atualizar.Text = "Atualizar";
            btn_atualizar.UseVisualStyleBackColor = true;
            // 
            // btn_criar
            // 
            btn_criar.Location = new Point(452, 372);
            btn_criar.Name = "btn_criar";
            btn_criar.Size = new Size(75, 23);
            btn_criar.TabIndex = 4;
            btn_criar.Text = "Criar";
            btn_criar.UseVisualStyleBackColor = true;
            // 
            // ListaDeAtividade
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_criar);
            Controls.Add(btn_atualizar);
            Controls.Add(dgv_atividade);
            Controls.Add(btn_finalizar);
            Controls.Add(txt_atividade_em_andamento);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListaDeAtividade";
            Text = "Lista De Atividade";
            Load += ListaDeAtividade_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_atividade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_atividade_em_andamento;
        private Button btn_finalizar;
        private DataGridView dgv_atividade;
        private Button btn_atualizar;
        private Button btn_criar;
    }
}
