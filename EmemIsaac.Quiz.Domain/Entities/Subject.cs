using EmemIsaac.Quiz.Domain.Common;

namespace EmemIsaac.Quiz.Domain.Entities;

public class Subject : AuditableEntity
{
    public Guid SubjectId {get; set; }

    public string SubjectName {get; set; } = string.Empty;

    public string SubjectDescription {get; set; } = string.Empty;

    public string SubjectImageUri { get; set; } = string.Empty;

}
