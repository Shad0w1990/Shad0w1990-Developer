using System;
using System.Collections.Generic;
using System.Text;
using CSharpFunctionalExtensions;

namespace Core
{
    public interface IQueryHandler<TQuery,TResult> where TQuery:IQuery<TResult>
    {
       Result<TResult> QueryHandler(TQuery query);
    }
}
