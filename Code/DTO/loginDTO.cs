using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1felipe10.Code.dt
{
    class loginDTO
    {
        private int _id;
        private string _email;
        private string _senha;
        

        public int id { get => _id; set => _id = value; }
        public string email { get => _email; set => _email = value; }
        public string senha { get => _senha; set => _senha = value; }
    }
}
