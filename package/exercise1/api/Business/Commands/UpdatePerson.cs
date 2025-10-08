using System.Net;
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
        public required string NewName { get; set; } = string.Empty;
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
            //  - check that both name fields are not empty - return bad request
            if (string.IsNullOrWhiteSpace(request.Name)) throw new BadHttpRequestException("The [Name] field cannot be empty");
            if (string.IsNullOrWhiteSpace(request.NewName)) throw new BadHttpRequestException("The [NewName] field cannot be empty");

            //  - check that new name doesn't exist in db - return bad request
            Person? oldPerson = _context.People.FirstOrDefault(p => p.Name == request.Name);
            if (oldPerson is null) throw new BadHttpRequestException($"Could not find a record for [{request.Name}] to update");

            Person ? newPerson = _context.People.FirstOrDefault(p => p.Name == request.NewName);
            if (oldPerson is not null) throw new BadHttpRequestException($"A record for [{request.NewName}] already exists");

            return Task.CompletedTask;
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
            if (p is null) throw new BadHttpRequestException($"Could not find [{request.Name}]");

            Person? pNew = _context.People.Where(p => p.Name == request.NewName).FirstOrDefault();
            if (pNew != null) throw new BadHttpRequestException($"The new name [{request.NewName}] is already in use");

            p.Name = request.NewName;
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