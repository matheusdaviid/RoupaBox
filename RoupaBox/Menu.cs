using RoupaBox;
using System;

namespace RoupaBox
{
    public class Menu
    {
        public void ExibirMenu(ProdutoCad produtoCad, ClienteCad clienteCad)
        {
            while (true)
            {
                Cabecalho.ExibirCabecalho();
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Cadastrar Cliente");
                Console.WriteLine("3 - Listar Produtos");
                Console.WriteLine("4 - Listar Clientes");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        produtoCad.CadastrarProduto();
                        break;
                    case 2:
                        clienteCad.CadastrarCliente();
                        break;
                    case 3:
                        produtoCad.ListarProdutos();
                        break;
                    case 4:
                        clienteCad.ListarClientes();
                        break;
                    case 5:
                        Console.WriteLine("Saindo do sistema...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
