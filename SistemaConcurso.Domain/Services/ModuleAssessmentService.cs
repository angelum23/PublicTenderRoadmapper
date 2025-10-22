using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.ModuleAssessment;

namespace SistemaConcurso.Domain.Services;

public class ModuleAssessmentService(IModuleAssessmentRepository rep) : BaseService<ModuleAssessments>(rep), IModuleAssessmentService
{
    
}