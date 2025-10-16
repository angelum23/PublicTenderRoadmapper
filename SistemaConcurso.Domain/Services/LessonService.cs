using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.Base;
using SistemaConcurso.Domain.Interfaces.Lesson;

namespace SistemaConcurso.Domain.Services;

public class LessonService(IBaseRepository<Lessons> repository) : BaseService<Lessons>(repository), ILessonService
{
    
}