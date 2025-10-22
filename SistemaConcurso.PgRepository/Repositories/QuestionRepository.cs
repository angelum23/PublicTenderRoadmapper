using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.Question;
using SistemaConcurso.PgRepository.Base;

namespace SistemaConcurso.PgRepository.Repositories;

public class QuestionRepository(PgDbContext db) : BaseRepository<Questions>(db), IQuestionRepository
{
    
}