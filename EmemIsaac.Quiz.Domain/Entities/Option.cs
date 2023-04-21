namespace Quiz.Domain.Entities;

public class Option
{
    public int QuestionId {get; set;}
    
    public int OptionId {get; set;}

    public string OptionText {get; set; } = string.Empty;

    public bool IsAnswer {get; set;}
    
    public OptionType OptionType {get; set;}

}
