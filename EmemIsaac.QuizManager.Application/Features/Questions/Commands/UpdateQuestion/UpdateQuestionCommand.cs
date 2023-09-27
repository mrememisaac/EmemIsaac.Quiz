using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Commands.UpdateQuestion
{

    public class UpdateQuestionCommand : IRequest<UpdateQuestionCommandResponse>
    {
        public Guid QuizId { get; set; }

        public Guid QuestionId { get; set; }
        
        public string Text { get; set; } = string.Empty;

        public string ImageUri { get; set; } = string.Empty;

        private List<UpdateOptionCommand> Options { get; set; } = new();
    }
}
