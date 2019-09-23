using System;

namespace tabuadaDoUmAoDez
{
    class Program
    {
        static void Main(string[] args)
        {
           // for(int x=0;x<=10;x++){
            //Console.WriteLine("Tabuadas do um ao dez");
           // Console.WriteLine($"{x} x 1= " + (1*x));
           // Console.WriteLine($"{x} x 2= " + (2*x));
           // Console.WriteLine($"{x} x 3= " + (3*x));
           // Console.WriteLine($"{x} x 4= " + (4*x));
           // Console.WriteLine($"{x} x 5= " + (5*x));
           // Console.WriteLine($"{x} x 6= " + (6*x));
            //Console.WriteLine($"{x} x 7= " + (7*x));
           // Console.WriteLine($"{x} x 8= " + (8*x));
           // Console.WriteLine($"{x} x 9= " + (9*x));
           // Console.WriteLine($"{x} x 10= " + (10*x));
           for(int i = 1; i <= 10; i++){
               for(int j =1; j<= 10; j++){
                   Console.Write($"{i,-2} x {j,-2} = {i*j,-3}      ");
               }
               Console.WriteLine();
           }
            }

        }
    }

