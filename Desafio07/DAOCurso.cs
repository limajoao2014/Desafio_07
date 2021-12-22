using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio07
{
    internal class DAOCurso : IDAOBase
    {
        public string Nome { get ; set ; }

        public int Periodo { get; set ; }
    }
}
