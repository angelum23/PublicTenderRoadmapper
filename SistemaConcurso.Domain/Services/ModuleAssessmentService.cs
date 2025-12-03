using Microsoft.EntityFrameworkCore;
using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.DPs;
using SistemaConcurso.Domain.Interfaces.ModuleAssessment;

namespace SistemaConcurso.Domain.Services;

public class ModuleAssessmentService(IModuleAssessmentRepository rep) : BaseService<ModuleAssessments>(rep), IModuleAssessmentService
{
    public async Task<IAssessment> AddAsync(IAssessment assessment, int subjectId)
    {
        if (assessment.RetryNumber <= 0) assessment.RetryNumber = await GetMaxRetryNumberAsync(subjectId) + 1;
        
        var moduleAssessment = (ModuleAssessments)assessment;
        var reg = await base.AddAsync(moduleAssessment);
        return reg;
    }
    
    public async Task<int> GetMaxRetryNumberAsync(int subjectId)
    {
        var max = await rep.Get()
            .Where(x => x.IdModule == subjectId)
            .Select(x => (int?)x.RetryNumber)
            .MaxAsync();

        return max ?? 0;
    }
}