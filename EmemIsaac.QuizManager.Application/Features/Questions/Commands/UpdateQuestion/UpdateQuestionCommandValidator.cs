using EmemIsaac.QuizManager.Domain.Entities;
using FluentValidation;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Commands.UpdateQuestion
{
    public class UpdateQuestionCommandValidator : AbstractValidator<UpdateQuestionCommand>
    {
        public UpdateQuestionCommandValidator()
        {
            RuleFor(p => p.Text)
               .NotEmpty().WithMessage(Common.ValidationMessages.RequiredMessage)
               .NotNull()
               .MinimumLength(Question.TextMinLength).WithMessage(Common.ValidationMessages.MinimumLengthMessage(Question.TextMinLength))
               .MaximumLength(Question.TextMaxLength).WithMessage(Common.ValidationMessages.MaximumLengthMessage(Question.TextMaxLength));

            RuleFor(p => p.ImageUri)
                .MaximumLength(Question.ImageUriMaxLength).WithMessage(Common.ValidationMessages.MaximumLengthMessage(Question.ImageUriMaxLength));
        }
    }
}
