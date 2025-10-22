using System.ComponentModel;

namespace SistemaConcurso.Domain.Enums;

public enum EAssessmentType
{
    [Description("Roadmap assessment")]
    Roadmap = 1,
    [Description("Module assessment")]
    Module = 2,
    [Description("Lesson assessment")]
    Lesson = 3
}