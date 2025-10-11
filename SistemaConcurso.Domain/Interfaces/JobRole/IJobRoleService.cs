using SistemaConcurso.Domain.Base.Interfaces;
using SistemaConcurso.Domain.Entities;

namespace SistemaConcurso.Domain.Interfaces.JobRole;

public interface IJobRoleService : IBaseService<JobRoles>
{
    public Task<List<JobRoles>> GetByExamId(int idExam);
}