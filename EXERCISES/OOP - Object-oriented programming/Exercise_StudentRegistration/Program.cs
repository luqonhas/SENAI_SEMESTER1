using System;
using Exercise_StudentRegistration.Class;

namespace Backend_CadastroAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();
            Console.Write("Digite o nome do aluno: ");
            aluno1.nome = Console.ReadLine();

            Console.Write("Digite a idade do aluno: ");
            aluno1.idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o curso do aluno: ");
            aluno1.curso = Console.ReadLine();

            Console.Write("Digite o RG do aluno: ");
            aluno1.rg = Console.ReadLine();
            
            Console.Write("Digite a média do aluno: ");
            aluno1.media = double.Parse(Console.ReadLine());

            Console.Write("Digite a mensalidade do curso do aluno: ");
            aluno1.mensalidade = double.Parse(Console.ReadLine());
            
            Console.Write("O aluno é bolsista? 's/n': ");
            string sobrebolsista = Console.ReadLine();
            
            if(sobrebolsista == "s" || sobrebolsista == "S"){
                aluno1.bolsista = true;
            }else if(sobrebolsista == "n" || sobrebolsista == "N"){
                aluno1.bolsista = false;
            }

            Console.WriteLine("");
            Console.WriteLine("Informações coletadas:");
            Console.WriteLine("");
            Console.WriteLine(aluno1.nome);
            Console.WriteLine(aluno1.idade);
            Console.WriteLine(aluno1.curso);
            Console.WriteLine(aluno1.rg);
            aluno1.VerMediaFinal(aluno1.media);
            aluno1.VerMensalidade(aluno1.mensalidade, aluno1.bolsista);
        }
    }
}
