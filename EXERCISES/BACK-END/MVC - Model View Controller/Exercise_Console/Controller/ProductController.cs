using System.Collections.Generic;
using Exercise_Console.Models;
using Exercise_Console.View;

namespace Exercise_Console.Controller
{
    public class ProductController
    {
        Product productModels = new Product();
        ProductView productView = new ProductView();

        public void Listar(){
            List<Product> lista = productModels.Ler(); // essa nova lista vai ser igual ao metodo "Ler" do Models, que também é uma lista
            productView.ShowInConsole(lista); // os dados da lista vão ser exibidos pelo View conforme aquele padrão de CWL que está no diretório View
        }
        public void Search(string termo){
            List<Product> lista = productModels.Ler().FindAll(x => x.Price == float.Parse(termo)); // aqui vai achar todos os itens da lista com o valor que o cliente buscar
            productView.ShowInConsole(lista); // vai exibir no View
        }

        public void Cadastrar(){
            productModels.Inserir(productView.CadastrarProduto()); // o Models vai inserir as informações no View as coisas que cadastrar
        }
    }
}