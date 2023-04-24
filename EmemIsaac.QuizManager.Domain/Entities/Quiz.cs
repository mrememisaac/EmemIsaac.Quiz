using EmemIsaac.QuizManager.Domain.Common;

namespace EmemIsaac.QuizManager.Domain.Entities;

public class Quiz : AuditableEntity
{
    public Guid Id {get; set; }

    public string Topic {get; set; } = string.Empty;

    public string Description {get; set; } = string.Empty;

    public string ImageUri { get; set; } = string.Empty;

}
