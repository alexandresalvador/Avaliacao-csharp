using System;

namespace Programa
{
    public class Program
    {
        static void Main(string[] args)
        {
            int op = 0;

            do
            {
                Console.WriteLine("\nInfome a opção desejada \n");
                Console.WriteLine("1- Adicionar");
                Console.WriteLine("2- Listar");
                Console.WriteLine("3- Alterar");
                Console.WriteLine("4- Delete");
                Console.WriteLine("5- Sair \n");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Views.PessoaView.AddPessoa();
                            break;
                        }
                    case 2:
                        {
                            Views.PessoaView.ListPessoas();
                            break;
                        }
                    case 3:
                        {
                            Views.PessoaView.UpdatePessoa();
                            break;
                        }
                    case 4:
                        {
                            Views.PessoaView.DeletePessoa();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Saindo");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Op Inválida");
                            break;
                        }
                }

            } while (op != 5);
        }
    }
}