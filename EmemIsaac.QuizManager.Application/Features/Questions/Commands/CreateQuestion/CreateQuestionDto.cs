namespace EmemIsaac.QuizManager.Application.Features.Questions.Commands.CreateQuestion
{
    public class CreateQuestionDto
    {
        public Guid QuizId { get; set; }

        public Guid Id { get; set; }

        public string Text { get; set; } = string.Empty;

        public string ImageUri { get; set; } = string.Empty;

        private List<CreateOptionCommandResponse> Options { get; set; } = new();
    }
}
