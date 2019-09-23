using System;

namespace leitorDeIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int born=0;
            int year=2019;
            int age=0;
            
            Console.WriteLine("Digite ano de nascimento do usuário");
            born= int.Parse(Console.ReadLine());

            while(born>=year){
                    Console.WriteLine("O ano de nascimento não pode ser maior ou igual ao ano atual");
                    born= int.Parse(Console.ReadLine());
                }

                age=(year - born) ;

                if(age<=2){
                Console.WriteLine("O usuário é recem-nascido");
            }
            else if(age<=11){
                Console.WriteLine("O usuário é uma criança");
            }
             else if(age<=19){
                Console.WriteLine("O usuário é um adolecente");
            }
             else if(age<=65){
                Console.WriteLine("O usuário é um adulto");
            }
             else if(age>65){
                Console.WriteLine("O usuário é um idoso");
            }

        }
    }
}
