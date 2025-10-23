using System.ComponentModel;

namespace SistemaConcurso.Domain.Enums;

public enum EOrigin
{
    [Description("Assessment")] 
    Assessment = 1,
    
    [Description("Module")] 
    Module = 2,
    
    [Description("Lesson")] 
    Lesson = 3,
}

public static class EOriginExtensions
{
    public static EOrigin FromAssessmentType(EAssessmentType type) => type switch
    {
        EAssessmentType.Roadmap => EOrigin.Assessment,
        EAssessmentType.Module => EOrigin.Module,
        EAssessmentType.Lesson => EOrigin.Lesson,
        _ => throw new ArgumentOutOfRangeException(nameof(type), $"Not expected assessment type value: {type}"),
    };
}