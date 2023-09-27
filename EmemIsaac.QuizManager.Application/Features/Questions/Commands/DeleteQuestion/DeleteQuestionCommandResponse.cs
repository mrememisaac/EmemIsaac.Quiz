using EmemIsaac.QuizManager.Application.Responses;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Commands.DeleteQuestion
{
    public class DeleteQuestionCommandResponse : BaseResponse
    {
        public DeleteQuestionCommandResponse(bool success = true, string message = "") : base(success, message)
        {
        }

        public DeleteQuestionCommandResponse(IList<string> errors) : base(errors) { }
    }
}
