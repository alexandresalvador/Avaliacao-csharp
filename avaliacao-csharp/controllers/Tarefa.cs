using System;
using System.Collections.Generic;

namespace Controllers
{
  public class TarefaController
  {
    public static void AddTarefa(string? nome, bool? concluido)
    {
      new Models.Tarefa(nome, concluido);
      Console.WriteLine("\nA Tarefa foi adicionada com sucesso!\n");
    }

    public static List<Models.Tarefa> listTarefas()
    {
      return Models.Tarefa.listTarefas();
    }

    public static void UpdateTarefa(
      int index,
      string? nome,
      bool? concluido
    )
    {
      Models.Tarefa.UpdateTarefa(
        index,
        nome,
        concluido
      );

      Console.WriteLine("\nA Tarefa foi alterada com sucesso!\n");
    }

    public static void DeleteTarefa(int index)
    {
      Models.Tarefa.DeleteTarefa(index);

      Console.WriteLine("\nA Tarefa foi deletada com sucesso!\n");
    }
  }
}