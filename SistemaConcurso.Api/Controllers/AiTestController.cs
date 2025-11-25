using Microsoft.AspNetCore.Mvc;
using SistemaConcurso.Domain.Interfaces.Ai;
using SistemaConcurso.Domain.Services;

namespace SistemaConcurso.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AiTestController : ControllerBase
    {
        private readonly IAiService _aiService;

        public AiTestController(IAiService aiService)
        {
            _aiService = aiService;
        }

        [HttpPost("GenerateRoadmap")]
        public async Task<IActionResult> GenerateRoadmap()
        {
            try
            {
                var result = await _aiService.GenerateRoadmap("ANALISTA DE TECNOLOGIA DA INFORMAÇÃO - INFRAESTRUTURA E REDES", AiMockService.GetMockNoticeText());
                
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(500, new { message = "Falha ao gerar roadmap", error = e.Message });
            }
        }
    }
}