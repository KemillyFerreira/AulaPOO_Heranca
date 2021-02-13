namespace Herança
{
    public class PessoaFisica : Pessoa
    {
        public string cpf;
        public string rg;

        public bool ValidarCpf(string documento)
        {
            if(cpf != "")
            {
                return true;
            }

            return false;
        }
    }
}