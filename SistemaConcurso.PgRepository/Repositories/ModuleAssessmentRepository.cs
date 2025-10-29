using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.ModuleAssessment;
using SistemaConcurso.PgRepository.Base;

namespace SistemaConcurso.PgRepository.Repositories;

public class ModuleAssessmentRepository(PgDbContext db) : BaseRepository<ModuleAssessments>(db), IModuleAssessmentRepository
{
    
}