using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;
using SistemaConcurso.Domain.Base.Extensions;
using SistemaConcurso.Domain.Enums;
using SistemaConcurso.Domain.Exceptions;

namespace SistemaConcurso.Api.Base;

[ApiController]
[Route("api/[controller]")]
public class BasierController : ControllerBase
{
    [NonAction]
    protected IActionResult Error(Exception e, string? message = null)
    {
        LogError(e);

        if (e is RuleException)
        {
            return BadRequest(e.Message);
        }
        
        var returnMessage = message ?? "An error has occurred, try again later!";
        return BadRequest(returnMessage);
    }

    [NonAction]
    protected IActionResult Error(Exception e, EException eException)
    {
        var returnMessage = eException.GetDescription();
        return Error(e, returnMessage);
    }
    
    [NonAction]
    protected IActionResult HandleError(Exception e)
    {
        LogError(e);

        return StatusCode(500, new
        {
            success = false,
            message = e.Message,
            innerException = e.InnerException?.Message,
            stackTrace = e.StackTrace
        });
    }
    
    [NonAction]
    private static void LogError(Exception e)
    {
        Console.WriteLine("=================================================");
        Console.WriteLine($"[ERROR] {DateTime.Now}");
        Console.WriteLine($"Message: {e.Message}");
        Console.WriteLine($"Stack Trace: {e.StackTrace}");
        if (e.InnerException != null)
        {
            Console.WriteLine($"Inner Exception: {e.InnerException.Message}");
        }
        Console.WriteLine("=================================================");
    }
}