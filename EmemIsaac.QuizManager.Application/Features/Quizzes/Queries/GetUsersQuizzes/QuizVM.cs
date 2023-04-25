namespace EmemIsaac.QuizManager.Application.Features.Quizzes.Queries.GetUsersQuizzes;

public class QuizVM
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string ImageUri { get; set; } = string.Empty;

}
