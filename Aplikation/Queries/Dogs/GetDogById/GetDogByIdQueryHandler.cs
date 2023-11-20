using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain.models;
using Infrastruktur.Databas;

namespace Aplikation.Queries.Dogs.GetDogById
{
    internal class GetDogByIdQueryHandler : IRequestHandler<GetDogByIdQuery, Dog>
    {
        private readonly mockDatabas _mockDatabas;

        public GetDogByIdQueryHandler(mockDatabas mockDatabas)
        {
            _mockDatabas = mockDatabas;
        }

        public Task<Dog> Handle(GetDogByIdQuery request, CancellationToken cancellationToken)
        {
            Dog wantedDog = _mockDatabas.allDogs.Where(Dog => Dog.animalId == request.Id).FirstOrDefault()!;
            return Task.FromResult(wantedDog);
        }
    }
}
