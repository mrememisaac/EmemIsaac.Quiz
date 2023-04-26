using FluentValidation;

namespace EmemIsaac.QuizManager.Application.Features.Quizzes.Commands.CreateQuiz
{
    public class CreateQuizCommandValidator : AbstractValidator<CreateQuizCommand>
    {
        public CreateQuizCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage(Common.ValidationMessages.RequiredMessage)
                .NotNull()
                .MaximumLength(50).WithMessage(Common.ValidationMessages.MaximumLengthMessage(50));

            RuleFor(p => p.Description)
                .NotEmpty().WithMessage(Common.ValidationMessages.RequiredMessage)
                .NotNull()
                .MaximumLength(50).WithMessage(Common.ValidationMessages.MaximumLengthMessage(250));

            RuleFor(p => p.ImageUri)
                .MaximumLength(50).WithMessage(Common.ValidationMessages.MaximumLengthMessage(250));
        }
    }
}
