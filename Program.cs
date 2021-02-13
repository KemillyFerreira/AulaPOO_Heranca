using System;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos nossa subclasse
            PessoaFisica pf = new PessoaFisica();

            //atribuímos um valor para a propriedade disponível na superclasse
            pf.nome = "Kemilly";

            //mostramos no console
            Console.WriteLine( pf.DarBoasVindas(pf.nome) );
            
            Console.WriteLine(pf.ValidarCpf(pf.cpf));
            
        }
    }
}
