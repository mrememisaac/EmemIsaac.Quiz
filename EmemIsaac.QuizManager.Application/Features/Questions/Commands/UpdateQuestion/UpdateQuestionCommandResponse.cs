using EmemIsaac.QuizManager.Application.Responses;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Commands.UpdateQuestion
{
    public class UpdateQuestionCommandResponse : BaseResponse
    {
        public UpdateQuestionDto? Question { get; }

        public UpdateQuestionCommandResponse(bool success = true, string message = "", UpdateQuestionDto? question = null) : base(success, message)
        {
            Question = question;
        }

        public UpdateQuestionCommandResponse(IList<string> errors) : base(errors) { }
    }
}
