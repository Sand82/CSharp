using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Models.ApiModels;
using DemoLibrary.Queries;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonOutputModel>>
    {
        private readonly IDataAccess data;

        public GetPersonListHandler(IDataAccess data)
        {
            this.data = data;
        }

        public Task<List<PersonOutputModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            var persons = data.GetAll();

            var models = persons
                .Select(p => new PersonOutputModel { FirstName = p.FirstName, LastName = p.LastName })
                .ToList();

            return Task.FromResult(models);
        }
    }
}
