namespace EmemIsaac.QuizManager.Application.Features.Questions.Commands.UpdateQuestion
{
    public class UpdateQuestionDto
    {
        public Guid QuizId { get; set; }

        public Guid Id { get; set; }

        public string Text { get; set; } = string.Empty;

        public string ImageUri { get; set; } = string.Empty;

        private List<UpdateOptionCommandResponse> Options { get; set; } = new();
    }
}
