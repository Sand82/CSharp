using DemoLibrary.Commands;
using DemoLibrary.Models;
using DemoLibrary.Models.ApiModels;
using DemoLibrary.Models.OutputModels;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
         private readonly IMediator mediator;

        public PersonController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        
        [HttpGet]
        public async Task<List<PersonOutputModel>> Get()
        {
            return await mediator.Send(new GetPersonsListQuery());
        }
       
        [HttpGet("{id}")]
        public async Task<PersonOutputModel> Get(int id)
        {
            return await mediator.Send(new GetPersonQuery(id));
        }
        
        [HttpPost]
        public async Task<CreateEditPersonOutputModel> Post([FromBody] PersonOutputModel model)
        {
            return await mediator.Send(new CreatePersonCommand(model.FirstName, model.LastName));
        }
        
        [HttpPut("{id}")]
        public async Task<CreateEditPersonOutputModel> Put(int id, [FromBody] PersonOutputModel model)
        {
            return await mediator.Send( new EditPersonCommand(id, model.FirstName, model.LastName));
        }
        
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await mediator.Send(new DeletePersonCommand(id));
        }
    }
}
