using AutoMapper;
using EmemIsaac.QuizManager.Application.Contracts.Persistence;
using EmemIsaac.QuizManager.Domain.Entities;
using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Commands.CreateQuestion
{
    public class CreateQuestionCommandHandler : IRequestHandler<CreateQuestionCommand, CreateQuestionCommandResponse>
    {
        private readonly IQuestionsRepository _questionsRepository;
        private readonly IMapper _mapper;

        public CreateQuestionCommandHandler(IQuestionsRepository questionsRepository, IMapper mapper)
        {
            _questionsRepository = questionsRepository;
            _mapper = mapper;
        }

        public async Task<CreateQuestionCommandResponse> Handle(CreateQuestionCommand request, CancellationToken cancellationToken)
        {
            var question = _mapper.Map<Question>(request);

            var validator = new CreateQuestionCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
                throw new Common.ValidationException(validationResult);

            question = await _questionsRepository.CreateAsync(question);
            var newQuestion = _mapper.Map<CreateQuestionDto>(question);
            return new CreateQuestionCommandResponse(question: newQuestion);
        }
    }
}
