using SistemaConcurso.Application.Base;
using SistemaConcurso.Domain.DPs;
using SistemaConcurso.Domain.Dtos;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces;
using SistemaConcurso.Domain.Interfaces.Ai;
using SistemaConcurso.Domain.Interfaces.Question;
using SistemaConcurso.Domain.Views.AiViews;

namespace SistemaConcurso.Application.Applications;

public class QuestionApplication(IQuestionService service, IUnitOfWork uow, IAiService aiService, AssessmentFactory factory) : BaseApplication<Questions>(service, uow), IQuestionApplication
{
    public async Task<QuestionGenerationView> Generate(GenerateQuestionDto dto)
    {
        var service = factory.CreateSubjectService(dto.type);
        var subject = await service.FindAsync(dto.SubjectId);
        
        var questions = await aiService.GenerateQuestions(subject, dto.Quantity);
        
        throw new NotImplementedException();
    }
}