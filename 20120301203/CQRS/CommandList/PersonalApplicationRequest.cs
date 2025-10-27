using _20120301203.DB;

namespace _20120301203.CQRS.CommandList
{
    public class PersonalApplicationRequest(
    DateTime StartDate,
    DateTime EndDate,
    string Purpose,
    int DepartmentId,
    int EmployeeId,
    string ApplicantEmail,
    PersonalVisitorInfo VisitorInfo);

    public record PersonalVisitorInfo(
    string LastName,
    string FirstName,
    string Phone,
    string Email,
    string? Organization,
    DateTime BirthDate,
    string? PassportSeries,
    string? PassportNumber
    );
}
