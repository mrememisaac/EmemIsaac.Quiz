using AutoMapper;
using EmemIsaac.Quiz.Application.Contracts.Persistence;
using MediatR;

namespace EmemIsaac.Quiz.Application.Features.Options
{
    public class GetOptionsQueryHandler : IRequestHandler<GetOptionsQuery, List<OptionVM>>
    {
        private readonly IOptionsRepository _optionsRepository;
        private readonly IMapper _mapper;

        public GetOptionsQueryHandler(IOptionsRepository optionsRepository, IMapper mapper)
        {
            _optionsRepository = optionsRepository;
            _mapper = mapper;
        }

        public async Task<List<OptionVM>> Handle(GetOptionsQuery request, CancellationToken cancellationToken)
        {
            var options = (await _optionsRepository.GetByQuestionAsync(request.QuestionId));
            return _mapper.Map<List<OptionVM>>(options);
        }
    }
}
