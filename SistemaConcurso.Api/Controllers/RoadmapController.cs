using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaConcurso.Api.Base;
using SistemaConcurso.Domain.Dtos;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.Base;
using SistemaConcurso.Domain.Interfaces.Roadmap;

namespace SistemaConcurso.Api.Controllers;

[Authorize]
public class RoadmapController(IRoadmapApplication aplic) : BaseController<Roadmaps>(aplic)
{
    [HttpGet("Home")]
    public async Task<IActionResult> Home([FromQuery] IPagination pagination) =>
        await Controller(aplic.Home(pagination));
    
    [HttpPost("Generate")]
    public async Task<IActionResult> Generate([FromBody] RoadmapGenerateDto dto) => await Controller(aplic.Generate(dto));
}