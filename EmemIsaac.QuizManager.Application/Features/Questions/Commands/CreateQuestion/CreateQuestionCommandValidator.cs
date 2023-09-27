using EmemIsaac.QuizManager.Application.Common;
using EmemIsaac.QuizManager.Domain.Entities;
using FluentValidation;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Commands.CreateQuestion
{
    public class CreateQuestionCommandValidator : AbstractValidator<CreateQuestionCommand>
    {
        public CreateQuestionCommandValidator()
        {
            RuleFor(p => p.Text)
               .NotEmpty().WithMessage(ValidationMessages.RequiredMessage)
               .NotNull()
               .MinimumLength(Question.TextMinLength).WithMessage(ValidationMessages.MinimumLengthMessage(Question.TextMinLength))
               .MaximumLength(Question.TextMaxLength).WithMessage(ValidationMessages.MaximumLengthMessage(Question.TextMaxLength));

            RuleFor(p => p.ImageUri)
                .MaximumLength(Question.ImageUriMaxLength).WithMessage(ValidationMessages.MaximumLengthMessage(Question.ImageUriMaxLength));
        }
    }
}
