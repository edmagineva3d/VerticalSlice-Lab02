namespace Application.Features.Admissions.CreateAdmission;

using Application.Abstractions.Messaging;
using Domain.Common;

public sealed record CreateAdmissionCommand(
    Guid StudentId,
    string AcademicYear,
    List<Guid> CourseIds
) : ICommand<Result<CreateAdmissionResponse>>;
