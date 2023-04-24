namespace EmemIsaac.QuizManager.Application.Features.Quizzes.Queries.GetUsersQuizzes;

public class QuizVM
{
    public Guid SubjectId { get; set; }

    public string SubjectName { get; set; } = string.Empty;

    public string SubjectDescription { get; set; } = string.Empty;

    public string SubjectImageUri { get; set; } = string.Empty;

}
