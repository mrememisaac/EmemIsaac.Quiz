using MediatR;

namespace EmemIsaac.Quiz.Application.Features.Options
{
    public class GetOptionsQuery : IRequest<List<OptionVM>>
    {
        public Guid QuestionId { get; set; }
    }
}
