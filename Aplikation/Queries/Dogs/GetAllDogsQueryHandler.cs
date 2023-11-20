using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain.models;
using Infrastruktur.Databas;

namespace Aplikation.Queries.Dogs
{
    internal class GetAllDogsQueryHandler : IRequestHandler<GetAllDogsQuery, List<Dog>>
    {
        private readonly mockDatabas _mockDatabas;
        
        public GetAllDogsQueryHandler(mockDatabas mockDatabas)
        {
            _mockDatabas = mockDatabas;
        }
        public Task<List<Dog>> Handle(GetAllDogsQuery request, CancellationToken cancellationToken)
        {
            List<Dog> allDogsFromMockDB = _mockDatabas.allDogs;
            return Task.FromResult(allDogsFromMockDB);
        }
    }
}
