using SistemaConcurso.Domain.Entities;

namespace SistemaConcurso.Domain.Dtos;

public class ExamWithNotice
{
    public required string RoadmapName { get; set; }
    public required byte[] Notice { get; set; }
};