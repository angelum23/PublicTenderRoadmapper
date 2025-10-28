using SistemaConcurso.Domain.Enums;

namespace SistemaConcurso.Domain.Dtos;

public record GenerateQuestionDto(EOrigin Origin, int SubjectId, int Quantity = 10);