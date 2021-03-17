namespace Exercise_Heritage.Class
{
    public class PessoaJuridica:Pessoa
    {
        public string cnpj;
        public string inscricaoEstadual;

        public bool ValidarCNPJ(string documentoCNPJ){
            if(documentoCNPJ != "" && documentoCNPJ.Length > 18){
                return true;
            }
            return false;
        }
    }
}