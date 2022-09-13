using FluentValidation;
using MS.Core.Messages;
using System;

namespace MS.Mensageria.API.Application.Commands
{
    public class RegistrarMensagemCommand : Command
    {
        public Guid Id { get; private set; }

        public string MicroServicoId { get; private set; }
        public string RequestId { get; private set; }
        public string Texto { get; private set; }

        public DateTime Timestamp { get; set; }

        public RegistrarMensagemCommand( Guid id, string microServicoId, string requestId,string texto)
        {
            Id = id;
            MicroServicoId = microServicoId;    
            RequestId = requestId;
            Texto = texto;
            Timestamp = DateTime.Now;
        }

        public override bool Valido()
        {
            ValidationResult = new RegistrarMensagemValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }

    public class RegistrarMensagemValidation : AbstractValidator<RegistrarMensagemCommand>
    {
        public RegistrarMensagemValidation()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty)
                .WithMessage("Id da mensagem inválido");

            RuleFor(c => c.MicroServicoId)
                .NotEmpty()
                .WithMessage("o micro Serviço Id não foi informado");

            RuleFor(c => c.RequestId)
                .NotEmpty()
                .WithMessage("o Id da requisição não foi informado");

            RuleFor(c => c.Texto)
                .NotEmpty()
                .WithMessage("o texto da mensagem não foi informado");
        }
    }
}
