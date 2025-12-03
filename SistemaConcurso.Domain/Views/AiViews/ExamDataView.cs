using SistemaConcurso.Domain.Entities;

namespace SistemaConcurso.Domain.Views.AiViews;

public class ExamDataView
{
    public string Notice { get; set; }
    public string NoticeTitle { get; set; }
    public string NoticeDescription { get; set; }
    public List<ExamDataJobRolesView> JobRoles { get; set; }

    public Exams ToExam(int idUser) => new()
    {
        IdUser = idUser,
        Notice = Notice,
        NoticeDescription = NoticeDescription,
        NoticeTitle = NoticeTitle
    };

    public List<JobRoles> ToJobRoles(int idExam, int idUser)
    {
        return JobRoles.Select(x => new JobRoles()
        {
            IdExam = idExam,
            Name = x.Name,
            UserId = idUser,
            Description = x.Description
        }).ToList();
    }
}

public class ExamDataJobRolesView
{
    public string Name { get; set; }
    public string Description { get; set; }
}