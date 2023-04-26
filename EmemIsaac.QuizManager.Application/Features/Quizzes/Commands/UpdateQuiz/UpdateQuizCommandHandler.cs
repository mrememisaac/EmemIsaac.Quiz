using AutoMapper;
using EmemIsaac.QuizManager.Application.Contracts.Persistence;
using EmemIsaac.QuizManager.Domain.Entities;
using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Quizzes.Commands.UpdateQuiz
{
    public class UpdateQuizCommandHandler : IRequestHandler<UpdateQuizCommand, UpdateQuizCommandResponse>
    {
        private readonly IQuizzesRepository _quizzesRepository;
        private readonly IMapper _mapper;

        public UpdateQuizCommandHandler(IQuizzesRepository quizzesRepository, IMapper mapper)
        {
            _quizzesRepository= quizzesRepository;
            _mapper= mapper;
        }

        public async Task<UpdateQuizCommandResponse> Handle(UpdateQuizCommand request, CancellationToken cancellationToken)
        {
            var quiz = await _quizzesRepository.GetByIdAsync(request.Id);
            _mapper.Map(request, quiz, typeof(UpdateQuizCommand), typeof(Quiz));
            await _quizzesRepository.UpdateAsync(quiz);
            return new UpdateQuizCommandResponse();
        }
    }
}
