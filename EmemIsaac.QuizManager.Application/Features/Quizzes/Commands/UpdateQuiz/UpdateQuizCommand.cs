using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Quizzes.Commands.UpdateQuiz
{
    public class UpdateQuizCommand : IRequest
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImageUri { get; set; } = string.Empty;
    }
}
