using Microsoft.Extensions.DependencyInjection;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Enums;
using SistemaConcurso.Domain.Interfaces.DPs;
using SistemaConcurso.Domain.Interfaces.Lesson;
using SistemaConcurso.Domain.Interfaces.LessonAssessment;
using SistemaConcurso.Domain.Interfaces.Module;
using SistemaConcurso.Domain.Interfaces.ModuleAssessment;
using SistemaConcurso.Domain.Interfaces.Roadmap;
using SistemaConcurso.Domain.Interfaces.RoadmapAssessment;

namespace SistemaConcurso.Domain.DPs;

public class AssessmentFactory(IServiceProvider serviceProvider)
{
    public IAssessment Create(EOrigin origin)
    {
        return origin switch
        {
            EOrigin.Lesson => new LessonAssessments(),
            EOrigin.Module => new ModuleAssessments(),
            EOrigin.Assessment => new RoadmapAssessments(),
            _ => throw new NotSupportedException()
        };
    }
    
    public IAssessmentService CreateService(EOrigin origin)
    {
        return origin switch
        {
            EOrigin.Lesson => serviceProvider.GetRequiredService<ILessonAssessmentService>(),
            EOrigin.Module => serviceProvider.GetRequiredService<IModuleAssessmentService>(),
            EOrigin.Assessment => serviceProvider.GetRequiredService<IRoadmapAssessmentService>(),
            _ => throw new NotSupportedException()
        };
    }
    
    public ISubjectService CreateSubjectService(EOrigin origin)
    {
        return origin switch
        {
            EOrigin.Lesson => serviceProvider.GetRequiredService<ILessonService>(),
            EOrigin.Module => serviceProvider.GetRequiredService<IModuleService>(),
            EOrigin.Assessment => serviceProvider.GetRequiredService<IRoadmapService>(),
            _ => throw new NotSupportedException()
        };
    }
}