using MediatR;

namespace EmemIsaac.Quiz.Application.Features.Questions
{
    public class GetQuestionsQuery : IRequest<List<QuestionVM>>
    {
        public Guid SubjectId { get; set; }
    }
}
