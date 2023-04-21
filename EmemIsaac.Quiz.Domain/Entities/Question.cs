using EmemIsaac.Quiz.Domain.Common;

namespace EmemIsaac.Quiz.Domain.Entities;

public class Question : AuditableEntity
{
    public Guid SubjectId {get; set; }
    
    public Guid QuestionId {get; set;}

    public string QuestionText {get; set; } = string.Empty;

    public string QuestionImageUri { get; set; } = string.Empty;

}
