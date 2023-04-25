using AutoMapper;
using EmemIsaac.QuizManager.Application.Contracts.Persistence;
using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Quizzes.Commands.DeleteQuiz
{
    public class DeleteQuizCommandHandler : IRequestHandler<DeleteQuizCommand, DeleteQuizCommandResponse>
    {
        private readonly IQuizzesRepository _quizzesRepository;
        
        private readonly IMapper _mapper;

        public DeleteQuizCommandHandler(IQuizzesRepository quizzesRepository, IMapper mapper)
        {
            _quizzesRepository = quizzesRepository;
            _mapper = mapper;
        }
        
        public async Task<DeleteQuizCommandResponse> Handle(DeleteQuizCommand request, CancellationToken cancellationToken)
        {
            var quiz = await _quizzesRepository.GetByIdAsync(request.Id);
            await _quizzesRepository.DeleteAsync(quiz);
            return new DeleteQuizCommandResponse();
        }
    }
}
