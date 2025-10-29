using SistemaConcurso.Domain.Enums;

namespace SistemaConcurso.Domain.Interfaces.DPs;

public interface IAssessmentFactory
{
    public IAssessment Create(EOrigin origin);
    public IAssessmentService CreateService(EOrigin origin);
    public ISubjectService CreateSubjectService(EOrigin origin);
}