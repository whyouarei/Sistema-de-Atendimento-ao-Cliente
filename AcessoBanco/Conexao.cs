using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Namespace para o MySql
using MySql.Data;
using MySql.Data.MySqlClient;

// Para retornar a string de conexão
using AcessoBanco.Properties;


namespace AcessoBanco
{
    public class Conexao
    {
        // Irá receber as mensagens do MySql
        public static string mensagem = string.Empty;

        // Criar Conexão
        private static string strConn = Settings.Default.strConexao;

        // Representa a conexão com o banco
        private static MySqlConnection conn = null;

        // Método que permite obter a conexão
        public static MySqlConnection obterConexao()
        {
            // Vamos criar a conexão
            // Instanciar

            conn = new MySqlConnection(strConn);

            // Tratamento de exceções

            try
            {
                // Abre conexão e devolve ao chamador do método
                conn.Open();
            }
            catch(MySqlException e){
                // Retorna variável como nulo
                conn = null;
                // Apresentar a mensagem de exceção
                // throw e;
                mensagem = e.Message.ToString();
            }
            return conn;
        }

        public static MySqlConnection fecharConexao()
        {
            // Vamos criar a conexão
            // Instanciar

            conn = new MySqlConnection(strConn);

            // Tratamento de exceções
            try
            {
                conn.Close();
            }
            catch (MySqlException e)
            {
                // Retorna variável com nulo
                conn = null;
                //Apresentar a mensagem de exceção
                // throw e;
                mensagem = e.Message.ToString();
            }
            return conn;
        }
    }
}
