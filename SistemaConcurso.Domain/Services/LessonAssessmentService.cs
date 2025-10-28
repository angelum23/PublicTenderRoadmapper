using Microsoft.EntityFrameworkCore;
using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.DPs;
using SistemaConcurso.Domain.Interfaces.LessonAssessment;

namespace SistemaConcurso.Domain.Services;

public class LessonAssessmentService(ILessonAssessmentRepository rep) : BaseService<LessonAssessments>(rep), ILessonAssessmentService
{
    public async Task<IAssessment> AddAsync(IAssessment assessment, int subjectId)
    {
        assessment.RetryNumber = await GetMaxRetryNumberAsync(subjectId) + 1;
        var lessonAssessment = (LessonAssessments)assessment;
        await base.AddAsync(lessonAssessment);
        return assessment;
    }

    public Task<int> GetMaxRetryNumberAsync(int subjectId) =>
        rep.Get().Where(x => x.IdLesson == subjectId).MaxAsync(x => x.RetryNumber);
}