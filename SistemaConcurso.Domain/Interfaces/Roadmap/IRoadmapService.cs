using SistemaConcurso.Domain.Base.Interfaces;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.DPs;
using SistemaConcurso.Domain.Views;

namespace SistemaConcurso.Domain.Interfaces.Roadmap;

public interface IRoadmapService : IBaseService<Roadmaps>, ISubjectService
{
    Task<List<HomeView>> GetHomeData(List<HomeExamView> exams);
    Task<List<Roadmaps>> GetByExamId(int examId);
}