using domain.models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikation.Queries.Dogs
{
    public class GetAllDogsQuery: IRequest<List<Dog>>
    {
    }
}
