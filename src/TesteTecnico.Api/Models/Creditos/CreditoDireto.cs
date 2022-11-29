using System;
using TesteTecnico.Api.Models.Enums;

namespace TesteTecnico.Api.Models.Creditos
{
    public class CreditoDireto : Credito
    {
        public CreditoDireto(decimal valorCredito, int quantidadeParcelas, DateTime dataPrimeiroVencimento) : 
            base(valorCredito, TipoCredito.Direto, quantidadeParcelas, dataPrimeiroVencimento)
        {
            // initialize
        }

        public override decimal ValorTaxa()
        {
            // Taxa de 2%
            return 2;
        }
    }
}
