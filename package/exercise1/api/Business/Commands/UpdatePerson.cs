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
        private readonly StargateContext _context;

        public UpdatePersonHandler(StargateContext context)
        {
            _context = context;
        }

        public async Task<UpdatePersonResult> Handle(UpdatePerson request, CancellationToken cancellationToken)
        {
            Person? p = _context.People.Where(p => p.Name == request.Name).FirstOrDefault();
            if (p is null) throw new InvalidDataException($"Could not find [{request.Name}]");

            Person? pNew = _context.People.Where(p => p.Name == request.newName).FirstOrDefault();
            if (pNew != null) throw new InvalidDataException($"The new name [{request.newName}] is already in use");

            p.Name = request.newName;
            _context.People.Update(p);
            await _context.SaveChangesAsync();

            return new UpdatePersonResult()
            {
                Id = p.Id
            };
        }
    }

    public class UpdatePersonResult : BaseResponse
    {
        public int Id { get; set; }
    }
}