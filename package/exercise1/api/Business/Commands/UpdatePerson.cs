using MediatR;
using MediatR.Pipeline;
using Microsoft.EntityFrameworkCore;
using StargateAPI.Business.Data;
using StargateAPI.Controllers;

namespace StargateAPI.Business.Commands
{
    public class UpdatePerson : IRequest<UpdatePersonResult>
    {
        public required string Name { get; set; } = string.Empty;
        public required string newName { get; set; } = string.Empty;
    }

    public class UpdatePersonPreProcessor : IRequestPreProcessor<UpdatePerson>
    {
        private readonly StargateContext _context;
        public UpdatePersonPreProcessor(StargateContext context)
        {
            _context = context;
        }

        public Task Process(UpdatePerson request, CancellationToken cancellationToken)
        {
            // todo: 
            //  - check that both name fields are not empty - return bad request
            //  - check that new name doesn't exist in db - return bad request
            throw new NotImplementedException();
        }
    }

    public class UpdatePersonHandler : IRequestHandler<UpdatePerson, UpdatePersonResult>
    {
        public Task<UpdatePersonResult> Handle(UpdatePerson request, CancellationToken cancellationToken)
        {
            // todo:
            //  - make update to person name
            throw new NotImplementedException();
        }
    }

    public class UpdatePersonResult : BaseResponse
    {
        public int Id { get; set; }
    }
}