using SistemaConcurso.Domain.Enums;

namespace SistemaConcurso.Domain.Dtos;

public record GenerateQuestionDto(EAssessmentType type, int SubjectId, int Quantity = 10);