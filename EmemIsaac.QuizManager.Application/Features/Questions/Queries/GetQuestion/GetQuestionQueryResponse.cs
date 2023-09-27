using EmemIsaac.QuizManager.Application.Responses;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Queries.GetQuestion
{
    public class GetQuestionQueryResponse : BaseResponse
    {
        public GetQuestionDto Question { get; set; }

        public GetQuestionQueryResponse(GetQuestionDto question, bool status = true, string message = "") : base(status, message)
        {
            Question = question;
        }

        public GetQuestionQueryResponse(IList<string> errors) : base(errors) { }
    }
}
