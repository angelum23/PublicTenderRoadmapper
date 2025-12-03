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
        if (assessment.RetryNumber <= 0) assessment.RetryNumber = await GetMaxRetryNumberAsync(subjectId) + 1;
        
        var roadmapAssessment = (RoadmapAssessments)assessment;
        var reg = await base.AddAsync(roadmapAssessment);
        return reg;
    }

    public async Task<int> GetMaxRetryNumberAsync(int subjectId)
    {
        var max = await rep.Get()
            .Where(x => x.IdRoadmap == subjectId)
            .Select(x => (int?)x.RetryNumber)
            .MaxAsync();

        return max ?? 0;
    }
}