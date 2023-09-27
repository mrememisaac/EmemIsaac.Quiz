using EmemIsaac.QuizManager.Application.Responses;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Commands.CreateQuestion
{
    public class CreateQuestionCommandResponse : BaseResponse
    {
        public CreateQuestionDto? Question { get; }

        public CreateQuestionCommandResponse(bool success = true, string message = "", CreateQuestionDto? question = null) : base(success, message)
        {
            Question = question;
        }

        public CreateQuestionCommandResponse(IList<string> errors) : base(errors) { }
    }
}
