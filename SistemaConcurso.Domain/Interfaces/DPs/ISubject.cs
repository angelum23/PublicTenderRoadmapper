using SistemaConcurso.Domain.Enums;

namespace SistemaConcurso.Domain.Interfaces.DPs;

public interface ISubject
{
    public string Title { get; set; }
    public string Description { get; set; }
    public EAssessmentType GetAssessmentType();
}