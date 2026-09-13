namespace Application.Features.Admissions.CreateAdmission;

public sealed record CreateAdmissionResponse(
    Guid Id,
    Guid StudentId,
    string AcademicYear,
    DateTime AdmissionDate,
    List<CourseResponse> Courses
);

public sealed record CourseResponse(
    Guid Id,
    string Title,
    string Code
);
