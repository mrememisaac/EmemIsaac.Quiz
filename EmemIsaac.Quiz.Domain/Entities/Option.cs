namespace EmemIsaac.Quiz.Domain.Entities;

public class Option
{
    public Guid QuestionId {get; set;}
    
    public Guid OptionId {get; set;}

    public string OptionText {get; set; } = string.Empty;

    public string OptionImageUri {get; set; } = string.Empty;

    public bool IsAnswer {get; set;}
    
    public OptionType OptionType {get; set;}

}
