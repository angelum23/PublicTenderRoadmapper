using System.ComponentModel.DataAnnotations.Schema;
using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Interfaces.DPs;

namespace SistemaConcurso.Domain.Entities;

public class RoadmapAssessments : BaseEntity, IAssessment
{
    public int RetryNumber { get; set; }
    
    [ForeignKey("Roadmap")]
    public int IdRoadmap { get; set; }
    public Roadmaps? Roadmap { get; set; }
    public List<Questions> Questions { get; set; } = [];
}