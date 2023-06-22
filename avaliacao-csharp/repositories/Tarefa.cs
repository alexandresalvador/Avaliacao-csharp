using System;
using System.Collections.Generic;

namespace Repositories
{

    public class TarefaRepository
    {

        static List<Models.Tarefa> tarefas = new List<Models.Tarefa>();

        public static void addTarefa(Models.Tarefa tarefa){
            tarefas.Add(tarefa);
        }

        public static List<Models.Tarefa> ListTarefas(){
            return tarefas;
        }

        public static Models.Tarefa? GetTarefa(int index){
            if(index < 0 || index >= tarefas.Count){
                return null;
            }else {
                return tarefas[index];
            }
        }

        public static void UpdateTarefa(int index, Models.Tarefa tarefa){
            tarefas[index] = tarefa;
        }

        public static void DeleteTarefa(int index){
            tarefas.RemovemoveAt(index);
        }
    }
}