using AutoMapper;
using EmemIsaac.QuizManager.Application.Contracts.Persistence;
using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Quizzes.Commands.UpdateQuiz
{
    public class UpdateQuizCommandHandler : IRequestHandler<UpdateQuizCommand>
    {
        private readonly IQuizzesRepository _quizzesRepository;
        private readonly IMapper _mapper;

        public UpdateQuizCommandHandler(IQuizzesRepository quizzesRepository, IMapper mapper)
        {
            _quizzesRepository= quizzesRepository;
            _mapper= mapper;
        }

        public async Task Handle(UpdateQuizCommand request, CancellationToken cancellationToken)
        {
            var quiz = await _quizzesRepository.GetByIdAsync(request.Id);
            _mapper.Map(request, quiz, typeof(UpdateQuizCommand), typeof(UpdateQuizCommand));
            await _quizzesRepository.UpdateAsync(quiz);
            return Unit.Value;
        }
    }
}
