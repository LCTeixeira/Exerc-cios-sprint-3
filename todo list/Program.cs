using System;
using System.Collections.Generic;
using System.IO;
namespace TodoList {
    class Program {
        static void main (string[] args) {
            List<TodoItem> todolist = new List<TodoItem> ();
            string fileName = "todo.csv";
            string filePath = ".\\" + fileName;

            try {
                string[] todoFile = File.ReadAllLines (filePath);

                foreach (var line in todoFile) {
                    string[] itens = line.Split (",");
                    string titulo = itens[0].Replace ("\"", "");
                    string nota = itens[1].Replace ("\"", "");

                    TodoItem todoItem = new TodoItem (titulo, nota);
                    todolist.Add (todoItem);
                }
            } catch (IOException ioe) {
                System.Console.WriteLine ("Erro ao acessar arquivo");
                System.Console.WriteLine (ioe.Message);
            }

            int opcao = 0;

            do {
                Console.Clear ();
                System.Console.WriteLine ("TODO LIST");
                System.Console.WriteLine ();
                ListaItens(todolist);
                System.Console.WriteLine();
                System.Console.WriteLine ("Digite uma opção:");
                System.Console.WriteLine ("1 - Adicionar Item");
                System.Console.WriteLine ("2 - Remover Item");
                System.Console.WriteLine ("3 - Sair do programa");
                System.Console.Write ("Opção: ");
                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        /**
                         * TODO: Método de adicionar itens a lista
                         */
                        break;
                    case 2:
                        /**
                         * TODO: Método de remover  itens a lista
                         */
                        break;
                    case 3:
                        System.Console.WriteLine ("Tchau!");
                        break;
                    default:
                        System.Console.WriteLine ("Opção invalida");
                        Console.ReadLine ();
                        break;
                }

            } while (opcao != 3);
        }

        public static void ListaItens (List<TodoItem> todolist) {
            Console.Clear ();
            int count = 1;
            System.Console.WriteLine ("Todo List");
            System.Console.WriteLine ();
            System.Console.WriteLine ($"ID{"",2} Titulo{"",12} Notas");
            foreach (TodoItem item in todolist) {
                System.Console.WriteLine($"{count, 3}: {item.Titulo, -15} - {item.Nota}");
                count++;
            }
        }
    }
}