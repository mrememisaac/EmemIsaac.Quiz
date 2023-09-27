using EmemIsaac.QuizManager.Domain.Common;

namespace EmemIsaac.QuizManager.Domain.Entities;

public class Subject : AuditableEntity
{
    public const int NameMinLength = 3;

    public const int NameMaxLength = 250;

    public Guid Id { get; set; }

    public string Name { get; set; }
}
