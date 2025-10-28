using Microsoft.EntityFrameworkCore;
using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.DPs;
using SistemaConcurso.Domain.Interfaces.RoadmapAssessment;

namespace SistemaConcurso.Domain.Services;

public class RoadmapAssessmentService(IRoadmapAssessmentRepository rep) : BaseService<RoadmapAssessments>(rep), IRoadmapAssessmentService
{
    public async Task<IAssessment> AddAsync(IAssessment assessment, int subjectId)
    {
        assessment.RetryNumber = await GetMaxRetryNumberAsync(subjectId) + 1;
        var roadmapAssessment = (RoadmapAssessments)assessment;
        await base.AddAsync(roadmapAssessment);
        return assessment;
    }

    public Task<int> GetMaxRetryNumberAsync(int subjectId) =>
        rep.Get().Where(x => x.IdRoadmap == subjectId).MaxAsync(x => x.RetryNumber);
}