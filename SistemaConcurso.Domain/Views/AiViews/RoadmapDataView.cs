using SistemaConcurso.Domain.Entities;

namespace SistemaConcurso.Domain.Views.AiViews;

public class RoadmapDataView
{
    public string Title { get; set; }
    public string Description { get; set; }
    public List<ModulesDataView> Modules { get; set; }
    
    public Roadmaps ToRoadmap(int idExam, int idSelectedJobRole, int idUser)
    {
        return new Roadmaps()
        {
            Title = Title,
            Description = Description,
            IdExam = idExam,
            UserId = idUser,
            IdSelectedJobRole = idSelectedJobRole
        };
    }
}

public class ModulesDataView
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int Order { get; set; }
    public List<LessonsDataView> Lessons { get; set; }
    
    public Modules ToModule(int idRoadmap, int idUser)
    {
        return new Modules()
        {
            Title = Title,
            Description = Description,
            Order = Order,
            UserId = idUser,
            IdRoadmap = idRoadmap
        };
    }
}

public class LessonsDataView
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int Order { get; set; }
    
    public Lessons ToLesson(int idModule, int idUser)
    {
        return new Lessons()
        {
            Title = Title,
            Description = Description,
            Order = Order,
            UserId = idUser,
            IdModule = idModule
        };
    }
}