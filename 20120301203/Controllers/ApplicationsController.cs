using Microsoft.AspNetCore.Mvc;
using MyMediator.Interfaces;
using _20120301203.CQRS;
using _20120301203.CQRS.CommandList;
using _20120301203.DB;
namespace _20120301203.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : Controller
    {
        private readonly MyMediator.Types.Mediator _mediator;
        public ApplicationsController(MyMediator.Types.Mediator mediator)
        {
            _mediator = mediator;
        }

    }
}

