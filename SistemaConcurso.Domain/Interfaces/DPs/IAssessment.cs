using SistemaConcurso.Domain.Entities;

namespace SistemaConcurso.Domain.Interfaces.DPs;

public interface IAssessment
{
    public int Id { get; set; }
    public int RetryNumber { get; set; }
    public List<Questions> Questions { get; set; }
    public void SetId(int id);
}