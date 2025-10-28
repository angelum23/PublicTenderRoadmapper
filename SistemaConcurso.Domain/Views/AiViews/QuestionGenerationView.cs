using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Enums;

namespace SistemaConcurso.Domain.Views.AiViews;

public class QuestionGenerationView
{
    public List<QuestionView> Questions { get; set; }

    #region Methods
    public List<Questions> ToQuestions(int idAssessment, EOrigin? origin) => 
        Questions.Select(q => new Questions
        {
            Question = q.Question,
            Origin = origin ?? q.Origin,
            Order = q.Order,
            IdLessonAssessment = SetIdLessonAssessment(origin ?? q.Origin, idAssessment),
            IdModuleAssessment = SetIdModuleAssessment(origin ?? q.Origin, idAssessment),
            IdRoadmapAssessment = SetIdRoadmapAssessment(origin ?? q.Origin, idAssessment),
            OptionA = q.OptionA,
            OptionB = q.OptionB,
            OptionC = q.OptionC,
            OptionD = q.OptionD,
            CorrectOption = q.CorrectOption,
        }).ToList();

    private static int? SetIdLessonAssessment(EOrigin origin, int idAssessment) =>
        origin == EOrigin.Lesson ? idAssessment : null;

    private static int? SetIdModuleAssessment(EOrigin origin, int idAssessment) =>
        origin == EOrigin.Module ? idAssessment : null;

    private static int? SetIdRoadmapAssessment(EOrigin origin, int idAssessment) =>
        origin == EOrigin.Assessment ? idAssessment : null;
    #endregion
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