using ProjCursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Escola escola = new Escola();
        int opcao;

        do
        {
            Console.WriteLine("\nOpções no seletor:");
            Console.WriteLine("0. Sair");
            Console.WriteLine("1. Adicionar curso");
            Console.WriteLine("2. Pesquisar curso");
            Console.WriteLine("3. Remover curso");
            Console.WriteLine("4. Adicionar disciplina no curso");
            Console.WriteLine("5. Pesquisar disciplina");
            Console.WriteLine("6. Remover disciplina do curso");
            Console.WriteLine("7. Matricular aluno na disciplina");
            Console.WriteLine("8. Remover aluno da disciplina");
            Console.WriteLine("9. Pesquisar aluno");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("ID do curso: ");
                    int idCurso = int.Parse(Console.ReadLine());
                    Console.Write("Descrição do curso: ");
                    string descCurso = Console.ReadLine();
                    if (escola.AdicionarCurso(new Curso(idCurso, descCurso)))
                    {
                        Console.WriteLine("Curso adicionado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível adicionar o curso.");
                    }
                    break;

                case 2:
                    Console.Write("ID do curso para pesquisar: ");
                    int idPesq = int.Parse(Console.ReadLine());
                    var curso = escola.PesquisarCurso(idPesq);
                    if (curso != null)
                    {
                        Console.WriteLine($"Curso encontrado: {curso.Descricao}");
                        foreach (var disc in curso.Disciplinas)
                        {
                            Console.WriteLine($"- Disciplina: {disc.Descricao}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Curso não encontrado.");
                    }
                    break;

                case 3:
                    Console.Write("ID do curso para remover: ");
                    int idRem = int.Parse(Console.ReadLine());
                    var cursoRem = escola.PesquisarCurso(idRem);
                    if (cursoRem != null && escola.RemoverCurso(cursoRem))
                    {
                        Console.WriteLine("Curso removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível remover o curso.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != 0);
    }
}


