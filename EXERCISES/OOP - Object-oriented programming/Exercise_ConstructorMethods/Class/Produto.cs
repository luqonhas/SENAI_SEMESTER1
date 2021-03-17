namespace Exercise_ConstructorMethods.Class
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int EmEstoque { get; set; }

        public Produto(int codigo, string nome, string descricao, int emEstoque){
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            EmEstoque = emEstoque;
        }
    }
}