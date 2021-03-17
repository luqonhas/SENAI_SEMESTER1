using Exercise_Interfaces.Class;

namespace Exercise_Interfaces
{
    public interface ICarrinho
    {
         void Listar();
         void Cadastrar(Produto produto);
         void Alterar(int codigo, Produto produto);
         void Deletar(Produto produto);
    }
}