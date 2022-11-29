using System;
using TesteTecnico.Api.Models.Enums;

namespace TesteTecnico.Api.Models.Creditos
{
    public class CreditoConsignado : Credito
    {
        public CreditoConsignado(decimal valorCredito, int quantidadeParcelas, DateTime dataPrimeiroVencimento) : 
            base(valorCredito, TipoCredito.Consignado, quantidadeParcelas, dataPrimeiroVencimento)
        {
            // initialize
        }

        public override decimal ValorTaxa()
        {
            // Taxa de 1%
            return 1;
        }

    }
}
