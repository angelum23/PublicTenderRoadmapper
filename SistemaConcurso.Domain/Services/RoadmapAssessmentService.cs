using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.RoadmapAssessment;

namespace SistemaConcurso.Domain.Services;

public class RoadmapAssessmentService(IRoadmapAssessmentRepository rep) : BaseService<RoadmapAssessments>(rep), IRoadmapAssessmentService
{
    
}