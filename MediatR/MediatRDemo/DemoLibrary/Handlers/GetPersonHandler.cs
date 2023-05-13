using DemoLibrary.DataAccess;
using DemoLibrary.Models.ApiModels;
using DemoLibrary.Queries;
using MediatR;
using System.Linq;

namespace DemoLibrary.Handlers
{
    public class GetPersonHandler : IRequestHandler<GetPersonQuery, PersonOutputModel>
    {
        private readonly IDataAccess data;

        public GetPersonHandler(IDataAccess data)
        {
            this.data = data;
        }

        public async Task<PersonOutputModel> Handle(GetPersonQuery request, CancellationToken cancellationToken)
        {
            var person = data.FindById(request.id);

            var model = new PersonOutputModel { FirstName = person?.FirstName, LastName = person?.LastName };

            return await Task.FromResult(model);
        }
    }
}
