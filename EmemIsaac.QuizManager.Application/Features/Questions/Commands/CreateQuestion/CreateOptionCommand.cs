namespace EmemIsaac.QuizManager.Application.Features.Questions.Commands.CreateQuestion
{
    public class CreateOptionCommand
    {
        public string Text { get; set; } = string.Empty;

        public string ImageUri { get; set; } = string.Empty;

        public bool IsAnswer { get; set; }
    }
}
