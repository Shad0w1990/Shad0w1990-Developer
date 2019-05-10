using System;
using CSharpFunctionalExtensions;

namespace Core
{
    public sealed class CommadQueryDispatcher
    {
        private readonly IServiceProvider _provider;

        public CommadQueryDispatcher(IServiceProvider provider)
        {
            _provider = provider;
        }

        public Result Handler(ICommand command)
        {
            Type type = typeof(ICommandHandler<>);
            Type[] typesArges = {command.GetType()};
            Type handlerType = type.MakeGenericType(typesArges);
            dynamic handler = _provider.GetService(handlerType);
            Result result = handler.Handle((dynamic) command);
            return result;
        }
        public T Dispatcher<T>(IQuery<T> query)
        {
            Type type = typeof(IQueryHandler<,>);
            Type[] typesArges = { query.GetType() };
            Type handlerType = type.MakeGenericType(typesArges);
            dynamic handler = _provider.GetService(handlerType);
            T result = handler.Handle((dynamic)query);
            return result;
        }

    }
}