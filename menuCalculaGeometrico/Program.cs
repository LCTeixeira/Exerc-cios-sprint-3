using System;

namespace menuCalculaGeometrico
{
    class Program
    {
        static void Main(string[] args)
        {
            string forma;
            double Baase, baase, altura, lado, area, raio, Diagonal, diagonal;
            Console.WriteLine("Escolha a forma geometrica");
            Console.WriteLine("Digite 1 para Quadrado");
            Console.WriteLine("Digite 2 para Triângulo");
            Console.WriteLine("Digite 3 para Circulo");
            Console.WriteLine("Digite 4 para Trapézio");
            Console.WriteLine("Digite 5 para Retângulo");
            Console.WriteLine("Digite 6 para Losango");
            forma = Console.ReadLine();

            switch(forma)
            {

                case "1":

                Console.WriteLine("Digite o lado do Quadrado");
                lado = double.Parse(Console.ReadLine());
                area = lado * lado;
                Console.WriteLine("Area do Quadrado:"+area);
                break;

                  case "2":
                Console.WriteLine("Digite a base do Triangulo");
                baase = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura do Triangulo");
                altura = double.Parse(Console.ReadLine());
                area = (baase * altura) / 2;
                Console.WriteLine("Area do Triangulo:"+area);
                break;

                  case "3":
                Console.WriteLine("Digite o raio do Circulo");
                raio = double.Parse(Console.ReadLine());
                area = 3.14 * (raio * raio);
                Console.WriteLine("Area do Circulo:"+area);
                break;

                  case "4":
                Console.WriteLine("Digite a base menor do Trapezio");
                baase = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a base maior do Trapezio");
                Baase = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura do Trapezio");
                altura = double.Parse(Console.ReadLine());
                area = altura * (2/(Baase + baase));
                Console.WriteLine("Area do Trapezio:"+area);
                break;

                  case "5":
                Console.WriteLine("Digite a base do Retangulo");
                baase = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura do Retangulo");
                altura = double.Parse(Console.ReadLine());
                area = altura * baase;
                Console.WriteLine("Area do Retangulo:"+area);
                break;

                  case "6":
                Console.WriteLine("Digite a diagonal menor do Losango");
                diagonal = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a diagonal maior do Losango");
                Diagonal = double.Parse(Console.ReadLine());
                area = (Diagonal*diagonal)/2;
                Console.WriteLine("Area do Losango:"+area);
                break;

                case "0":
                Console.WriteLine("Obrigado, volte sempre.");
                break;

                default:
                Console.WriteLine("Selecione uma das opções pedidas");
                break;
            }


        }
    }
}
