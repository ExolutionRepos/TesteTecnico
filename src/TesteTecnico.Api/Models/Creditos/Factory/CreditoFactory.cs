using System;
using System.Collections.Generic;
using TesteTecnico.Api.Models.Enums;

namespace TesteTecnico.Api.Models.Creditos.Factory
{
    public class CreditoFactory
    {
        private readonly Dictionary<TipoCredito, Func<Credito>> _creditoTypeMapper;

        public CreditoFactory(Credito credito) =>
            _creditoTypeMapper = new Dictionary<TipoCredito, Func<Credito>>
            {
                { TipoCredito.Direto, () => { return new CreditoDireto(credito.ValorCredito, credito.QuantidadeParcelas, credito.DataPrimeiroVencimento); } },
                { TipoCredito.Consignado, () => { return new CreditoConsignado(credito.ValorCredito, credito.QuantidadeParcelas, credito.DataPrimeiroVencimento); } },
                { TipoCredito.PessoaJuridica, () => { return new CreditoPessoaJuridica(credito.ValorCredito, credito.QuantidadeParcelas, credito.DataPrimeiroVencimento); } },
                { TipoCredito.PessoaFisica, () => { return new CreditoPessoaFisica(credito.ValorCredito, credito.QuantidadeParcelas, credito.DataPrimeiroVencimento); } },
                { TipoCredito.Imobiliario, () => { return new CreditoImobiliario(credito.ValorCredito, credito.QuantidadeParcelas, credito.DataPrimeiroVencimento); } }
            };

        public Credito GetCredito(TipoCredito tipoCredito) => _creditoTypeMapper[tipoCredito]();
    }
}
