using System;

namespace Backend_NotasDosAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Olá, vamos calcular as notas dos alunos da escola SENAI!");
            Console.WriteLine("--------------------------------------------------------");

            string[] nomes = new string [2];
            float[] nota_matematica = new float [4];
            float[] nota_portugues = new float [4];
            float[] nota_quimica = new float [4];
            float[] nota_fisica = new float [4];
            float[] mediaunica = new float [2];
            float[] mediageral = new float [2];

            for(int i = 0; i < 2; i++){
                Console.WriteLine("Digite o nome do aluno:");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Digite a nota de matemática do aluno:");
                nota_matematica[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Digite a nota de português do aluno:");
                nota_portugues[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Digite a nota de química do aluno:");
                nota_quimica[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Digite a nota de física do aluno:");
                nota_fisica[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("");

                mediaunica[i] = (nota_matematica[i] + nota_portugues[i] + nota_quimica[i] + nota_fisica[i]) / 4;

                // mediageral[i] = (mediaunica[i] + mediaunica[i]) / 2;
            }

            Console.WriteLine("Os alunos têm as respectivas notas:");
            for(var i = 0; i < 2; i++){
                Console.WriteLine($"O aluno {nomes[i]} possui a média = {mediaunica[i]}");
            }
            
            Console.WriteLine("");
            Console.WriteLine("Os alunos que passaram de ano foram:");

            for(int i = 0; i < 2; i++){
                if(mediaunica[i] >= 7){
                    Console.WriteLine($"{nomes[i]} com a média alta de {mediaunica[i]} passou!");
                }else{
                    Console.WriteLine("");
                    Console.WriteLine("Os alunos que reprovaram de ano foram:");
                    Console.WriteLine($"{nomes[i]} com a média baixa de {mediaunica[i]} reprovou!");
                }
            }

            for(int i = 0; i < 1; i++){
                mediageral[i] = mediaunica[i] + mediaunica[i] / 2;
                Console.WriteLine("");
                Console.WriteLine($"A média geral da turma é {mediageral[i]}");
            }
        }
    }
}
