using System;
using System.ComponentModel.DataAnnotations;
using TesteTecnico.Api.DTOs.Enums;

namespace TesteTecnico.Api.DTOs.Request
{
    public class CreditoRequestDTO
    {
        [Required]
        public decimal ValorCredito { get; set; }

        [Required]
        public TipoCreditoDto TipoCredito { get; set; }

        [Required]
        public int QuantidadeParcelas { get; set; }

        [Required]
        public DateTime DataPrimeiroVencimento { get; set; }
    }
}
