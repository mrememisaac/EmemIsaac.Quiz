using MediatR;

namespace EmemIsaac.Quiz.Application.Features.Subjects;

public class GetSubjectsQuery : IRequest<List<SubjectVM>>
{
    public string? CreatorUserId { get; set; }
}
