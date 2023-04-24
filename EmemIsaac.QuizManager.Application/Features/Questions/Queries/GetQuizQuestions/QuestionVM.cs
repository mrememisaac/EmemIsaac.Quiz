using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmemIsaac.QuizManager.Application.Features.Questions.Queries.GetQuizQuestions
{
    public class QuestionVM
    {
        public Guid QuizId { get; set; }

        public Guid Id { get; set; }

        public string QuestionText { get; set; } = string.Empty;

        public string QuestionImageUri { get; set; } = string.Empty;
    }
}
