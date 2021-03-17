using System;

namespace Exercise_Interfaces.Class
{
    public class Carrinho : ICarrinho
    {
        public void Alterar(int codigo, Produto produto)
        {

        }

        public void Cadastrar(Produto produto)
        {

        }

        public void Deletar(Produto produto)
        {

        }

        public void Listar()
        {
            
        }

        internal void Deletar(int code)
        {
            throw new NotImplementedException();
        }
    }
}