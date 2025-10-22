using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.LessonAssessment;
using SistemaConcurso.PgRepository.Base;

namespace SistemaConcurso.PgRepository.Repositories;

public class LessonAssessmentRepository(PgDbContext db) : BaseRepository<LessonAssessments>(db), ILessonAssessmentRepository
{
    
}