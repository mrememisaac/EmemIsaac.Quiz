namespace Quiz.Domain.Entities;

public class Question
{
    public int SubjectId {get; set; }
    
    public int QuestionId {get; set;}

    public string QuestionText {get; set; } = string.Empty;
}
