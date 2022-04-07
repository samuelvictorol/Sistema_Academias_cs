using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace CFB_Academia
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=C:\\Users\\samue\\OneDrive\\Área de Trabalho\\DEV\\C#\\CFB\\CFB_Academia\\CFB_Academia\\banco");
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    return dt;
                }
            }catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
