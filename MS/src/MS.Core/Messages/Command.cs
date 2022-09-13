using FluentValidation.Results;
using MediatR;
using System;

namespace MS.Core.Messages
{
    public class Command : Message, IRequest<bool>
    {
        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        public virtual bool Valido()
        {
            throw new NotImplementedException();
        }
    }
}
