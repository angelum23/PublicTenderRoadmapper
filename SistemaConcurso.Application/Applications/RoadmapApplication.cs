using System.Transactions;
using SistemaConcurso.Application.Base;
using SistemaConcurso.Domain.Base.Interfaces;
using SistemaConcurso.Domain.Dtos;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces;
using SistemaConcurso.Domain.Interfaces.Ai;
using SistemaConcurso.Domain.Interfaces.Base;
using SistemaConcurso.Domain.Interfaces.Exam;
using SistemaConcurso.Domain.Interfaces.JobRole;
using SistemaConcurso.Domain.Interfaces.Lesson;
using SistemaConcurso.Domain.Interfaces.Module;
using SistemaConcurso.Domain.Interfaces.Roadmap;
using SistemaConcurso.Domain.Views;

namespace SistemaConcurso.Application.Applications;

public class RoadmapApplication(IRoadmapService service,
                                IExamService examService, 
                                IUnitOfWork uow, 
                                IClaimService claimService, 
                                IAiService aiService,
                                IJobRoleService jobRoleService,
                                IModuleService moduleService, 
                                ILessonService lessonService) 
    : BaseApplication<Roadmaps>(service, uow), IRoadmapApplication
{
    public async Task<List<HomeView>> Home(IPagination pagination)
    {
        var user = claimService.GetLoggedUser();
        var exams = await examService.GetHomeData(pagination, user.Id);
        return await service.GetHomeData(exams);
    }

    public async Task Generate(RoadmapGenerateDto dto)
    {
        var exam = await examService.FindAsync(dto.examId);
        var jobRole = await jobRoleService.FindAsync(dto.selectedJobRoleId);
        
        var roadmapView = aiService.GenerateRoadmap(jobRole.Name, exam.Notice);
        var roadmap = roadmapView.ToRoadmap(exam.Id, jobRole.Id);

        using (var scope = new TransactionScope())
        {
            var reg = await service.SaveAsync(roadmap);
            await uow.CommitAsync();

            var modules = roadmapView.Modules.Select(x => x.ToModule(reg.Id)).ToList();
            var regModules = await moduleService.AddRangeAsync(modules);
            await uow.CommitAsync();
            
            var lessons = roadmapView
                .Modules
                .SelectMany(x => x.Lessons.Select(y => y.ToLesson(regModules.First(z => z.Order == x.Order).Id)))
                .ToList();
            
            await lessonService.AddRangeAsync(lessons);
            await uow.CommitAsync();
            
            scope.Complete();
        }
    }
}