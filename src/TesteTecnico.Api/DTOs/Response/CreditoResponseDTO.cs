using TesteTecnico.Api.DTOs.Enums;

namespace TesteTecnico.Api.DTOs.Response
{
    public class CreditoResponseDTO
    {
        // SAIDO DO STATUS APROVADO OU RECUSADO
        public StatusResponseCredito Status { get; set; }
        public string StatusDescricao => Status.ToString();

        // VALOR CALCULADO COM JUROS
        public decimal ValorTotalComJuros { get; set; }

        // VALOR TAXA DE JUROS %
        public decimal ValorJuros { get; set; }
    }
}
