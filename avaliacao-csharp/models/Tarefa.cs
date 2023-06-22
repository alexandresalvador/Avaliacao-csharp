using System;

namespace Models
{

    public class Tarefa
    {
        public string Nome { get; set; }
        public string DataHora { get; set; }
        public bool Concluido { get; set; }

        public Tarefa(string nome)
        {
            this.Nome = nome;
            this.DataHora = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
            this.Concluido = false;

            Repositories.TarefaRepository.addTarefa(this);
        }

        public static List<Models.Tarefa> ListTarefas()
        {
            return Repositories.TarefaRepository.ListTarefas();
        }

        public static Tarefa? GetTarefa(int index)
        {
            return Repositories.TarefaRepository.GetTarefa(index);
        }

        public static void UpdateTarefa(
            int index,
            string nome,
            bool concluido
        )
        {
            Tarefa tarefa = Tarefa.GetTarefa(index);
            if (tarefa != null)
            {
                tarefa.Nome = nome;
                tarefa.Concluido = concluido;

                Repositories.TarefaRepository.UpdateTarefa(index, tarefa);
            }
        }

        public static void DeleteTarefa(int index)
        {
            Tarefa tarefa = Tarefa.GetTarefa(index);
            if (tarefa != null)
            {
                Repositories.TarefaRepository.DeleteTarefa(index);
            }
        }


        public override string ToString()
        {
            string ValorConcluido = "";
            if (Concluido == false)
            {
                ValorConcluido = "não";
            }
            else (ValorConcluido = "sim");

            Console.WriteLine($"Olá, esta é a tarefa {Nome}. A data e a hora são as seguintes: {DataHora}. E a tarefa, {ValorConcluido} está concluida.");
        }
    }
}

