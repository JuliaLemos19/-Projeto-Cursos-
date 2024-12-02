using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjCursos.Aluno;

namespace ProjCursos
{
    internal class Disciplina
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public List<Aluno> Alunos { get; private set; }

        public Disciplina(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            Alunos = new List<Aluno>();
        }


        public bool MatricularAluno(Aluno aluno)
        {
            if (Alunos.Count < 15 && aluno.PodeMatricular())
            {
                Alunos.Add(aluno);
                aluno.Disciplinas.Add(this);
                return true;
            }
            return false;
        }

        public bool DesmatricularAluno(Aluno aluno)
        {
            if (Alunos.Remove(aluno))
            {
                aluno.Disciplinas.Remove(this);
                return true;
            }
            return false;
        }
    }
}
    

