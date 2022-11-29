using TesteTecnico.Api.Interfaces;
using TesteTecnico.Api.Models.Creditos;
using TesteTecnico.Api.Models.Creditos.Factory;
using TesteTecnico.Api.Models.Creditos.Validation;
using TesteTecnico.Api.Services.Base;

namespace TesteTecnico.Api.Services
{
    public class CreditoService : BaseService, ICreditoService
    {
        public CreditoService(INotificador notificador) : base(notificador)
        {
            // initialize
        }

        public Credito TratarCredito(Credito credito)
        {
            // Validação da classe
            if (!ExecutarValidacao(new CreditoValidation(), credito))
                return null;

            // Tratamento para o tipo de Crédito
            return new CreditoFactory(credito).GetCredito(credito.TipoCredito);
        }
    }
}
