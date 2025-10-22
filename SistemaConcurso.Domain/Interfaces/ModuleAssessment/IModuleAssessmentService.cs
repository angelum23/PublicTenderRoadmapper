using SistemaConcurso.Domain.Base.Interfaces;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.DPs;

namespace SistemaConcurso.Domain.Interfaces.ModuleAssessment;

public interface IModuleAssessmentService : IBaseService<ModuleAssessments>, IAssessmentService
{
    
}