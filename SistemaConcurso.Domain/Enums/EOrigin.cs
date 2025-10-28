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
    public static EOrigin FromAssessmentType(EOrigin type) => type switch
    {
        EOrigin.Assessment => EOrigin.Assessment,
        EOrigin.Module => EOrigin.Module,
        EOrigin.Lesson => EOrigin.Lesson,
        _ => throw new ArgumentOutOfRangeException(nameof(type), $"Not expected assessment type value: {type}"),
    };
}