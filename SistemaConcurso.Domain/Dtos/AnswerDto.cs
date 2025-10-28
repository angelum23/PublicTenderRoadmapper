using SistemaConcurso.Domain.Enums;

namespace SistemaConcurso.Domain.Dtos;

public record AnswerDto(int QuestionId, EOptionChar SelectedOption);