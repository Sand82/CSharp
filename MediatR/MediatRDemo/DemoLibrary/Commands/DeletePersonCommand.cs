using MediatR;

namespace DemoLibrary.Commands
{
    public record DeletePersonCommand(int Id) : IRequest<bool>;    
}
