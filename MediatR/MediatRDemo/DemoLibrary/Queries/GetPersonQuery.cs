using DemoLibrary.Models.ApiModels;
using MediatR;

namespace DemoLibrary.Queries
{
    public record GetPersonQuery(int id) : IRequest<PersonOutputModel>;

    //public class GetPersonQuery : IRequest<PersonOutputModel>
    //{
    //    public int Id { get; set; }
    //}
}
