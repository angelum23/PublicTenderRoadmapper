using SistemaConcurso.Domain.Base.Extensions;
using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Enums;
using SistemaConcurso.Domain.Interfaces.Ai;
using SistemaConcurso.Domain.Interfaces.DPs;
using SistemaConcurso.Domain.Views.AiViews;

namespace SistemaConcurso.Domain.Services;

public class AiMockService : IAiService
{
    public Task<ExamDataView> ExtractExamData(string noticeText) => Task.FromResult(GetExamMock(noticeText));
    public Task<ExamDataView> SearchExam(string prompt) => Task.FromResult(GetExamMock());
    public Task<RoadmapDataView> GenerateRoadmap(string selectedJobRole, string notice) => Task.FromResult(GetRoadmapMock(selectedJobRole, notice));
    public Task<List<QuestionView>> GenerateQuestions(ISubject subject, int quantity) => Task.FromResult(GetQuestionsMock(subject, quantity));


    #region Mocks
    
    private static List<QuestionView> GetQuestionsMock(ISubject subject, int quantity)
    {
        var question = new QuestionView
        {
            Question = "Which one is the correct option?",
            Origin = EOriginExtensions.FromAssessmentType(subject.GetAssessmentType()),
            OptionA = "Option A?",
            OptionB = "Option B?",
            OptionC = "Option C?",
            OptionD = "Option D?",
            CorrectOption = EOptionChar.A
        };
        
        var questions = Enumerable.Repeat(question, quantity).ToList();
        ListExtensions.Times(quantity).ForEach(x => questions[x].Order = x + 1);
        
        return questions;
    }
    
    private static ExamDataView GetExamMock(string noticeText = "") =>
        new()
        {
            Notice = noticeText,
            NoticeTitle = "Edital 001/2025 - Biguaçu",
            NoticeDescription =
                "A Prefeitura Municipal de Biguaçu, por meio da Secretaria Municipal de Administração, no uso de suas\natribuições legais e regulamentares, torna público o Edital de abertura para a realização do Concurso Público,\nEdital n.º 001/2025, destinado ao preenchimento de vagas existentes e à formação de cadastro de reserva\nda Administração Direta da Prefeitura Municipal de Biguaçu, que reger-se-á pela Lei Orgânica do Município,\nLei Complementar n.º 53, de 04 de julho de 2012, e suas alterações, e pelas normas estabelecidas neste\nEdital.",
            JobRoles =
            [
                new ExamDataJobRolesView
                {
                    Name = "Perito criminal",
                    Description = "Especialização em análise forense e análise de vídeos e piriri pororo."
                },

                new ExamDataJobRolesView
                {
                    Name = "Assistente administrativo",
                    Description = "Responsável por atendimento ao público, preenchimento de documentos e formulários."
                },

                new ExamDataJobRolesView
                {
                    Name = "Faxineiro",
                    Description = "Responsável pela limpeza de escritórios e banheiros da delegacia."
                }
            ]
        };

    private static RoadmapDataView GetRoadmapMock(string selectedJobRole, string notice) =>
        new()
        {
            Title = "Roadmap do carlão",
            Description = $"Roadmap para o cargo de {selectedJobRole} baseado no edital:\n{notice}",
            Modules =
            [
                new ModulesDataView
                {
                    Title = "Módulo 1",
                    Description = "Descrição do módulo 1",
                    Order = 1,
                    Lessons =
                    [
                        new LessonsDataView
                        {
                            Title = "Aula 1",
                            Description = "Descrição da aula 1",
                            Order = 1
                        },
                        new LessonsDataView
                        {
                            Title = "Aula 2",
                            Description = "Descrição da aula 2",
                            Order = 2
                        }
                    ]
                },
                new ModulesDataView
                {
                    Title = "Módulo 2",
                    Description = "Descrição do módulo 2",
                    Order = 2,
                    Lessons =
                    [
                        new LessonsDataView
                        {
                            Title = "Aula 1",
                            Description = "Descrição da aula 1",
                            Order = 1
                        },
                        new LessonsDataView
                        {
                            Title = "Aula 2",
                            Description = "Descrição da aula 2",
                            Order = 2
                        }
                    ]
                }
            ]
        };

    #endregion
}