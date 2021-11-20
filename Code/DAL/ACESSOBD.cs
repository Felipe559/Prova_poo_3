using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1felipe10.Code.DAL
{
    class ACESSOBD
    {
        MySqlConnection conexao;
        
        public void conectar()
        {
            try
            {
                string conn = "Persist Security info = false;" +
                                "Server = localhost;" +
                                "database = 3c1felipe10;" +
                                "uid = root; pwd=root";
                conexao = new MySqlConnection(conn);
                conexao.Open();            
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possivel conectar ao banco.n" + ex.Message);
            }
        }

        internal object ExecutarComando(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
