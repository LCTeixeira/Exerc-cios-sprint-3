using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using usandoInterface.Models;
using usandoInterface.Interfaces;

namespace usandoInterface
{
    enum FormacaoEnum : int{
        TRIO = 3,
        QUARTETOS
    };

    enum instrumentosEnum : int {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLAO
    };

    enum CategoriaEnum : int{
        HARMONIA,
        PERCURSAO,
        MELODIA
    };

    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));


            var opcoesFormacao = new List<string>()
            {
                "    -0                          ",
                "    -1                         "
            };
            int opcoesFormacaoSelecionada = 0;
            string menuBar = "=================================";

            do{
                bool formacaoEscolhida = false;

                do{
                    #region Area do menu
                    System.Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("   Seja bem-vindo         ");
                    System.Console.WriteLine("   Escolha uma formação   ");
                    Console.ResetColor();
                    System.Console.WriteLine(menuBar);

                    for(int i =0; i < opcoesFormacao.Count; i++){
                        string titulo = itensMenuPrincipal[i];
                        if (opcoesFormacaoSelecionada != i)
                        {
                            System.Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(), titulo));
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            System.Console.WriteLine(opcoesFormacao[opcoesFormacaoSelecionada].Replace("-", ">").Replace(i.ToString(), titulo));
                            Console.ResetColor();
                        }
                    }

                    var key = Console.ReadKey(true).Key;

                    switch(key){
                        case ConsoleKey.UpArrow:
                        opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == 0? opcoesFormacaoSelecionada : --opcoesFormacaoSelecionada;
                        break;
                        case ConsoleKey.DownArrow:
                        opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcoesFormacaoSelecionada : ++opcoesFormacaoSelecionada;
                        break;
                        case ConsoleKey.Enter:
                        formacaoEscolhida = true;
                        break;
                    }
                    
                }while(!formacaoEscolhida);
                #endregion

                bool bandaCompleta = false;
                int vagas = 0;

                switch (opcoesFormacaoSelecionada){
                    case 0:
                    vagas = 2;
                    do{
                        ExibirMenuDeInstrumentos();
                        Console.Write($"Digite código de instrumento de harmonia: ");
                        int codigo int.Parse(Console.ReadLine());
                        var instrumento = Deposito.Instrumentos[codigo];
                    }
                }
            }while(!querSair);
        }
    }
}
