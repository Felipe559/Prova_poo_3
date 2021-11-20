using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3C1felipe10.Code.dt;
using _3C1felipe10.Code.DAL;

namespace _3C1felipe10.Code.BLL
{
    class EPABLL
    {
        ACESSOBD conexao = new ACESSOBD();
        string tabela = "tbl_produto";
        private readonly object conexao;

        public void Inserir(produtoDTO prdDto)
        {
            string inserir = $"insert into {tabela} value (null,'{prdDto,produto}','{prdDto.Preco}')";
            conexao.ExecutarComando(inserir);
        }

        public System.LocalDataStoreSlot Table Listar()
        {
            string sql = $"select *from {tabela} order by id;";
            return conexao.ExecutarComando(sql);

            
        }          

        public void Alterar(produtoDTO prdDto)
        {
            string alterar = $"update{tabela} set produto ='{prdDto.produto}' , preco = '{prdDto.preco}' where id = '{prdDto.id}';";
            conexao.ExecutarComando(alterar);
        }
        public void Excluir(produtoDTO prdDto)
        {
            string alterar = $"delete from {tabela} set produto ='{prdDto.produto}' , preco = '{prdDto.preco}' where id = '{prdDto.id}';";
            conexao.ExecutarComando(Excluir);
        }
       
        internal static void inserir(produtoDTO prdDTO)
        {
            throw new NotImplementedException();
        }
    }
    }
}
