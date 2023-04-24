namespace EmemIsaac.QuizManager.Domain.Entities;

public class Option
{
    public Guid QuestionId {get; set;}
    
    public Guid Id {get; set;}

    public string Text {get; set; } = string.Empty;

    public string ImageUri {get; set; } = string.Empty;

    public bool IsAnswer {get; set;}
    
    public OptionType OptionType {get; set;}

}
