using AutoMapper;
using EmemIsaac.QuizManager.Application.Common;
using EmemIsaac.QuizManager.Application.Contracts.Persistence;
using EmemIsaac.QuizManager.Domain.Entities;
using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Quizzes.Commands.CreateQuiz
{
    public class CreateQuizCommandHandler : IRequestHandler<CreateQuizCommand, CreateQuizCommandResponse>
    {
        public readonly IQuizzesRepository _quizzesRepository;

        public readonly IMapper _mapper;

        public CreateQuizCommandHandler(IQuizzesRepository quizzesRepository, IMapper mapper)
        {
            _quizzesRepository = quizzesRepository;
            _mapper = mapper;
        }

        public async Task<CreateQuizCommandResponse> Handle(CreateQuizCommand request, CancellationToken cancellationToken)
        {
            var quiz = _mapper.Map<Quiz>(request);

            var validator = new CreateQuizCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);
            
            quiz = await _quizzesRepository.CreateAsync(quiz);
            var newQuiz = _mapper.Map<CreateQuizDto>(quiz);
            return new CreateQuizCommandResponse(quiz:newQuiz);
        }
    }
}
