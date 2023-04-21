namespace EmemIsaac.Quiz.Application.Features.Subjects;

public class SubjectVM
{
    public Guid SubjectId { get; set; }

    public string SubjectName { get; set; } = string.Empty;

    public string SubjectDescription { get; set; } = string.Empty;

    public string SubjectImageUri { get; set; } = string.Empty;

}
