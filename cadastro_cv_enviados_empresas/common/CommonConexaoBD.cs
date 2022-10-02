using cadastro_cv_enviados_empresas.entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace cadastro_cv_enviados_empresas.common
{
    public class CommonConexaoBD
    {
        private static SQLiteConnection sqliteConnection;

        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=E:\\prog_cad_cv\\banco_de_dados\\curriculo_enviado.db; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        public string AdicionarVaga(EntityVaga entityVaga)
        {
            string resultadoOperacao = string.Empty;

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO vaga(data, descricao, empresa, email, obs) values (@data, @descricao, @empresa, @email, @obs)";
                    cmd.Parameters.AddWithValue("@data", entityVaga.Data);
                    cmd.Parameters.AddWithValue("@descricao", entityVaga.Descricao);
                    cmd.Parameters.AddWithValue("@empresa", entityVaga.Empresa);
                    cmd.Parameters.AddWithValue("@email", entityVaga.Email);
                    cmd.Parameters.AddWithValue("@obs", entityVaga.Obs);
                    cmd.ExecuteNonQuery();
                    resultadoOperacao = ResourceMensagens.GravarSucesso;
                }
            }
            catch (Exception ex)
            {
                resultadoOperacao = ResourceMensagens.GravarFalha;
                resultadoOperacao = resultadoOperacao + "\r\n" + ex.Message;
            }
            return resultadoOperacao;
        }

    }
}
