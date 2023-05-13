using DemoLibrary.Models.ApiModels;
using MediatR;

namespace DemoLibrary.Queries
{
    public record GetPersonsListQuery() :  IRequest<List<PersonOutputModel>>;  

    //public class GetPersonListQuery : IRequest<List<PersonModel>>
    //{ 
    //}
}
