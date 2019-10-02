using System;
using MateODragao.models;

namespace MateODragao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogadorNaoDesistiu = true;
            do
            {



                Console.Clear();
                Console.WriteLine("==============================");
                Console.WriteLine("       Mate o Dragão");
                Console.WriteLine("==============================");

                Console.WriteLine(" 1 - Iniciar Jogo");
                Console.WriteLine(" 0 - Sair do Jogo");

                string opcaoJogador = Console.ReadLine();

                switch (opcaoJogador)
                {
                    case "1":
                        Console.Clear();
                        Guerreiro guerreiro = new Guerreiro();
                        guerreiro.Nome = "Edward";
                        guerreiro.Sobrenome = "Ulric";
                        guerreiro.CidadeNatal = "Grã Bretanha";
                        guerreiro.DataDeNascimento = DateTime.Parse("01/04/1305");
                        guerreiro.FerramentaDeAtaque = "Kriegsmesser";
                        guerreiro.FerramentaDeProteção = "Broquel";
                        guerreiro.Forca = 3;
                        guerreiro.Destreza = 3;
                        guerreiro.Inteligencia = 2;
                        guerreiro.Vida = 20;

                        Dragao dragao = new Dragao();
                        dragao.Nome = "Zamir";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /*INICIO - Primeiro dialogo */
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: {dragao.Nome}, seu louco! Vim-lhe derrotar lhe!");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Humano tolinho quem pensas que es?");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();

                        /*FIM - Primeiro dialogo */
                        /*INICIO - Segundo dialogo */
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}! Da casa {guerreiro.Sobrenome}, ó criatura morfetica.");
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}! vim de {guerreiro.CidadeNatal} para derrotar-te e mostrar meu valor!");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}! QUEM? De ONDE? bom, que seja... fritar-te-ei e comes-te-ei.");
                        System.Console.WriteLine("BAMBAM: Ta na hora do show!");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
                        /*FIM - Segundo dialogo */
                        Console.Clear();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza >= dragao.Destreza ? true : false;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;
                        bool jogadorNaoCorreu = true;
                        if (jogadorAtacaPrimeiro)
                        {
                            System.Console.WriteLine("Turno do jogador");
                            System.Console.WriteLine("Escolha uma ação");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Furgir");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Receba, ser vil.");
                                        dragao.Vida = dragao.Vida - (poderAtaqueGuerreiro + 5);
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Patetico.");
                                    }



                                    break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Simbora Filhao");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: GG EZ");
                                    jogadorNaoCorreu = false;
                                    break;
                            }
                        }

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();

                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu)
                        {
                            Console.Clear();
                            System.Console.WriteLine("**Turno Dragão**");
                            Random geradorNumeroAleatorio = new Random();
                            int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                            int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                            int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                            if (dragaoDestrezaTotal > guerreiroDestrezaTotal)
                            {
                                System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Morra, ser miseravel .");
                                guerreiro.Vida = guerreiro.Vida -= dragao.Forca;
                                System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                            }
                            else
                            {
                                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Agora você não tem chance.");
                            }

                            System.Console.WriteLine();
                            System.Console.WriteLine("Aperte ENTER para prosseguir");
                            Console.ReadLine();

                            Console.Clear();

                            System.Console.WriteLine("Turno do jogador");
                            System.Console.WriteLine("Escolha uma ação");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Furgir");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    geradorNumeroAleatorio = new Random();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Receba, ser vil.");
                                        dragao.Vida = dragao.Vida - (poderAtaqueGuerreiro + 5);
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Patetico.");
                                    }



                                    break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Simbora Filhao");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: GG EZ");
                                    jogadorNaoCorreu = false;
                                    break;
                            }
                            if(guerreiro.Vida <= 0)
                            {
                                System.Console.WriteLine("Você morreu");
                            }

                            if(dragao.Vida <= 0){
                                System.Console.WriteLine("Você venceu");
                            }
                        }

                        break;
                    case "0":
                        jogadorNaoDesistiu = false;
                        System.Console.WriteLine("GAME OVER");
                        break;
                    default:
                        System.Console.WriteLine("Comando invalido");
                        break;
                }
            } while (jogadorNaoDesistiu);
        }

        public static void CriarDialogo() 
        {
            
        }

    }
}
