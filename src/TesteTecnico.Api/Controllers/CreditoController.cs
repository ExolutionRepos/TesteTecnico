using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnico.Api.Controllers.Base;
using TesteTecnico.Api.DTOs.Request;
using TesteTecnico.Api.DTOs.Response;
using TesteTecnico.Api.Interfaces;
using TesteTecnico.Api.Models.Creditos;

namespace TesteTecnico.Api.Controllers
{
    [Route("api/v1/credito")]
    public class CreditoController : BaseController
    {
        private readonly ICreditoService _credito;
        private readonly IMapper _mapper;
        public CreditoController(INotificador notificador,
            IMapper mapper,
            ICreditoService credito) : base(notificador)
        {
            _mapper = mapper;
            _credito = credito;
        }

        /// <summary>
        /// Obtem dados e resposta para obtenção de crédito
        /// <param name="creditoDto"></param>
        /// </summary>
        /// <returns></returns>
        [HttpPost("liberacao-credito")]
        [ProducesResponseType(typeof(CreditoResponseDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public ActionResult<CreditoResponseDTO> LiberacaoCredito(CreditoRequestDTO creditoDto)
        {
            // VALIDAÇÃO INICIAL DAS INFORMÃÇÕES RECEBIDAS
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            try
            {
                // MAPEMENTO DA DTO PARA CLASSE
                var mappedCredito = _credito.TratarCredito(_mapper.Map<Credito>(creditoDto));

                // TRATAMENTO DO RETORNO
                return CustomResponse(new CreditoResponseDTO()
                {
                    // VERIFICA SE HÁ ERROS
                    Status =  OperacaoValida() ? 
                            DTOs.Enums.StatusResponseCredito.Aprovado: 
                            DTOs.Enums.StatusResponseCredito.Recusado,
                    ValorJuros = mappedCredito?.ValorTaxa() ?? 0,
                    ValorTotalComJuros = mappedCredito?.CalcularTaxa() ?? 0
                });

            }
            catch (Exception ex)
            {
                // TRATAMENTO DE ERRO
                NotificarErro($"Erro ao processar solicitação. Obs.{ex.Message}");
                return CustomResponse();
            }
            
        }
    }
}
