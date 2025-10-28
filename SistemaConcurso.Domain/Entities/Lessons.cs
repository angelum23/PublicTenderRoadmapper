using System.ComponentModel.DataAnnotations.Schema;
using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Enums;
using SistemaConcurso.Domain.Exceptions;
using SistemaConcurso.Domain.Interfaces.DPs;

namespace SistemaConcurso.Domain.Entities;

public class Lessons : BaseEntity, ISubject
{
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Done { get; private set; }
    public int Order { get; set; }
    
    [ForeignKey("Module")]
    public int IdModule { get; set; }
    public Modules? Module { get; set; }

    public List<LessonAssessments> LessonAssessment { get; set; } = [];

    #region Rules
    
    public void MarkDone()
    {
        if (Done) throw new RuleException(EException.LessonAlreadyDone);
        Done = true;
    }
    
    public void MarkTodo()
    {
        if (!Done) throw new RuleException(EException.LessonAlreadyTodo);
        Done = false;
    }

    public EOrigin GetAssessmentType() => EOrigin.Lesson;
    
    #endregion
}