using System.Transactions;
using SistemaConcurso.Application.Base;
using SistemaConcurso.Domain.DPs;
using SistemaConcurso.Domain.Dtos;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces;
using SistemaConcurso.Domain.Interfaces.Ai;
using SistemaConcurso.Domain.Interfaces.Question;
using SistemaConcurso.Domain.Views.AiViews;

namespace SistemaConcurso.Application.Applications;

public class QuestionApplication(IQuestionService service, 
                                 IUnitOfWork uow, 
                                 IAiService aiService, 
                                 AssessmentFactory factory, 
                                 IQuestionService questionService) 
    : BaseApplication<Questions>(service, uow), IQuestionApplication
{
    public async Task<QuestionGenerationView> Generate(GenerateQuestionDto dto)
    {
        var subjectService = factory.CreateSubjectService(dto.Origin);
        var subject = await subjectService.FindAsync(dto.SubjectId);
        
        var questionViews = await aiService.GenerateQuestions(subject, dto.Quantity);
        var view = new QuestionGenerationView { Questions = questionViews };
        var assessment = factory.Create(dto.Origin);
        
        using (var scope = new TransactionScope())
        {
            var assessmentService = factory.CreateService(dto.Origin);
            var reg = await assessmentService.AddAsync(assessment, dto.SubjectId);
            await CommitAsync();
            
            var questions = view.ToQuestions(dto.SubjectId, dto.Origin);
            questions.ForEach(x => x.SetAssessment(reg.Id, dto.Origin));
            await questionService.AddRangeAsync(questions);
            await CommitAsync();
            
            scope.Complete();
        }

        return view;
    }

    public async Task Answer(AnswerDto dto)
    {
        await service.Answer(dto);
        await CommitAsync();
    }
}