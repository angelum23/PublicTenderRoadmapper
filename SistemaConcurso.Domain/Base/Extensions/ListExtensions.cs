namespace SistemaConcurso.Domain.Base.Extensions;

public static class ListExtensions
{
    public static List<int> Times(int times) => Enumerable.Range(0, times).ToList();
}