using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models.OutputModels;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, CreateEditPersonOutputModel>
    {
        private readonly IDataAccess data;

        public CreatePersonCommandHandler(IDataAccess data)
        {
            this.data = data;
        }

        public async Task<CreateEditPersonOutputModel> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var person = data.Insert(request.FirstName, request.LastName);

            var model = new CreateEditPersonOutputModel() 
                { Id = person.Id, FirstName = request.FirstName, LastName = request.LastName };

            return await Task.FromResult(model);
        }
    }
}
