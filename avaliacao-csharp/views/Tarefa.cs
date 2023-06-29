using System;
using System.Collections.Generic;

namespace Views
{
    public class TarefaView
    {
        public static void AddTarefa(){
            string nome;
            bool concluido = false;

            Console.WriteLine("Informe o nome: ");
            nome = Console.ReadLine();

            Controllers.TarefaController.AddTarefa(
                nome, concluido
            );
        }

        public static void ListTarefas(){
            List<Models.Tarefa> tarefas = Controllers.TarefaController
                .ListTarefas();

            Console.WriteLine("Esta é a lista de tarefas: \n\n");
            foreach (var tarefa in tarefas)
            {
                console.WriteLine(tarefa.ToString());
            } 
        }

        public static void UpdateTarefa(){

            int index;
            string? nome;
            bool? concluido;

            Console.Write("Digite o número da tarefa que você deseja atualizar: ");
            index = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            Controllers.TarefaController.UpdateTarefa(
                index - 1,
                nome,
                concluido
            );

            Console.Clear();
        }

        public static void DeleteTarefa(){

            int index;

            Console.Write("Digite o número da tarefa que você quer deletar: ");
            index = Convert.ToInt32(Console.ReadLine());

            Controllers.TarefaController.DeleteTarefa(index - 1);

            Console.Clear();
        }
  
    }

}