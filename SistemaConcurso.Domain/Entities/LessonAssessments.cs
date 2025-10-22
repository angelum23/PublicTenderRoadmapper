using System.ComponentModel.DataAnnotations.Schema;
using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Interfaces.DPs;

namespace SistemaConcurso.Domain.Entities;

public class LessonAssessments : BaseEntity, IAssessment
{
    public int RetryNumber { get; set; }
    
    [ForeignKey("Lesson")]
    public int IdLesson { get; set; }
    public Lessons? Lesson { get; set; }
    public List<Questions> Questions { get; set; } = [];
}