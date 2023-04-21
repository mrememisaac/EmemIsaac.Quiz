using AutoMapper;
using EmemIsaac.Quiz.Application.Contracts.Persistence;
using MediatR;

namespace EmemIsaac.Quiz.Application.Features.Subjects;

public class GetSubjectsQueryHandler : IRequestHandler<GetSubjectsQuery, List<SubjectVM>>
{
    private readonly ISubjectsRepository _subjectRepository;
    private readonly IMapper _mapper;

    public GetSubjectsQueryHandler(ISubjectsRepository subjectRepository, IMapper mapper)
    {
        _subjectRepository = subjectRepository;
        _mapper = mapper;
    }

    public async Task<List<SubjectVM>> Handle(GetSubjectsQuery request, CancellationToken cancellationToken)
    {
        var subjects = (await _subjectRepository.GetSubjectsByCreatorAsync(request.CreatorUserId));
        return _mapper.Map<List<SubjectVM>>(subjects);
    }
}