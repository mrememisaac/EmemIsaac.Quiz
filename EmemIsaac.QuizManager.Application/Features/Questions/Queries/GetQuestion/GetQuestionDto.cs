using EmemIsaac.QuizManager.Application.Features.Questions.Commands.CreateQuestion;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Queries.GetQuestion
{
    public class GetQuestionDto
    {
        public Guid QuizId { get; set; }

        public string Text { get; set; } = string.Empty;

        public string ImageUri { get; set; } = string.Empty;

        private List<CreateOptionCommand> Options { get; set; } = new();
    }
}
