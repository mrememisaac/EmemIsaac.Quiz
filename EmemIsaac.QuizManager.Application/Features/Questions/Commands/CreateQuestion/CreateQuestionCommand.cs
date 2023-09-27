using EmemIsaac.QuizManager.Application.Features.Quizzes.Commands.CreateQuiz;
using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Commands.CreateQuestion
{

    public class CreateQuestionCommand : IRequest<CreateQuestionCommandResponse>
    {
        public Guid QuizId { get; set; }

        public string Text { get; set; } = string.Empty;

        public string ImageUri { get; set; } = string.Empty;

        private List<CreateOptionCommand> Options { get; set; } = new();
    }
}
