using System;
using System.Collections.Generic;

namespace Views
{
    public class PessoaView
    {
        public static void AddPessoa(){
            string nome, endereco, email;
            int idade;
            bool vivo = true;

            Console.WriteLine("Informe o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe o Endereço: ");
            endereco = Console.ReadLine();
            Console.WriteLine("Informe a idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o Email: ");
            email = Console.ReadLine();
            
            Controllers.PessoaController.AddPessoa(
                nome, endereco, idade, vivo, email
            );
        }
        
        public static void ListPessoas(){
            List<Models.Pessoa> pessoas = Controllers.PessoaController
                .ListPessoas();

            Console.WriteLine("Segue sua lista de pessoas: \n\n");
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa.ToString());
            }
        }
        
        public static void UpdatePessoa(){
            string nome, endereco, email;
            int idade, index;
            bool vivo = true;

            Console.WriteLine("Informe o Index da pessoa: ");
            index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe o Endereço: ");
            endereco = Console.ReadLine();
            Console.WriteLine("Informe a idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o Email: ");
            email = Console.ReadLine();
            
            Controllers.PessoaController.UpdatePessoa(
                index-1, nome, endereco, idade, vivo, email
            );
        }
 
        public static void DeletePessoa(){
            int index;
            
            Console.WriteLine("Informe o Index da pessoa: ");
            index = Convert.ToInt32(Console.ReadLine());
            
            Controllers.PessoaController.DeletePessoa(index-1);
        }
    }
}