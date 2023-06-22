using System;

namespace Programa
{

    public class MenuCrud
    {

        public static void Rodar()
        {
            int op = 0;

            do
            {
                Console.WriteLine("\nInforme o que deseja fazer: \n");
                Console.WriteLine("1- Adicionar");
                Console.WriteLine("2- Listar");
                Console.WriteLine("3- Alterar");
                Console.WriteLine("4- Deletar");
                Console.WriteLine("5- Sair \n");
                op = Convert.ToInt32(Console.ReadLine());
                
                Console.Clear();
                switch (op)
                {
                    case 1:
                        {
                            // Views.TarefaView.AddTarefa();
                            break;
                        }
                    case 2:
                        {
                            // Views.TarefaView.ListTarefas();
                            break;
                        }
                    case 3:
                        {
                            // Views.TarefaView.UpdateTarefa();
                            break;
                        }
                    case 4:
                        {
                            // Views.TarefaView.DeleteTarefa();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Adeus");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opção Inválida");
                            break;
                        }
                }

            } while (op != 5);
        }
    }
}
