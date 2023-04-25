using AutoMapper;
using EmemIsaac.QuizManager.Application.Contracts.Persistence;
using EmemIsaac.QuizManager.Domain.Entities;
using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Quizzes.Commands.CreateQuiz
{
    public class CreateQuizCommandHandler : IRequestHandler<CreateQuizCommand, Guid>
    {
        public readonly IQuizzesRepository _quizzesRepository;
        public readonly IMapper _mapper;

        public CreateQuizCommandHandler(IQuizzesRepository quizzesRepository, IMapper mapper)
        {
            _quizzesRepository = quizzesRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateQuizCommand request, CancellationToken cancellationToken)
        {
            var quiz = _mapper.Map<Quiz>(request);
            quiz = await _quizzesRepository.CreateAsync(quiz);
            return quiz.Id;
        }
    }
}
