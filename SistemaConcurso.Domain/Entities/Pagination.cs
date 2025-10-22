using SistemaConcurso.Domain.Interfaces.Base;

namespace SistemaConcurso.Domain.Entities;

public class Pagination : IPagination
{
    public int Skip { get; set; } = 0;
    public int Take { get; set; } = 10;
}