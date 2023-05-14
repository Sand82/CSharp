using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class DeletePersonCommandHandler : IRequestHandler<DeletePersonCommand, bool>
    {
        private readonly IDataAccess data;

        public DeletePersonCommandHandler(IDataAccess data)
        {
            this.data = data;
        }

        public async Task<bool> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(data.Delete(request.Id));
        }
    }
}
