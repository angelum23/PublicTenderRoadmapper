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
    public async Task<NoticeRegisterView> Add(ExamWithNoticeDto examDto)
    {
        try
        {
            var noticeText = pdfService.PdfToString(examDto.Notice);
            var examData = await aiService.ExtractExamData(noticeText);
            var user = claimService.GetLoggedUser();
            
            return await BaseAdd(examData, user.Id);
        }
        catch (Exception e)
        {
            return new NoticeRegisterView([], 0, e.Message);
        }
    }

    public async Task<NoticeRegisterView> Add(ExamWithPromptDto examDto)
    {
        try
        {
            var examData = await aiService.SearchExam(examDto.Prompt);
            var user = claimService.GetLoggedUser();
            
            return await BaseAdd(examData, user.Id);
        }
        catch (Exception e)
        {
            return new NoticeRegisterView([], 0, e.Message);
        }
    }
    
    private async Task<NoticeRegisterView> BaseAdd(ExamDataView examData, int userId)
    {
        List<JobRoles> jobRoles;
        Exams exam;
        
        using (var scope = new TransactionScope())
        {
            exam = await service.SaveAsync(examData.ToExam(userId));
            Commit();

            jobRoles = examData.ToJobRoles(exam.Id, userId);
            await jobRoleService.AddRangeAsync(jobRoles);
            Commit();
            
            scope.Complete();
        }
        
        return new NoticeRegisterView(
            Jobs: jobRoles.Select(x => new NoticeJobsView(x.Id, x.Name)).ToList(),
            IdExam: exam.Id, 
            Error: null
        );
    }

    public override async Task<Exams> RemoveAsync(int id)
    {
        using (var scope = new TransactionScope())
        {
            var jobRoles = (await jobRoleService.GetByExamId(id)).Select(x => x.Id).ToList();
            jobRoles.ForEach(x => jobRoleService.RemoveAsync(x));
            Commit();
            
            var roadmaps = (await roadmapService.GetByExamId(id)).Select(x => x.Id).ToList();
            roadmaps.ForEach(x => roadmapService.RemoveAsync(x));
            Commit();
            
            scope.Complete();
            return await base.RemoveAsync(id);
        }
    }
}