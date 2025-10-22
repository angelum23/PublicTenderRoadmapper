using System.ComponentModel.DataAnnotations.Schema;
using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Interfaces.DPs;

namespace SistemaConcurso.Domain.Entities;

public class ModuleAssessments : BaseEntity, IAssessment
{
    public int RetryNumber { get; set; }
    
    [ForeignKey("Module")]
    public int IdModule { get; set; }
    public Modules? Module { get; set; }
    public List<Questions> Questions { get; set; } = [];
}