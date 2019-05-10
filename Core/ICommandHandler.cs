using System.Threading.Tasks;
using CSharpFunctionalExtensions;

namespace Core
{
    public interface ICommandHandler<TCommand> where TCommand: ICommand
    {
        Result Handle(TCommand command);
       // Task<Result> HandleAsync(ICommand command);
    }
}
