namespace CFB_Academia
{
    partial class F_Login
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
            this.lb_usuario = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_logar = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.Location = new System.Drawing.Point(123, 57);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(74, 25);
            this.lb_usuario.TabIndex = 0;
            this.lb_usuario.Text = "Usuário:";
            this.lb_usuario.Click += new System.EventHandler(this.lb_usuario_Click);
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.Location = new System.Drawing.Point(123, 145);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(63, 25);
            this.lb_senha.TabIndex = 1;
            this.lb_senha.Text = "Senha:";
            // 
            // tb_user
            // 
            this.tb_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_user.Location = new System.Drawing.Point(58, 100);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(203, 15);
            this.tb_user.TabIndex = 4;
            this.tb_user.TextChanged += new System.EventHandler(this.tb_user_TextChanged);
            // 
            // tb_senha
            // 
            this.tb_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_senha.Location = new System.Drawing.Point(58, 185);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(203, 15);
            this.tb_senha.TabIndex = 5;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoEllipsis = true;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(58, 288);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(203, 26);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Registre-se";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_logar
            // 
            this.btn_logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.btn_logar.Location = new System.Drawing.Point(58, 242);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(203, 32);
            this.btn_logar.TabIndex = 9;
            this.btn_logar.Text = "z";
            this.btn_logar.UseVisualStyleBackColor = false;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::CFB_Academia.Properties.Resources.letra_x;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_exit.Location = new System.Drawing.Point(290, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(23, 19);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CFB_Academia.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(325, 337);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_usuario);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.TextBox tb_user;
        public System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Panel btn_exit;
        private System.Windows.Forms.Button btn_logar;
    }
}