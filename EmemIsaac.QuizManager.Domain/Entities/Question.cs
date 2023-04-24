using EmemIsaac.QuizManager.Domain.Common;

namespace EmemIsaac.QuizManager.Domain.Entities;

public class Question : AuditableEntity
{
    public Guid QuizId {get; set; }
    
    public Guid Id {get; set;}

    public string Text {get; set; } = string.Empty;

    public string ImageUri { get; set; } = string.Empty;

}
