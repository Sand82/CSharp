using DemoLibrary.Models.InputModels;
using DemoLibrary.Models.OutputModels;
using MediatR;

namespace DemoLibrary.Commands
{
    public record CreatePersonCommand(string FirstName, string LastName) : IRequest<CreatePersonOutputModel>;

    //public class CreatePersonCommand : IRequest<CreatePersonOutputModel>
    //{        
    //    public string? FirstName { get; set; }

    //    public string? LastName { get; set; }

    //    public CreatePersonCommand(string firstName, string lastName)
    //    {
    //        this.FirstName = firstName;
    //        this.LastName = lastName;
    //    }
    //}
}
