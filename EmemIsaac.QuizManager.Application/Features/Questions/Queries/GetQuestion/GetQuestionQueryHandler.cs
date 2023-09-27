using AutoMapper;
using EmemIsaac.QuizManager.Application.Contracts.Persistence;
using MediatR;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Queries.GetQuestion
{
    public class GetQuestionQueryHandler : IRequestHandler<GetQuestionQuery, GetQuestionQueryResponse>
    {
        private readonly IQuestionsRepository _questionsRepository;
        private readonly IMapper _mapper;

        public GetQuestionQueryHandler(IQuestionsRepository questionsRepository, IMapper mapper)
        {
            _questionsRepository = questionsRepository;
            _mapper = mapper;
        }

        public async Task<GetQuestionQueryResponse> Handle(GetQuestionQuery request, CancellationToken cancellationToken)
        {
            var validator = new GetQuestionQueryValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
                throw new Common.ValidationException(validationResult);

            var question = await _questionsRepository.GetByIdAsync(request.QuestionId);
            var transformedQuestion = _mapper.Map<GetQuestionDto>(question);
            return new GetQuestionQueryResponse(transformedQuestion);
        }
    }
}
