using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.LessonAssessment;

namespace SistemaConcurso.Domain.Services;

public class LessonAssessmentService(ILessonAssessmentRepository rep) : BaseService<LessonAssessments>(rep), ILessonAssessmentService
{
    
}