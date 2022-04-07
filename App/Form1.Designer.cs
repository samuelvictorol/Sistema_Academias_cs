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
            this.pb_ledLogado = new System.Windows.Forms.PictureBox();
            this.lb_acesso = new System.Windows.Forms.Label();
            this.lb_acesso0 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_acesso = new System.Windows.Forms.Label();
            this.acesso = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usuario = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLogado)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lb_acesso0);
            this.panel1.Controls.Add(this.lb_acesso);
            this.panel1.Controls.Add(this.pb_ledLogado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 36);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pb_ledLogado
            // 
            this.pb_ledLogado.Location = new System.Drawing.Point(0, 0);
            this.pb_ledLogado.Name = "pb_ledLogado";
            this.pb_ledLogado.Size = new System.Drawing.Size(57, 46);
            this.pb_ledLogado.TabIndex = 0;
            this.pb_ledLogado.TabStop = false;
            // 
            // lb_acesso
            // 
            this.lb_acesso.AutoSize = true;
            this.lb_acesso.Location = new System.Drawing.Point(63, 12);
            this.lb_acesso.Name = "lb_acesso";
            this.lb_acesso.Size = new System.Drawing.Size(56, 16);
            this.lb_acesso.TabIndex = 1;
            this.lb_acesso.Text = "Acesso:";
            // 
            // lb_acesso0
            // 
            this.lb_acesso0.AutoSize = true;
            this.lb_acesso0.Location = new System.Drawing.Point(125, 12);
            this.lb_acesso0.Name = "lb_acesso0";
            this.lb_acesso0.Size = new System.Drawing.Size(14, 16);
            this.lb_acesso0.TabIndex = 2;
            this.lb_acesso0.Text = "0";
            this.lb_acesso0.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lb_usuario);
            this.panel2.Controls.Add(this.usuario);
            this.panel2.Controls.Add(this.label_acesso);
            this.panel2.Controls.Add(this.acesso);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 36);
            this.panel2.TabIndex = 3;
            // 
            // label_acesso
            // 
            this.label_acesso.AutoSize = true;
            this.label_acesso.Location = new System.Drawing.Point(105, 12);
            this.label_acesso.Name = "label_acesso";
            this.label_acesso.Size = new System.Drawing.Size(14, 16);
            this.label_acesso.TabIndex = 2;
            this.label_acesso.Text = "0";
            // 
            // acesso
            // 
            this.acesso.AutoSize = true;
            this.acesso.Location = new System.Drawing.Point(46, 12);
            this.acesso.Name = "acesso";
            this.acesso.Size = new System.Drawing.Size(56, 16);
            this.acesso.TabIndex = 1;
            this.acesso.Text = "Acesso:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::CFB_Academia.Properties.Resources.redbtn;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(145, 12);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(60, 16);
            this.usuario.TabIndex = 3;
            this.usuario.Text = "Usuário: ";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Location = new System.Drawing.Point(211, 12);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(19, 16);
            this.lb_usuario.TabIndex = 4;
            this.lb_usuario.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia X - v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLogado)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pb_ledLogado;
        private System.Windows.Forms.Label lb_acesso;
        private System.Windows.Forms.Label lb_acesso0;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label label_acesso;
        private System.Windows.Forms.Label acesso;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

