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
            Console.WriteLine("Digite a quantidade de alunos");
            int qte = Convert.ToInt32(Console.ReadLine());
            double[] notas;
            notas = new double[5];
            for (int i = 1; i <= qte; i++)
            {
                double media = 0;
                string status;
                Console.WriteLine("Digite o nome do aluno: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a Matrícula do aluno:");
                string matricula = Console.ReadLine();
                for (int x = 1; x <= 4; x++)
                {
                    Console.WriteLine("Digite a " + x + " ª nota do aluno: " + nome);
                    notas[x - 1] = Convert.ToDouble(Console.ReadLine());
                    media = media + notas[x - 1];
                }
                media = media / 4;
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
                    Notas = notas[0] + "," + notas[1] + "," + notas[2] + "," + notas[3],
                    Media = media,
                    Status = status
                });
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
