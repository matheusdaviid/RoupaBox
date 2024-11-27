namespace RoupaBox
{
    public class Cliente
    {
        public string Nome { get; set; }
        public long CPF { get; set; }
        public long Telefone { get; set; }

        public Cliente(string nome, long cpf, long telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }
    }
}
