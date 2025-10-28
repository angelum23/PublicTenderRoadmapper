using SistemaConcurso.Domain.Base.Interfaces;
using SistemaConcurso.Domain.Dtos;
using SistemaConcurso.Domain.Entities;

namespace SistemaConcurso.Domain.Interfaces.Question;

public interface IQuestionService : IBaseService<Questions>
{
    Task Answer(AnswerDto dto);
}