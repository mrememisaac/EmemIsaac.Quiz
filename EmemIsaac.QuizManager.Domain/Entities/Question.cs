using EmemIsaac.QuizManager.Domain.Common;

namespace EmemIsaac.QuizManager.Domain.Entities;

public class Question : AuditableEntity
{
    public const int TextMinLength = 5;
    public const int TextMaxLength = 250;

    public const int ImageUriMinLength = 5;
    public const int ImageUriMaxLength = 350;

    public Guid QuizId {get; set; }
    
    public Guid Id {get; set;}

    public string Text {get; set; } = string.Empty;

    public string ImageUri { get; set; } = string.Empty;

    private List<Option> _options { get; set; } = new();

    public virtual IReadOnlyList<Option> Options => _options.AsReadOnly();
}
