using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models.OutputModels;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class EditPersonCommandHandler : IRequestHandler<EditPersonCommand, CreateEditPersonOutputModel>
    {
        private readonly IDataAccess data;

        public EditPersonCommandHandler(IDataAccess data)
        {
            this.data = data;
        }

        public async Task<CreateEditPersonOutputModel> Handle(EditPersonCommand request, CancellationToken cancellationToken)
        {
            var person = data.FindById(request.Id);

            if (person == null)
            {
                throw new ArgumentException($"Person with id {request.Id} don't exist.");
            }

            var editPerson = data.Edit(request.FirstName, request.LastName, person);

            var model = new CreateEditPersonOutputModel { Id = editPerson.Id, FirstName = editPerson.FirstName, LastName = editPerson.LastName };

            return model;
        }
    }
}
