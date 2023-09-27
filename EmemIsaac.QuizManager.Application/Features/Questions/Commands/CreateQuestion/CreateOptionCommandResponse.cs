namespace EmemIsaac.QuizManager.Application.Features.Questions.Commands.CreateQuestion
{
    public class CreateOptionCommandResponse
    {
        public Guid Id { get; set; }

        public string Text { get; set; } = string.Empty;

        public string ImageUri { get; set; } = string.Empty;

        public bool IsAnswer { get; set; }
    }
}
