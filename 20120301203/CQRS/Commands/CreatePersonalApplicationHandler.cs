using _20120301203.CQRS.CommandList;
using _20120301203.DB;
using MyMediator.Interfaces;

namespace _20120301203.CQRS.Commands
{
    public class CreatePersonalApplicationHandler : IRequestHandler<PersonalApplicationRequest, int>
    {
        private readonly _201025Context _context;

        public CreatePersonalApplicationHandler(_201025Context context)
        {
            _context = context;
        }

        public async Task<int> Handle(PersonalApplicationRequest request, CancellationToken cancellationToken)
        {

            var departmentExists = await _context.Departments.AnyAsync(d => d.Id == request.DepartmentId);
            var employeeExists = await _context.Employees.AnyAsync(e => e.Id == request.EmployeeId);

            if (!departmentExists || !employeeExists)
                throw new ArgumentException("Department or Employee not found");

            var application = new Application
            {
                ApplicationType = "personal",
                Status = "pending",
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                Purpose = request.Purpose,
                DepartmentId = request.DepartmentId,
                EmployeeId = request.EmployeeId,
                ApplicantEmail = request.ApplicantEmail,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _context.Applications.Add(application);
            await _context.SaveChangesAsync(cancellationToken);


            var personalVisitor = new PersonalVisitor
            {
                ApplicationId = application.Id,
                LastName = request.LastName,
                FirstName = request.FirstName,
                Phone = request.Phone,
                Email = request.Email,
                Organization = request.Organization,
                BirthDate = request.BirthDate,
                PassportSeries = request.PassportSeries,
                PassportNumber = request.PassportNumber
            };

            _context.PersonalVisitors.Add(personalVisitor);
            await _context.SaveChangesAsync(cancellationToken);

            return application.Id;
        }
    }
}