using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.RoadmapAssessment;
using SistemaConcurso.PgRepository.Base;

namespace SistemaConcurso.PgRepository.Repositories;

public class RoadmapAssessmentRepository(PgDbContext db) : BaseRepository<RoadmapAssessments>(db), IRoadmapAssessmentRepository
{
    
}