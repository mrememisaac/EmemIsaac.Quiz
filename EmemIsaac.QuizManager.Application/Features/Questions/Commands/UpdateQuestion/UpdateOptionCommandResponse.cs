namespace EmemIsaac.QuizManager.Application.Features.Questions.Commands.UpdateQuestion
{
    public class UpdateOptionCommandResponse
    {
        public Guid Id { get; set; }

        public string Text { get; set; } = string.Empty;

        public string ImageUri { get; set; } = string.Empty;

        public bool IsAnswer { get; set; }
    }
}
