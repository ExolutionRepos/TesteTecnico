using System;
using TesteTecnico.Api.Models.Enums;

namespace TesteTecnico.Api.Models.Creditos
{
    public class CreditoPessoaJuridica : Credito
    {
        public CreditoPessoaJuridica(decimal valorCredito, int quantidadeParcelas, DateTime dataPrimeiroVencimento) : 
            base(valorCredito, TipoCredito.PessoaJuridica, quantidadeParcelas, dataPrimeiroVencimento)
        {
            // initialize
        }

        public override decimal ValorTaxa()
        {
            // Taxa de 5%
            return 5;
        }
    }
}
