using System;

namespace separadorDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int X=0;
            Console.WriteLine("Digite qualquer número inteiro");
            X = int.Parse(Console.ReadLine());

            while(X!=0){
                Console.WriteLine("Digite um número");
                X = int.Parse(Console.ReadLine());
            }

            if(X%2==0){
                Console.WriteLine("O número é par");
                }

                else
                {
                    Console.WriteLine("O número é impar");
                }

            
        }
    }
}
