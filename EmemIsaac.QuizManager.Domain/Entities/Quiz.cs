using EmemIsaac.QuizManager.Domain.Common;

namespace EmemIsaac.QuizManager.Domain.Entities;

public class Quiz : AuditableEntity
{
    public const int TopicMinLength = 4;
    public const int TopicMaxLength = 250;

    public const int DescriptionMinLength = 10;
    public const int DescriptionMaxLength = 500;

    public const int ImageUriMinLength = 5;
    public const int ImageUriMaxLength = 350;

    public Guid Id {get; set; }

    public string Topic {get; set; } = string.Empty;

    public string Description {get; set; } = string.Empty;

    public string ImageUri { get; set; } = string.Empty;

    private List<Question> _questions { get; set; } = new();

    public virtual IReadOnlyList<Question> Options => _questions.AsReadOnly();

}
