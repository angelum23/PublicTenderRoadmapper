using SistemaConcurso.Domain.Dtos;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.Base;
using SistemaConcurso.Domain.Views.AiViews;

namespace SistemaConcurso.Domain.Interfaces.Question;

public interface IQuestionApplication : IBaseApplication<Questions>
{
    Task<QuestionGenerationView> Generate(GenerateQuestionDto dto);
    Task Answer(AnswerDto dto);
}