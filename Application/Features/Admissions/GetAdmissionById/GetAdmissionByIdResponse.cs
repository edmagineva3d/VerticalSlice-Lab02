namespace Application.Features.Admissions.GetAdmissionById;

public sealed record GetAdmissionByIdResponse(
    Guid Id,
    Guid StudentId,
    string StudentName,
    string AcademicYear,
    DateTime AdmissionDate,
    List<CourseResponse> Courses
);

public sealed record CourseResponse(
    Guid Id,
    string Title,
    string Code,
    int Credits
);
