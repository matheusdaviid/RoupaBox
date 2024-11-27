using RoupaBox;
using System;
using System.Collections.Generic;

namespace RoupaBox
{
    public class ProdutoCad
    {
        public List<Produto> Produtos { get; set; }

        public ProdutoCad()
        {
            Produtos = new List<Produto>();
        }

        public void CadastrarProduto()
        {
            Cabecalho.ExibirCabecalho();
            Console.WriteLine("Cadastro de Produto");
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Produto produto = new Produto(descricao, preco);
            Produtos.Add(produto);

            Console.WriteLine("Produto cadastrado com sucesso!");
            Console.ReadKey();
        }

        public void ListarProdutos()
        {
            Cabecalho.ExibirCabecalho();
            Console.WriteLine("Lista de Produtos:");
            if (Produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
            }
            else
            {
                foreach (var produto in Produtos)
                {
                    Console.WriteLine($"Descrição: {produto.Descricao}, Preço: {produto.Preco:C}");
                }
            }
            Console.ReadKey();
        }
    }
}
