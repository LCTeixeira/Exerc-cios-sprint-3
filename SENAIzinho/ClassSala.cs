using System;

namespace SENAIzinho {
    class Sala {
    
        public int capacidadeAtual;
        public int capacidadeTotal;
        public int numeroSala;
        public string[] Alunos;

        public Sala(int capacidadeAtual, int capacidadeTotal){
            this.capacidadeAtual = capacidadeAtual;
            this.capacidadeTotal = 10;
        }

        public AlocarAluno(string[] Alunos){
            if(capacidadeAtual <= capacidadeTotal){
                for(capacidadeAtual = 0; capacidadeAtual <= 10; capacidadeAtual++){
                    System.Console.WriteLine($"Nome do Aluno:{string.Nome} " + capacidadeAtual );
                    Console.ReadLine();
                    System.Console.WriteLine(capacidadeAtual);
                    System.Console.WriteLine(capacidadeTotal);
                    
                }
            }else{
                System.Console.WriteLine("Erro");
            }
        }

        
    }
}