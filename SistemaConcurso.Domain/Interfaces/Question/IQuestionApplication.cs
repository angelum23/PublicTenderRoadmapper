using SistemaConcurso.Domain.Dtos;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.Base;

namespace SistemaConcurso.Domain.Interfaces.Question;

public interface IQuestionApplication : IBaseApplication<Questions>
{
    Task Generate(GenerateQuestionDto dto);
}