namespace Application.Features.Admissions.GetAdmissionById;

using Application.Abstractions.Messaging;
using Domain.Common;

public sealed record GetAdmissionByIdQuery(Guid Id) : IQuery<Result<GetAdmissionByIdResponse>>;
