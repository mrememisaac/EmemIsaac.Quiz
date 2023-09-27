using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Commands.DeleteQuestion
{

    public class DeleteQuestionCommand : IRequest<DeleteQuestionCommandResponse>
    {
        public Guid QuestionId { get; set; }

    }
}
