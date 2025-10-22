using Microsoft.AspNetCore.Mvc;
using SistemaConcurso.Api.Base;
using SistemaConcurso.Domain.Dtos;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.Question;

namespace SistemaConcurso.Api.Controllers;

public class QuestionController(IQuestionApplication aplic) : BaseController<Questions>(aplic)
{
    [HttpPost]
    public async Task<IActionResult> Generate([FromBody] GenerateQuestionDto dto) => await SafeController(aplic.Generate(dto));
}