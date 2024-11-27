using RoupaBox;
using System;
using System.Collections.Generic;

namespace RoupaBox
{
    public class ClienteCad
    {
        public List<Cliente> Clientes { get; set; }

        public ClienteCad()
        {
            Clientes = new List<Cliente>();
        }

        public void CadastrarCliente()
        {
            Cabecalho.ExibirCabecalho();
            Console.WriteLine("Cadastro de Cliente");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            long cpf = long.Parse(Console.ReadLine());
            Console.Write("Telefone: ");
            long telefone = long.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(nome, cpf, telefone);
            Clientes.Add(cliente);

            Console.WriteLine("Cliente cadastrado com sucesso!");
            Console.ReadKey();
        }

        public void ListarClientes()
        {
            Cabecalho.ExibirCabecalho();
            Console.WriteLine("Lista de Clientes:");
            if (Clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
            }
            else
            {
                foreach (var cliente in Clientes)
                {
                    Console.WriteLine($"Nome: {cliente.Nome}, CPF: {cliente.CPF}, Telefone: {cliente.Telefone}");
                }
            }
            Console.ReadKey();
        }
    }
}
