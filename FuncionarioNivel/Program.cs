using System;

namespace FuncionarioNivel
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nivel: ");
            int nivel = int.Parse(Console.ReadLine());

            Console.Write("Horas: ");
            double horas = double.Parse(Console.ReadLine());

            Console.Write("Promoção (s/n): ");
            string promocao = Console.ReadLine();

            Funcionario f = new Funcionario(nome, nivel, horas);

            Console.WriteLine("O funcionário {0} trabalhou {1} horas por R$ {2} (Nível {3}) e deve receber R$ {4}",
                              f.GetNome(), f.GetHoras(), f.GetValor(), f.GetNivel(), f.GetSalario());

            if (promocao.ToLower() == "s") // promocao == "s" || promocao == "S"
            {
                f.Promover();

                Console.WriteLine("O funcionário {0} teve promoção, trabalhou {1} horas por R$ {2} (Nível {3}) e o seu novo salário é de R$ {4}",
                                  f.GetNome(), f.GetHoras(), f.GetValor(), f.GetNivel(), f.GetSalario());
            }
        }
    }
}
