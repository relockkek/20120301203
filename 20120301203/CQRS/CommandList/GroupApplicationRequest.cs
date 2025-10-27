namespace _20120301203.CQRS.CommandList
{
    public record GroupApplicationRequest(
    DateTime StartDate,
    DateTime EndDate,
    string Purpose,
    int DepartmentId,
    int EmployeeId,
    string ApplicantEmail,
    GroupApplicationInfo ApplicationInfo);

    public record GroupApplicationInfo(
    string contact_name,
    string contact_email,
    string? contact_phone,
    string? organization);
}
