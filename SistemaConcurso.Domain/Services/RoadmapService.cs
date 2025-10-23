using Microsoft.EntityFrameworkCore;
using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Base.Interfaces;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Enums;
using SistemaConcurso.Domain.Interfaces.Base;
using SistemaConcurso.Domain.Interfaces.DPs;
using SistemaConcurso.Domain.Interfaces.Roadmap;
using SistemaConcurso.Domain.Views;

namespace SistemaConcurso.Domain.Services;

public class RoadmapService(IRoadmapRepository repository) : BaseService<Roadmaps>(repository), IRoadmapService
{
    public Task<List<HomeView>> GetHomeData(List<HomeExamView> exams)
    {
        return repository.GetHomeData(exams);
    }

    public Task<List<Roadmaps>> GetByExamId(int examId)
    {
        return repository.Get().Where(x => x.IdExam == examId).ToListAsync();
    }

    public new async Task<ISubject> FindAsync(int subjectId) => await base.FindAsync(subjectId);

    public EAssessmentType GetAssessmentType() => EAssessmentType.Roadmap;
}