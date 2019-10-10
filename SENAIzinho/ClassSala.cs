using System;
namespace SENAIzinho {
    class sala {
        public int capacidadeAtual;
        public int capacidadeTotal;
        public int numeroSala;
        public string[] Alunos;

        public sala (int numeroSala, int capacidadeTotal) {
            this.numeroSala = numeroSala;
            this.capacidadeTotal = capacidadeTotal;
            this.capacidadeAtual = this.capacidadeTotal;
            this.Alunos = new string[capacidadeTotal];
        }

        public string AlocarAluno (string NomeAluno) {
            int index = 0;
            if (this.capacidadeAtual > 0) {
                foreach (string aluno in this.Alunos) {
                    if (aluno == "") {
                        this.Alunos[index] = NomeAluno;
                        break;
                    }
                    index++;
                }
                this.capacidadeAtual--;
                return "OK";
            } else {
                return "LOTADO";
            }
        }

        public string RemoverAluno (string nomeAluno) {
            int index = 0;
            if(this.capacidadeAtual == this.capacidadeTotal){
                return"SALAVAZIA";
            }
            foreach (string aluno in this.Alunos) {
                if (nomeAluno == aluno) {
                    this.Alunos[index] = "";
                    return "OK";
                }
                index++;
            }
            return "NAOENCONTRADO";
        }
        public String MostrarAlunos (){
            string listaAlunos="";
            foreach(string aluno in this.Alunos){
                if(aluno != ""){
                    listaAlunos = listaAlunos + aluno + ",";
                }
            }
            listaAlunos.TrimEnd();
            return listaAlunos;
        }
    }
}