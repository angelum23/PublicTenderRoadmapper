using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.JobRole;
using SistemaConcurso.PgRepository.Base;

namespace SistemaConcurso.PgRepository.Repositories;

public class JobRoleRepository(PgDbContext db) : BaseRepository<JobRoles>(db), IJobRoleRepository
{
    
}