using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Enums;
using SistemaConcurso.Domain.Interfaces.Base;
using SistemaConcurso.Domain.Interfaces.DPs;
using SistemaConcurso.Domain.Interfaces.Lesson;

namespace SistemaConcurso.Domain.Services;

public class LessonService(IBaseRepository<Lessons> repository) : BaseService<Lessons>(repository), ILessonService
{
    public EAssessmentType GetAssessmentType() => EAssessmentType.Lesson;
    public new async Task<ISubject> FindAsync(int subjectId) => await base.FindAsync(subjectId);

}