using SistemaConcurso.Domain.Interfaces.Ai;
using SistemaConcurso.Domain.Interfaces.DPs;
using SistemaConcurso.Domain.Views.AiViews;

namespace SistemaConcurso.Domain.Services;

public class AiService : IAiService
{
    const string AiApiUrl = "https://projeto-integrador-ia-4a0661fec346.herokuapp.com/";
    
    public Task<ExamDataView> ExtractExamData(string noticeText)
    {
        throw new NotImplementedException();
    }

    public Task<ExamDataView> SearchExam(string prompt)
    {
        throw new NotImplementedException();
    }

    public Task<RoadmapDataView> GenerateRoadmap(string selectedJobRole, string notice)
    {
        throw new NotImplementedException();
    }

    public Task<List<QuestionView>> GenerateQuestions(ISubject subject, int quantity)
    {
        throw new NotImplementedException();
    }
}