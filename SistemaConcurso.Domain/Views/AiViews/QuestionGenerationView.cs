using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Enums;

namespace SistemaConcurso.Domain.Views.AiViews;

public class QuestionGenerationView
{
    public List<QuestionView> Questions { get; set; }
    
    public List<Questions> ToQuestions(int idAssessment)
    {
        return Questions.Select(q => new Questions()
        {
            Question = q.Question,
            Origin = q.Origin,
            Order = q.Order,
            OptionA = q.OptionA,
            OptionB = q.OptionB,
            OptionC = q.OptionC,
            OptionD = q.OptionD,
            CorrectOption = q.CorrectOption,
        }).ToList();
    }
}

public class QuestionView
{
    public string Question { get; set; }
    public EOrigin Origin { get; set; }
    public int Order { get; set; }
    public string OptionA { get; set; }
    public string OptionB { get; set; }
    public string OptionC { get; set; }
    public string OptionD { get; set; }
    public EOptionChar CorrectOption { get; set; }
}