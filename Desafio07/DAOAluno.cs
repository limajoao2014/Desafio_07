﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio07
{
    public class DAOAluno : IDAOBase
    {
        public string Nome { get ; set ; }
        public int Idade { get; set ; }
        public double Nota { get; set ; }
    }
}
