using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SistemaConcurso.Domain.Base.Interfaces;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.Base;

namespace SistemaConcurso.PgRepository.Base;

public class PgDbContext(DbContextOptions options, IClaimService claimService) : DbContext(options)
{
    public int CurrentUserId { get; set; } = claimService.TryGetLoggedUserId();
    
    public DbSet<Exams> Exams { get; set; }
    public DbSet<JobRoles> JobRoles { get; set; }
    public DbSet<Lessons> Lessons { get; set; }
    public DbSet<Modules> Modules { get; set; }
    public DbSet<Questions> Questions { get; set; }
    public DbSet<RefreshTokens> RefreshTokens { get; set; }
    public DbSet<RoadmapAssessments> RoadmapQuestions { get; set; }
    public DbSet<Roadmaps> Roadmaps { get; set; }
    public DbSet<Users> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Model
            .GetEntityTypes()
            .ToList()
            .ForEach(x =>
            {
                x.SetTableName(x.GetTableName()?.ToLower()?.Replace("_", ""));
                x.GetProperties().ToList().ForEach(y =>
                {
                    y.SetColumnName(y.GetColumnName()?.ToLower()?.Replace("_", ""));
                });
            });

        var entities = modelBuilder.Model.GetEntityTypes().ToList();
        entities.ForEach(x => ApplyQueryFilters(x, modelBuilder));
    }

    private void ApplyQueryFilters(IMutableEntityType entityType, ModelBuilder modelBuilder)
    {
        var clrType = entityType.ClrType;
        if (!typeof(IBaseEntity).IsAssignableFrom(clrType)) return;
        
        var parameter = Expression.Parameter(clrType, "e");
        
        var userIdProperty = Expression.PropertyOrField(parameter, nameof(IBaseEntity.UserId));
        var currentUserProp = Expression.Property(Expression.Constant(this), nameof(CurrentUserId));
        var body = Expression.Equal(
            Expression.Convert(userIdProperty, typeof(int?)),
            Expression.Convert(currentUserProp, typeof(int?))
        );

        var lambda = Expression.Lambda(body, parameter);
        modelBuilder.Entity(clrType).HasQueryFilter(lambda);
    }
}