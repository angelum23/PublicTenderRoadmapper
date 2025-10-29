using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using SistemaConcurso.Domain.Interfaces.ModuleAssessment;
using SistemaConcurso.Domain.Services;

namespace SistemaConcurso.Domain.Base;

public static class DomainModule
{
    public static IServiceCollection AddDomain(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        
        services.Scan(scan => 
            scan.FromAssemblies(assembly)
                .AddClasses(x => 
                    x.Where(y => y is { IsPublic: true, IsAbstract: false } 
                           && y.GetInterfaces()
                               .Any(z => z.Namespace == null || !z.Namespace.StartsWith("System"))))
                .AsImplementedInterfaces()
                .WithScopedLifetime());
        
        services.AddScoped<IModuleAssessmentService, ModuleAssessmentService>();
        
        return services;
    }
}