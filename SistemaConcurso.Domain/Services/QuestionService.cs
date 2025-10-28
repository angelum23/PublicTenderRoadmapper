using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Dtos;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.Question;

namespace SistemaConcurso.Domain.Services;

public class QuestionService(IQuestionRepository rep) : BaseService<Questions>(rep), IQuestionService
{
    public async Task Answer(AnswerDto dto)
    {
        var question = await rep.FindAsync(dto.QuestionId);
        question.SelectedOption = dto.SelectedOption;
        await SaveAsync(question);
    }
}