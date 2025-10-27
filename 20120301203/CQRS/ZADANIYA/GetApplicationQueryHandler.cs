using _20120301203.CQRS.CommandList;
using _20120301203.DB;
using Microsoft.EntityFrameworkCore;
using MyMediator.Interfaces;
using System.Security.Cryptography;

namespace _20120301203.CQRS.ZADANIYA
{
    public record GetApplicationQuery(string GroupTitle) : IRequest<List<ApplicationDto>>;
    public class GetApplicationQueryHandler : IRequestHandler<GetApplicationQuery, List<ApplicationDto>>
    {
        private readonly _201025Context _context;
        public GetApplicationQueryHandler(_201025Context context)
        {
            _context = context;
        }
        public async Task<List<ApplicationDto>> HandleAsync(GetApplicationQuery request, CancellationToken cancellationToken)
        {
            return await _context.Applications
                .Select(s => new ApplicationDto
                {
                    Id = s.Id,
                    ApplicationType = s.ApplicationType,
                    Department = s.Department,
                    StartDate = s.StartDate,
                    EndDate = s.EndDate,
                    Status = s.Status,
                    RejectionReason = s.RejectionReason
                })
                .ToListAsync(cancellationToken);
        }
    }
}

