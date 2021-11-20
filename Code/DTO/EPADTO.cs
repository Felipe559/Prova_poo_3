using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1felipe10.Code.dt
{
    class EPADTO
    {
        private int _id;
        private string _produto;
        private string _preco;

        public int id { get => _id; set => _id = value; }
        public string produto { get => _produto; set => _produto = value; }
        public string preco { get => _preco; set => _preco = value; }
    }
}
