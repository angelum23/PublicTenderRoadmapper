using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.DPs;
using SistemaConcurso.Domain.Views.AiViews;

namespace SistemaConcurso.Domain.Interfaces.Ai;

public interface IAiService
{
    Task<ExamDataView> ExtractExamData(string noticeText);
    Task<ExamDataView> SearchExam(string prompt);
    Task<RoadmapDataView> GenerateRoadmap(string selectedJobRole, string notice);
    Task<List<QuestionView>> GenerateQuestions(ISubject subject, int quantity);
}