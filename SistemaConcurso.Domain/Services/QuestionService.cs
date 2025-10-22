using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.Question;

namespace SistemaConcurso.Domain.Services;

public class QuestionService(IQuestionRepository rep) : BaseService<Questions>(rep), IQuestionService
{
    
}