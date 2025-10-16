using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.Lesson;
using SistemaConcurso.PgRepository.Base;

namespace SistemaConcurso.PgRepository.Repositories;

public class LessonRepository(PgDbContext db) : BaseRepository<Lessons>(db), ILessonRepository
{
    
}