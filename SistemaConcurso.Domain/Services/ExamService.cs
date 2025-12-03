using SistemaConcurso.Domain.Base;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.Base;
using SistemaConcurso.Domain.Interfaces.Exam;
using SistemaConcurso.Domain.Views;
using Microsoft.EntityFrameworkCore;
using SistemaConcurso.Domain.Dtos;

namespace SistemaConcurso.Domain.Services;

public class ExamService(IExamRepository repository) : BaseService<Exams>(repository), IExamService
{
    public Task<List<HomeExamView>> GetHomeData(Pagination pagination, int userId)
    {
        return repository.GetHomeData(userId, pagination).ToListAsync();
    }

    public Task<Exams> Add(Exams exam)
    {
        return repository.AddAsync(exam);
    }
}