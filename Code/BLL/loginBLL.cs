using _3C1felipe10.Code.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1felipe10.Code.BLL
{
    class loginBLL
    {
        ACESSOBD conexao = new ACESSOBD();
        string tabela = "tbl_login";

        public bool RealizarLogin(LoginDTO login)
        {
            string sql = $"select * from {tabela} where email='{login.email}' and senha='{login.senha}'";
            _ = conexao.ExecutarComando(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

    }
}
