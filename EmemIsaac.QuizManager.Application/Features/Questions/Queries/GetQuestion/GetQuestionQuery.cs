using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Queries.GetQuestion
{
    public class GetQuestionQuery : IRequest<GetQuestionQueryResponse>
    {
        public Guid QuizId { get; set; }

        public Guid QuestionId { get; set; }

    }
}
