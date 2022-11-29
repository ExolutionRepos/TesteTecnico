using System;
using TesteTecnico.Api.Models.Enums;

namespace TesteTecnico.Api.Models.Creditos.Abstract
{
    public abstract class CreditoAbstract
    {
        public abstract decimal ValorCredito { get; protected set; }
        public abstract TipoCredito TipoCredito { get; protected set; }
        public abstract int QuantidadeParcelas { get; protected set; }
        public abstract DateTime DataPrimeiroVencimento { get; protected set; }
        public abstract decimal ValorTaxa();
    }
}
