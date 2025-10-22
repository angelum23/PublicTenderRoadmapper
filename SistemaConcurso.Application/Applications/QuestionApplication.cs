using SistemaConcurso.Application.Base;
using SistemaConcurso.Domain.Dtos;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces;
using SistemaConcurso.Domain.Interfaces.Question;

namespace SistemaConcurso.Application.Applications;

public class QuestionApplication(IQuestionService service, IUnitOfWork uow) : BaseApplication<Questions>(service, uow), IQuestionApplication
{
    public Task Generate(GenerateQuestionDto dto)
    {
        throw new NotImplementedException();
    }
}