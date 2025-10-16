using SistemaConcurso.Domain.Dtos;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.Base;
using SistemaConcurso.Domain.Views;

namespace SistemaConcurso.Domain.Interfaces.Exam;

public interface IExamApplication : IBaseApplication<Exams>
{
    Task<NoticeRegisterView> Add(ExamWithNoticeDto examDto);
    Task<NoticeRegisterView> Add(ExamWithPromptDto examDto);
}