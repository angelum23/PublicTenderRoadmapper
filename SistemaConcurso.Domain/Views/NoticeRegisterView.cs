namespace SistemaConcurso.Domain.Views;

public record NoticeRegisterView(
    List<NoticeJobsView> Jobs,
    int IdExam,
    string? Error
);

public record NoticeJobsView(
    int IdJobRole,
    string JobTitle
);