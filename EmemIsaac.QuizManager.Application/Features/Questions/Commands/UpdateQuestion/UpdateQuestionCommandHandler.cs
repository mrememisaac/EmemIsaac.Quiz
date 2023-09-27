using AutoMapper;
using EmemIsaac.QuizManager.Application.Contracts.Persistence;
using EmemIsaac.QuizManager.Domain.Entities;
using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Commands.UpdateQuestion
{
    public class UpdateQuestionCommandHandler : IRequestHandler<UpdateQuestionCommand, UpdateQuestionCommandResponse>
    {
        private readonly IQuestionsRepository _questionsRepository;
        private readonly IMapper _mapper;

        public UpdateQuestionCommandHandler(IQuestionsRepository questionsRepository, IMapper mapper)
        {
            _questionsRepository = questionsRepository;
            _mapper = mapper;
        }

        public async Task<UpdateQuestionCommandResponse> Handle(UpdateQuestionCommand request, CancellationToken cancellationToken)
        {
            var question = _mapper.Map<Question>(request);

            var validator = new UpdateQuestionCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
                throw new Common.ValidationException(validationResult);

            await _questionsRepository.UpdateAsync(question);
            var newQuestion = _mapper.Map<UpdateQuestionDto>(question);
            return new UpdateQuestionCommandResponse(question: newQuestion);
        }
    }
}
