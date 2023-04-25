using EmemIsaac.QuizManager.Application.Responses;

namespace EmemIsaac.QuizManager.Application.Features.Quizzes.Commands.CreateQuiz
{
    public class CreateQuizCommandResponse : BaseResponse
    {
        public CreateQuizDto? Quiz { get;  }

        public CreateQuizCommandResponse(bool success = true, string message = "", CreateQuizDto? quiz = null) : base(success, message) 
        {
            Quiz = quiz;
        }

        public CreateQuizCommandResponse(IList<string> errors) : base(errors) { }

    }
}
