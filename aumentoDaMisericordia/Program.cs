using System;

namespace aumentoDaMisericordia
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            Console.WriteLine("Salário:");
            salario = double.Parse(Console.ReadLine());

            if(salario < 500)
            {
                Console.WriteLine(salario * 1.3);
                Console.WriteLine("Aumento Aprovado");
            }

            else if(salario >= 500)
            {
                Console.WriteLine("Aumento Reprovado");
            }
        }
    }
}
