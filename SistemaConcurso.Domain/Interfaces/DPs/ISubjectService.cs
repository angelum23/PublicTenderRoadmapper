using SistemaConcurso.Domain.Enums;

namespace SistemaConcurso.Domain.Interfaces.DPs;

public interface ISubjectService
{
    Task<ISubject> FindAsync(int subjectId);
    EOrigin GetAssessmentType();
}