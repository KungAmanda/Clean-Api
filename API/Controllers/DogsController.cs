using MediatR;
using Microsoft.AspNetCore.Mvc;
using Aplikation.Queries.Dogs;
using Aplikation.Queries.Dogs.GetDogById;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        internal readonly IMediator _mediatR;

        public DogsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }
        // detta är API endpoint där vi hämtar där vi hämtar alla hundar från mockDatabas
        // url är api/v1/getAllDogs
        [HttpGet]
        [Route("getAllDogs")]
        public async Task<IActionResult> GetAllDogs()
        {

            //använda mediatR 
            //mediatR ska ta emot request och dela de på commands eller queries
            // detta är en get d blir det en query
            // return IActionResult
            return Ok(await _mediatR.Send(new GetAllDogsQuery()));

        }

        [HttpGet]
        [Route("getDogById/{dogId}")]
        public async Task<IActionResult> GetDogById(Guid dogId)
        {
            return Ok(await _mediatR.Send(new GetDogByIdQuery(dogId)));
        }
    }
}
