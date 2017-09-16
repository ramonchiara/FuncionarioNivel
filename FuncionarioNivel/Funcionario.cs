using System;
namespace FuncionarioNivel
{
    public class Funcionario
    {
        private string nome;
        private int nivel;
        private double horas;

        public Funcionario(string nome, int nivel, double horas)
        {
            this.nome = nome;
            this.nivel = nivel;
            this.horas = horas;
        }

        public string GetNome()
        {
            return nome;
        }

        public double GetHoras()
        {
            return horas;
        }

        public decimal GetValor()
        {
            decimal valor = 0;

            switch (nivel)
            {
                case 1: valor = 15; break;
                case 2: valor = 18; break;
                case 3: valor = 22; break;
                case 4: valor = 27; break;
                case 5: valor = 33; break;
            }

            return valor;
        }

        public int GetNivel()
        {
            return nivel;
        }

        public decimal GetSalario()
        {
            return Convert.ToDecimal(horas) * GetValor();
        }

        public void Promover()
        {
            if (nivel < 5)
            {
                nivel++;
            }
        }
    }
}
