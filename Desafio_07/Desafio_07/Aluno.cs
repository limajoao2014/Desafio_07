using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_07
{
    class Aluno: IAluno
    {
        public void AddAluno() { }

        public int aluno_id { get; set; }
        public string Nome { get; set; }
        public string Nota { get; set; }
    }
}
