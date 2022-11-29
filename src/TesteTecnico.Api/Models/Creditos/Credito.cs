using System;
using TesteTecnico.Api.Models.Creditos.Abstract;
using TesteTecnico.Api.Models.Enums;

namespace TesteTecnico.Api.Models.Creditos
{
    public class Credito : CreditoAbstract
    {
        public override decimal ValorCredito { get; protected set; }
        public override TipoCredito TipoCredito { get; protected set; }
        public override int QuantidadeParcelas { get; protected set; }
        public override DateTime DataPrimeiroVencimento { get; protected set; }

        public Credito(decimal valorCredito, TipoCredito tipoCredito, int quantidadeParcelas, DateTime dataPrimeiroVencimento)
        {
            ValorCredito = valorCredito;
            TipoCredito = tipoCredito;
            QuantidadeParcelas = quantidadeParcelas;
            DataPrimeiroVencimento = dataPrimeiroVencimento;
        }

        // Calcular Crédito + Taxa
        public decimal CalcularTaxa() => decimal.Round(ValorCredito + (ValorCredito * (ValorTaxa() / 100)), 2);

        // Taxa Padrão
        public override decimal ValorTaxa() => 0;
    }
}
