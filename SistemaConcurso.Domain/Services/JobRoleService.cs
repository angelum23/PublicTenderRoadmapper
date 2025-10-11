using Microsoft.EntityFrameworkCore;
using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.Base;
using SistemaConcurso.Domain.Interfaces.JobRole;

namespace SistemaConcurso.Domain.Services;

public class JobRoleService(IBaseRepository<JobRoles> repository) : BaseService<JobRoles>(repository), IJobRoleService
{
    public Task<List<JobRoles>> GetByExamId(int idExam)
    {
        return repository.Get().Where(x => x.IdExam == idExam).ToListAsync();
    }
}