using DemoLibrary.Models.OutputModels;
using MediatR;

namespace DemoLibrary.Commands
{
    public record EditPersonCommand(int Id, string FirstName, string LastName) : IRequest<CreateEditPersonOutputModel>;    
}
