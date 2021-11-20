using _3C1felipe10.Code.dt;
using System;

namespace _3C1felipe10
{
    internal class produtoDTO
    {
        internal static string produto;
        internal static string Preco;
        internal object preco;
        internal object id;

        public static object ID { get; internal set; }
        public static string Produto { get; internal set; }

        public static implicit operator produtoDTO(EPADTO v)
        {
            throw new NotImplementedException();
        }
    }
}