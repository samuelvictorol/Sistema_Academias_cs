using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFB_Academia
{
    public partial class F_Login : Form
    {
        DataTable dt = new DataTable();
        Form1 f1;
        public F_Login(Form1 f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void lb_usuario_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja mesmo sair", "Academia c#", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em construção....");
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            string username = tb_user.Text;
            string senha = tb_senha.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuario e/ou Senha Invalido");
                tb_user.Focus();
                return;         
            }

            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME='"+username+"' AND T_SENHA='"+senha+"'";
            dt = Banco.consulta(sql);

            if(dt.Rows.Count == 1) {
                f1.pb_ledlogado.Image = Properties.Resources.greenbtn;
                f1.acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                f1.usuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString());
                Globais.logado = true;
                this.Close();
            }else
            {
                MessageBox.Show("Usuário não Encontrado");
            }
        }   
    }
}   
