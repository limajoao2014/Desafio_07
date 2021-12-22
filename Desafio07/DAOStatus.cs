using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio07
{
    internal class DAOStatus : IDAOBase
    {
        public string Nome { get; set; }
        public bool Cursando { get; set; }

        public void getCursando(string status)
        {
            if (status == "sim")
            {
               Cursando = true; 
            }
            else
            {
                Cursando = false;
            }
        } 
    }
}
