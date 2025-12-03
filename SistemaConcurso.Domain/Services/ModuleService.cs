using Microsoft.EntityFrameworkCore;
using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Enums;
using SistemaConcurso.Domain.Interfaces.Base;
using SistemaConcurso.Domain.Interfaces.DPs;
using SistemaConcurso.Domain.Interfaces.Module;
using SistemaConcurso.Domain.Views;

namespace SistemaConcurso.Domain.Services;

public class ModuleService(IModuleRepository repository) : BaseService<Modules>(repository), IModuleService
{
    public Task<List<ModuleView>> List(Pagination pagination, int idRoadmap)
    {
        return repository.List(pagination, idRoadmap).ToListAsync();
    }

    public new async Task<ISubject> FindAsync(int subjectId) => await base.FindAsync(subjectId);
    public EOrigin GetAssessmentType() => EOrigin.Module;
}