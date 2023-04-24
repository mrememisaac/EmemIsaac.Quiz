using EmemIsaac.QuizManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmemIsaac.QuizManager.Application.Features.Options.Queries.GetQuestionOptions
{

    public class OptionVM
    {
        public Guid QuestionId { get; set; }

        public Guid OptionId { get; set; }

        public string OptionText { get; set; } = string.Empty;

        public string OptionImageUri { get; set; } = string.Empty;

        public bool IsAnswer { get; set; }

        public string? OptionType { get; set; }
    }
}
