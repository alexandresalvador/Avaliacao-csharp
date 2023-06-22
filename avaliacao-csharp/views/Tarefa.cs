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

        // update
        // delete

    }

}