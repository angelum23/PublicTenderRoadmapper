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
    public static IAssessment Create(EAssessmentType assessmentType)
    {
        return assessmentType switch
        {
            EAssessmentType.Lesson => new LessonAssessments(),
            EAssessmentType.Module => new ModuleAssessments(),
            EAssessmentType.Roadmap => new RoadmapAssessments(),
            _ => throw new NotSupportedException()
        };
    }
    
    public IAssessmentService CreateService(EAssessmentType assessmentType)
    {
        return assessmentType switch
        {
            EAssessmentType.Lesson => serviceProvider.GetRequiredService<ILessonAssessmentService>(),
            EAssessmentType.Module => serviceProvider.GetRequiredService<IModuleAssessmentService>(),
            EAssessmentType.Roadmap => serviceProvider.GetRequiredService<IRoadmapAssessmentService>(),
            _ => throw new NotSupportedException()
        };
    }
    
    public ISubjectService CreateSubjectService(EAssessmentType assessmentType)
    {
        return assessmentType switch
        {
            EAssessmentType.Lesson => serviceProvider.GetRequiredService<ILessonService>(),
            EAssessmentType.Module => serviceProvider.GetRequiredService<IModuleService>(),
            EAssessmentType.Roadmap => serviceProvider.GetRequiredService<IRoadmapService>(),
            _ => throw new NotSupportedException()
        };
    }
}