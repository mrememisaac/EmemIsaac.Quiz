using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmemIsaac.Quiz.Application.Features.Questions
{
    public class QuestionVM
    {
        public Guid SubjectId { get; set; }

        public Guid QuestionId { get; set; }

        public string QuestionText { get; set; } = string.Empty;

        public string QuestionImageUri { get; set; } = string.Empty;
    }
}
