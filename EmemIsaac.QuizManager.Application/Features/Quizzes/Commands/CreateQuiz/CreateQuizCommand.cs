using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Quizzes.Commands.CreateQuiz
{
    public class CreateQuizCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImageUri { get; set; } = string.Empty;
    }
}
