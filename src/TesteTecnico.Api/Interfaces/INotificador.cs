using System.Collections.Generic;
using TesteTecnico.Api.Models.Notificacoes;

namespace TesteTecnico.Api.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
