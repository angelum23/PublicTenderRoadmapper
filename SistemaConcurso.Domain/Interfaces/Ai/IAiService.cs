using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Views.AiViews;

namespace SistemaConcurso.Domain.Interfaces.Ai;

public interface IAiService
{
    ExamDataView ExtractExamData(string noticeText);
    ExamDataView SearchExam(string prompt);
}