using System;
using System.Collections.Generic;
using System.Text;
using AppServiceReporting.DTOs;
using AppServiceReporting.Queries;
using Core;

namespace AppServiceReporting.Handlers
{
    public class GetAllPersonQueryHandler : IQueryHandler<GetAllPersonQuery, List<PersonDto>>
    {
        public List<PersonDto> QueryHandler(GetAllPersonQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
