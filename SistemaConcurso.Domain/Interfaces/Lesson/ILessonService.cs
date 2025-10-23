using SistemaConcurso.Domain.Base.Interfaces;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.DPs;

namespace SistemaConcurso.Domain.Interfaces.Lesson;

public interface ILessonService : IBaseService<Lessons>, ISubjectService
{
    
}