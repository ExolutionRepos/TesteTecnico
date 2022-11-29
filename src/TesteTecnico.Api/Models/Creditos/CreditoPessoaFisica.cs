using System;
using TesteTecnico.Api.Models.Enums;

namespace TesteTecnico.Api.Models.Creditos
{
    public class CreditoPessoaFisica : Credito
    {
        public CreditoPessoaFisica(decimal valorCredito, int quantidadeParcelas, DateTime dataPrimeiroVencimento) : 
            base(valorCredito, TipoCredito.PessoaFisica , quantidadeParcelas, dataPrimeiroVencimento)
        {
            // initialize
        }

        public override decimal ValorTaxa()
        {
            // Taxa de 3%
            return 3;
        }
    }
}
