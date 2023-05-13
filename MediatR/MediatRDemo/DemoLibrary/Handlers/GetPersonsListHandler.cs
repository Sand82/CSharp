using DemoLibrary.DataAccess;
using DemoLibrary.Models.ApiModels;
using DemoLibrary.Queries;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class GetPersonsListHandler : IRequestHandler<GetPersonsListQuery, List<PersonOutputModel>>
    {
        private readonly IDataAccess data;

        public GetPersonsListHandler(IDataAccess data)
        {
            this.data = data;
        }

        public Task<List<PersonOutputModel>> Handle(GetPersonsListQuery request, CancellationToken cancellationToken)
        {
            var persons = data.GetAll();

            var models = persons
                .Select(p => new PersonOutputModel { FirstName = p.FirstName, LastName = p.LastName })
                .ToList();

            return Task.FromResult(models);
        }
    }
}
