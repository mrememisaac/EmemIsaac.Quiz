using AutoMapper;
using EmemIsaac.QuizManager.Application.Contracts.Persistence;
using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Quizzes.Queries.GetUsersQuizzes;

public class GetQuizzesQueryHandler : IRequestHandler<GetQuizzessQuery, List<QuizVM>>
{
    private readonly IQuizzesRepository _subjectRepository;
    private readonly IMapper _mapper;

    public GetQuizzesQueryHandler(IQuizzesRepository subjectRepository, IMapper mapper)
    {
        _subjectRepository = subjectRepository;
        _mapper = mapper;
    }

    public async Task<List<QuizVM>> Handle(GetQuizzessQuery request, CancellationToken cancellationToken)
    {
        var subjects = await _subjectRepository.GetQuizzessByCreatorAsync(request.CreatorUserId);
        return _mapper.Map<List<QuizVM>>(subjects);
    }
}