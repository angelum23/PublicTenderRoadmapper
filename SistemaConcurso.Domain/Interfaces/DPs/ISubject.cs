using SistemaConcurso.Domain.Enums;

namespace SistemaConcurso.Domain.Interfaces.DPs;

public interface ISubject
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public EOrigin GetAssessmentType();
    public string GetAssessmentTypeString();
}