using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace ProgramaDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<dynamic> alunos = new List<dynamic>();
            Console.Write("Digite a quantidade de alunos: ");
            int qte = Convert.ToInt32(Console.ReadLine());
            double[] notas;
            notas = new double[5];
            for (int i = 1; i <= qte; i++)
            {
                double media = 0;
                string status;
                Console.Write("Digite o nome do aluno: ");
                string nome = Console.ReadLine();
                Console.Write("Digite a Matrícula do aluno: ");
                string matricula = Console.ReadLine();
                /*for (int x = 1; x <= 4; x++)
                        Console.WriteLine("Digite a " + x + " ª nota do aluno: " + nome);
                       notas[x - 1] = Convert.ToDouble(Console.ReadLine());
                       media = media + notas[x - 1];
                   }*/
                Console.Write("Digite a 1ª nota do aluno " + nome + " ");
                double nota1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a 2ª nota do aluno " + nome + " ");
                double nota2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a 3ª nota do aluno " + nome + " ");
                double nota3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a 4ª nota do aluno " + nome + " ");
                double nota4 = Convert.ToDouble(Console.ReadLine());
                media = (nota1+nota2+nota3+nota4) / 4;
                if (media >= 7)
                {
                    status = "Aprovado";
                }
                else
                {
                    status = "Reprovado";
                }
                alunos.Add(new
                {
                    Nome = nome,
                    Matricula = matricula,
                    //Notas = notas[0] + "," + notas[1] + "," + notas[2] + "," + notas[3],
                    Notas = nota1 + "," + nota2 + "," + nota3 + "," + nota4,
                    Media = media,
                    Status = status
                }); ; ;
                media = 0;
            }
            Console.WriteLine("Segue relação de alunos");
            Console.WriteLine("-----------------------------------");
            {
                for(int i=0; i<alunos.Count; i++)
                {
                     Console.WriteLine("Nome: " + alunos[i].Nome);
                     Console.WriteLine("Matricula: " + alunos[i].Matricula);
                     Console.WriteLine("Notas: " + alunos[i].Notas);
                     Console.WriteLine("Media: " + alunos[i].Media);
                     Console.WriteLine("Status: " + alunos[i].Status);
                     Console.WriteLine("-----------------------------------");
                }
                Console.ReadKey();
                

            }
        }
    }
}
