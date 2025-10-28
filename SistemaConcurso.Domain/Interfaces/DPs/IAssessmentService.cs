namespace SistemaConcurso.Domain.Interfaces.DPs;

public interface IAssessmentService
{
    public Task<IAssessment> AddAsync(IAssessment assessment, int subjectId);
    public Task<int> GetMaxRetryNumberAsync(int subjectId);
}