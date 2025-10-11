using Microsoft.AspNetCore.Mvc;
using SistemaConcurso.Api.Base;
using SistemaConcurso.Domain.Dtos;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.Exam;
using SistemaConcurso.Domain.Views;

namespace SistemaConcurso.Api.Controllers;

public class ExamController(IExamApplication aplic) : BaseController<Exams>(aplic)
{
    [HttpPost("AddWithNotice")]
    public async Task<IActionResult> AddWithNotice([FromBody] ExamWithNotice entity) => await Controller(aplic.Add(entity));
    
    
    [HttpPost("AddWithPrompt")]
    public async Task<IActionResult> AddWithPrompt([FromBody] ExamWithPrompt entity) => await Controller(aplic.Add(entity));
    
    
}