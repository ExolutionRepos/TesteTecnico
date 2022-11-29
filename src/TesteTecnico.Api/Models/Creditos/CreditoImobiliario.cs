using System;
using TesteTecnico.Api.Models.Enums;

namespace TesteTecnico.Api.Models.Creditos
{
    public class CreditoImobiliario : Credito
    {
        public CreditoImobiliario(decimal valorCredito, int quantidadeParcelas, DateTime dataPrimeiroVencimento) : 
            base(valorCredito, TipoCredito.Imobiliario, quantidadeParcelas, dataPrimeiroVencimento)
        {
            // initialize
        }

        public override decimal ValorTaxa()
        {
            // Taxa de 9%
            return 9;
        }
    }
}
