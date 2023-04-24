using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Queries.GetQuizQuestions
{
    public class GetQuestionsQuery : IRequest<List<QuestionVM>>
    {
        public Guid SubjectId { get; set; }
    }
}
