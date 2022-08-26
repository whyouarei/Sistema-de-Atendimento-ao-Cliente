using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;
using AcessoBanco;

namespace TransferenciaDados
{
    public class UsuariosDTO
    {
        public string nomeusuario { get; set; }
        public string senhausuario { get; set; }
        public string emailusuario { get; set; }
        public int logado { get; set; }
        public string nomecompleto { get; set; }
        public string mensagens { get; set; }
        public string novasenha { get; set; }
        public int codperfil { get; set; }
        public byte[] foto { get; set; }
    }

    public class LoginSistema
    {
        public static string usuario { get; set; }
        public static string nomecompleto { get; set; }
        public static int codperfil { get; set; }
    }

    public class ValidarUsuario
    {
        public void VerificarUsuario(UsuariosDTO dados)
        {
            // Tratamento de exceções
            try
            {
                // Definir comandos para execução
                MySqlCommand cmd = new MySqlCommand("spValidarUsuarios", Conexao.obterConexao());
                // Definir como Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // Parâmetros de entrada (InPut)
                cmd.Parameters.AddWithValue("@pNomeUsuario", dados.nomeusuario);
                cmd.Parameters.AddWithValue("@pSenhaUsuario", dados.senhausuario);

                // Executar os comandos SQL
                MySqlDataReader dr = cmd.ExecuteReader();

                // Verificar a existência de registros
                if (dr.HasRows)
                {
                    // Percorre os registros
                    while (dr.Read())
                    {
                        // Popular com o resultado
                        LoginSistema.usuario = dados.nomeusuario;
                        LoginSistema.nomecompleto = dr.GetValue(2).ToString();
                        dados.logado = Convert.ToInt32(dr.GetValue(1).ToString());
                    }
                }
                dr.Close();
                Conexao.fecharConexao();
            }

            catch (MySqlException e)
            {
                dados.mensagens = "Erro - ValidarUsuario - VerificarUsuario - " + e.Message.ToString();
            }
        }

        public void FinalizarAcesso(UsuariosDTO dados)
        {
            // Tratamento de exceções
            try
            {
                // Definir instruções SQL
                string sql = "update tbusuarios " + "set logado = 1 " + "where nomeusuario = @usuario";

                // Definir comando para execção
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                // Definir como texto
                cmd.CommandType = CommandType.Text;

                // Popular o parâmetro
                cmd.Parameters.Add(new MySqlParameter("@usuario", dados.nomeusuario));

                // Executar os comandos SQL
                int registros = cmd.ExecuteNonQuery();

                if(registros >= 1)
                {
                    dados.mensagens = registros.ToString();

                }
                Conexao.fecharConexao();
            }

            catch (MySqlException e)
            {
                dados.mensagens = "Erro - ValidarUsuario - FinalizarAcesso - " + e.Message.ToString();

            }
        }
    }
}
