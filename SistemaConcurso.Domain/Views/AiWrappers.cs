using SistemaConcurso.Domain.Views.AiViews;

namespace SistemaConcurso.Domain.Views;

public class QuestionsWrapper
{
    public List<QuestionView> Questions { get; set; }
}

public class RoadmapDataWrapper
{
    public RoadmapDataView RoadmapDataView { get; set; }
}

public class ExamDataWrapper
{
    public ExamDataView ExamDataView { get; set; }
}

public class ExamSearchWrapper
{
    public ExamSearchContainer ExamDataView { get; set; }
}

public class ExamSearchContainer
{
    public List<ExamDataView> Notices { get; set; }
}