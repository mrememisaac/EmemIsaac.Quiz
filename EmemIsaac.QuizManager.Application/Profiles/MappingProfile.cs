using AutoMapper;
using EmemIsaac.QuizManager.Application.Features.Options.Queries.GetQuestionOptions;
using EmemIsaac.QuizManager.Application.Features.Questions.Queries.GetQuizQuestions;
using EmemIsaac.QuizManager.Application.Features.Quizzes.Commands.CreateQuiz;
using EmemIsaac.QuizManager.Application.Features.Quizzes.Commands.DeleteQuiz;
using EmemIsaac.QuizManager.Application.Features.Quizzes.Commands.UpdateQuiz;
using EmemIsaac.QuizManager.Application.Features.Quizzes.Queries.GetUsersQuizzes;
using EmemIsaac.QuizManager.Domain.Entities;

namespace EmemIsaac.QuizManager.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Option, OptionVM>().ReverseMap();
            CreateMap<Question, QuestionVM>().ReverseMap();
            CreateMap<Quiz, QuizVM>().ReverseMap();

            CreateMap<CreateQuizCommand, Quiz>().ReverseMap();
            CreateMap<UpdateQuizCommand, Quiz>().ReverseMap();
            CreateMap<DeleteQuizCommand, Quiz>().ReverseMap();
        }
    }
}
