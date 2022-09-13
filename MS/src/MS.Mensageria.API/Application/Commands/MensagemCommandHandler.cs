using MediatR;
using System.Threading;
using System.Threading.Tasks;
using MS.Core.Messages;

namespace MS.Mensageria.API.Application.Commands
{
    public class MensagemCommandHandler :
        IRequestHandler<RegistrarMensagemCommand, bool>
    {
        public async Task<bool> Handle(RegistrarMensagemCommand mensagem, CancellationToken cancellationToken)
        {
            if (!ValidarComando(mensagem)) return false;
            return true;
        }

        private bool ValidarComando(Command mensagem)
        {
            if(mensagem.Valido()) return true;
            return false;
        }
    }
}
