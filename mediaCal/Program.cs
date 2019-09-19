using System;

namespace mediaCal
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;

            Console.Write("Digite a nota 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota 2: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota 3: ");
            n3 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota 4: ");
            n4 = double.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;


            if(media >= 7)
            {
                Console.WriteLine("Sua média:" + media);
                Console.WriteLine("Aprovado");
            }

            else if(media < 7)
            {
                Console.WriteLine("Sua média:" + media);
                Console.WriteLine("Reprovado");

            }
        }
    }
}
