using FluentValidation;
using System;
using System.Runtime.CompilerServices;
using TesteTecnico.Api.Models.Creditos.Abstract;
using TesteTecnico.Api.Models.Enums;

namespace TesteTecnico.Api.Models.Creditos.Validation
{
    public class CreditoValidation : AbstractValidator<Credito>
    {
        public CreditoValidation()
        {

            // O valor máximo a ser liberado para qualquer tipo de empréstimo é de R$ 1.000.000,00.
            RuleFor(c => c.ValorCredito)
                .NotEmpty().WithMessage("O valor de crédito precisa ser informado.")
                .LessThanOrEqualTo(1000000)
                .WithMessage("O valor máximo a ser liberado para qualquer tipo de empréstimo é de R$ 1.000.000,00.");

            //A quantidade mínima de parcelas é de 5x e a máxima é de 72x.
            RuleFor(c => c.QuantidadeParcelas)
                .NotEmpty().WithMessage("A quantidade de parcelas precisa ser informada.")
                .InclusiveBetween(5, 72)
                .WithMessage("A quantidade mínima de parcelas é de 5x e a máxima é de 72x.");

            //Para o crédito de pessoa jurídica, o valor mínimo a ser liberado é de R$ 15.000,00.
            When(x => x.TipoCredito.Equals(TipoCredito.PessoaJuridica), () =>
            RuleFor(c => c.ValorCredito)
                .GreaterThan(15000)
                .WithMessage("Para o crédito de pessoa jurídica, o valor mínimo a ser liberado é de R$ 15.000,00."));

            //A data do primeiro vencimento sempre será no mínimo 15 dias e no máximo 40 dias a partir da data atual.
            RuleFor(c => c.DataPrimeiroVencimento)
                .NotEmpty().WithMessage("A data do primeiro vencimento precisa ser informada.")
                .InclusiveBetween(DateTime.Now.AddDays(15), DateTime.Now.AddDays(40))
                .WithMessage("A data do primeiro vencimento sempre será no mínimo 15 dias e no máximo 40 dias a partir da data atual.");
        }
    }
}
