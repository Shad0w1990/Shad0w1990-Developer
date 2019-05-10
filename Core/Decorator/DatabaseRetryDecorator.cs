using System;
using System.Collections.Generic;
using System.Text;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace Core.Decorator
{
    public class DatabaseRetryDecorator<TCommand> : ICommandHandler<TCommand> where TCommand : ICommand
    {
        private readonly ICommandHandler<TCommand> _handler; 
        public Result Handle(TCommand command)
        {
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Result result = _handler.Handle(command);
                    return result;
                }
                catch (Exception e)
                {
                    if (i>=3 || !IsDatabaseException(e))
                   throw;
                }
            }
            throw new NotImplementedException();
        }

        private bool IsDatabaseException(Exception exception)
        {
            string message = exception.InnerException?.Message;
            if (message == null)
                return false;
            return message.Contains("the connection id broken and repository is not possible")
                   || message.Contains("error occurred while establishing a connection");
        }
    }
}
