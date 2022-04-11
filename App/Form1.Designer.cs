namespace CFB_Academia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.usuario = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.acesso = new System.Windows.Forms.Label();
            this.lb_acesso = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.PictureBox();
            this.pb_ledlogado = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledlogado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pb_ledlogado);
            this.panel1.Controls.Add(this.usuario);
            this.panel1.Controls.Add(this.lb_usuario);
            this.panel1.Controls.Add(this.acesso);
            this.panel1.Controls.Add(this.lb_acesso);
            this.panel1.Location = new System.Drawing.Point(-2, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 58);
            this.panel1.TabIndex = 0;
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(227, 19);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(15, 16);
            this.usuario.TabIndex = 3;
            this.usuario.Text = "--";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Location = new System.Drawing.Point(173, 19);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(60, 16);
            this.lb_usuario.TabIndex = 2;
            this.lb_usuario.Text = "Usuário: ";
            // 
            // acesso
            // 
            this.acesso.AutoSize = true;
            this.acesso.Location = new System.Drawing.Point(125, 19);
            this.acesso.Name = "acesso";
            this.acesso.Size = new System.Drawing.Size(14, 16);
            this.acesso.TabIndex = 1;
            this.acesso.Text = "0";
            this.acesso.Click += new System.EventHandler(this.acesso_Click);
            // 
            // lb_acesso
            // 
            this.lb_acesso.AutoSize = true;
            this.lb_acesso.Location = new System.Drawing.Point(73, 19);
            this.lb_acesso.Name = "lb_acesso";
            this.lb_acesso.Size = new System.Drawing.Size(56, 16);
            this.lb_acesso.TabIndex = 0;
            this.lb_acesso.Text = "Acesso:";
            // 
            // btn_sair
            // 
            this.btn_sair.BackgroundImage = global::CFB_Academia.Properties.Resources.letra_x;
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.Location = new System.Drawing.Point(888, 12);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(23, 20);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.TabStop = false;
            this.btn_sair.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pb_ledlogado
            // 
            this.pb_ledlogado.BackgroundImage = global::CFB_Academia.Properties.Resources.redbtn;
            this.pb_ledlogado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_ledlogado.Image = global::CFB_Academia.Properties.Resources.redbtn;
            this.pb_ledlogado.Location = new System.Drawing.Point(0, 0);
            this.pb_ledlogado.Name = "pb_ledlogado";
            this.pb_ledlogado.Size = new System.Drawing.Size(67, 58);
            this.pb_ledlogado.TabIndex = 2;
            this.pb_ledlogado.TabStop = false;
            this.pb_ledlogado.Click += new System.EventHandler(this.pb_ledlogado_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(923, 492);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledlogado)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_sair;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label lb_acesso;
        public System.Windows.Forms.Label usuario;
        public System.Windows.Forms.Label acesso;
        public System.Windows.Forms.PictureBox pb_ledlogado;
    }
}

