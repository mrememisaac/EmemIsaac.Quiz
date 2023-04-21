﻿using AutoMapper;
using EmemIsaac.Quiz.Application.Contracts.Persistence;
using MediatR;

namespace EmemIsaac.Quiz.Application.Features.Questions
{
    public class GetQuestionsQueryHandler : IRequestHandler<GetQuestionsQuery, List<QuestionVM>>
    {
        private readonly IQuestionsRepository _QuestionsRepository;
        private readonly IMapper _mapper;

        public GetQuestionsQueryHandler(IQuestionsRepository QuestionsRepository, IMapper mapper)
        {
            _QuestionsRepository = QuestionsRepository;
            _mapper = mapper;
        }

        public async Task<List<QuestionVM>> Handle(GetQuestionsQuery request, CancellationToken cancellationToken)
        {
            var Questions = await _QuestionsRepository.GetBySubjectAsync(request.SubjectId);
            return _mapper.Map<List<QuestionVM>>(Questions);
        }
    }
}
