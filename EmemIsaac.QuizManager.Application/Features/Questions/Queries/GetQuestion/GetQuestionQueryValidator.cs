using FluentValidation;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Queries.GetQuestion
{
    public class GetQuestionQueryValidator : AbstractValidator<GetQuestionQuery>
    {
        public GetQuestionQueryValidator()
        {
            RuleFor(p => p.QuestionId)
                .NotEmpty()
                .WithMessage(Common.ValidationMessages.RequiredMessage);
        }
    }
}
