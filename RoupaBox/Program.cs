namespace RoupaBox
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoCad produtoCad = new ProdutoCad();
            ClienteCad clienteCad = new ClienteCad();
            Menu menu = new Menu();

            menu.ExibirMenu(produtoCad, clienteCad);
        }
    }
}
