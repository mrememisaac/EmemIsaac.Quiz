using FluentValidation;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Commands.DeleteQuestion
{
    public class DeleteQuestionCommandValidator : AbstractValidator<DeleteQuestionCommand>
    {
        public DeleteQuestionCommandValidator()
        {
            RuleFor(p => p.QuestionId)
               .NotEmpty().WithMessage(Common.ValidationMessages.RequiredMessage);
        }
    }
}
