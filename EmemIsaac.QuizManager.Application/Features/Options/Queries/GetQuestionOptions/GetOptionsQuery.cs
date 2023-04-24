using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Options.Queries.GetQuestionOptions
{
    public class GetOptionsQuery : IRequest<List<OptionVM>>
    {
        public Guid QuestionId { get; set; }
    }
}
