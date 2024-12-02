using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCursos
{
    internal class Aluno
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public List<Disciplina> Disciplinas { get; private set; }

            public Aluno(int id, string nome)
            {
                Id = id;
                Nome = nome;
                Disciplinas = new List<Disciplina>();
            }

            public bool PodeMatricular()
            {
                return Disciplinas.Count < 6;
            }
    }

      

  
}
            