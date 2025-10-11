using SistemaConcurso.Application.Base;
using SistemaConcurso.Domain.Dtos;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces;
using SistemaConcurso.Domain.Interfaces.Ai;
using SistemaConcurso.Domain.Interfaces.Base;
using SistemaConcurso.Domain.Interfaces.Exam;
using SistemaConcurso.Domain.Interfaces.JobRole;
using SistemaConcurso.Domain.Views;
using SistemaConcurso.Domain.Views.AiViews;
using System.Transactions;
using SistemaConcurso.Domain.Interfaces.Roadmap;

namespace SistemaConcurso.Application.Applications;

public class ExamApplication(IExamService service, 
                             IUnitOfWork uow, 
                             IPdfService pdfService, 
                             IAiService aiService, 
                             IClaimService claimService,
                             IJobRoleService jobRoleService,
                             IRoadmapService roadmapService) 
    : BaseApplication<Exams>(service, uow), IExamApplication
{
    public Task<NoticeRegisterView> Add(ExamWithNotice examDto)
    {
        try
        {
            var noticeText = pdfService.PdfToString(examDto.Notice);
            var examData = aiService.ExtractExamData(noticeText);
            var user = claimService.GetLoggedUser();
            
            return BaseAdd(examData, user.Id);
        }
        catch (Exception e)
        {
            return Task.FromResult(new NoticeRegisterView([], e.Message));
        }
    }

    public Task<NoticeRegisterView> Add(ExamWithPrompt examDto)
    {
        try
        {
            var examData = aiService.SearchExam(examDto.Prompt);
            var user = claimService.GetLoggedUser();
            
            return BaseAdd(examData, user.Id);
        }
        catch (Exception e)
        {
            return Task.FromResult(new NoticeRegisterView([], e.Message));
        }
    }
    
    private async Task<NoticeRegisterView> BaseAdd(ExamDataView examData, int userId)
    {
        var exam = await service.AddAsync(examData.ToExam(userId));
        await uow.CommitAsync();

        var jobRoles = examData.ToJobRoles(exam.Id);
        await jobRoleService.AddRangeAsync(jobRoles);
        await uow.CommitAsync();
        
        return new NoticeRegisterView(
            jobRoles.Select(x => new NoticeJobsView(
                x.Id, x.Name
            )).ToList(), null
        );
    }

    public override async Task<Exams> RemoveAsync(int id)
    {
        using (var scope = new TransactionScope())
        {
            var jobRoles = (await jobRoleService.GetByExamId(id)).Select(x => x.Id).ToList();
            jobRoles.ForEach(x => jobRoleService.RemoveAsync(x));
            await uow.CommitAsync();
            
            var roadmaps = (await roadmapService.GetByExamId(id)).Select(x => x.Id).ToList();
            roadmaps.ForEach(x => roadmapService.RemoveAsync(x));
            await uow.CommitAsync();
            
            scope.Complete();
            return await base.RemoveAsync(id);
        }
    }
}