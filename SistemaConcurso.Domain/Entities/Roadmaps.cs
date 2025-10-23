using System.ComponentModel.DataAnnotations.Schema;
using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Enums;
using SistemaConcurso.Domain.Interfaces.DPs;

namespace SistemaConcurso.Domain.Entities;

public class Roadmaps : BaseEntity, ISubject
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    [ForeignKey("Exam")]
    public int IdExam { get; set; }
    public Exams Exam { get; set; }
    
    [ForeignKey("SelectedJobRole")]
    public int? IdSelectedJobRole { get; set; }
    public JobRoles? SelectedJobRole { get; set; }
    
    public List<Modules> Modules { get; set; } = [];
    public List<RoadmapAssessments> RoadmapAssessment { get; set; } = [];

    public EAssessmentType GetAssessmentType() => EAssessmentType.Roadmap;
}