using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Quizzes.Commands.DeleteQuiz
{
    public class DeleteQuizCommand : IRequest<DeleteQuizCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
