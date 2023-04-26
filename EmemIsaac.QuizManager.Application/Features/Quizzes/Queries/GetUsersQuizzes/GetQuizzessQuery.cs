using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Quizzes.Queries.GetUsersQuizzes;

public class GetQuizzessQuery : IRequest<List<QuizVM>>
{
    public string CreatorUserId { get; set; } = string.Empty;
}
