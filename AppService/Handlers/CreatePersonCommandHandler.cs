using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppService.Commads;
using Core;
using CSharpFunctionalExtensions;

namespace AppService.Handlers
{
    public class CreatePersonCommandHandler : ICommandHandler<CreatePersonCommand>
    {
        public Result Handle(CreatePersonCommand command)
        {
            throw new NotImplementedException("test");
        }

        
    }
}
