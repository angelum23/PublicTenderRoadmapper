using SistemaConcurso.Domain.Entities;
using SistemaConcurso.Domain.Interfaces.Ai;
using SistemaConcurso.Domain.Views.AiViews;

namespace SistemaConcurso.Domain.Services;

public class AiMockService : IAiService
{
    public ExamDataView ExtractExamData(string noticeText) => GetMock(noticeText);
    public ExamDataView SearchExam(string prompt) => GetMock();

    private ExamDataView GetMock(string noticeText = "")
    {
        return new ExamDataView()
        {
            Notice = noticeText,
            NoticeTitle = "Edital 001/2025 - Biguaçu",
            NoticeDescription = "A Prefeitura Municipal de Biguaçu, por meio da Secretaria Municipal de Administração, no uso de suas\natribuições legais e regulamentares, torna público o Edital de abertura para a realização do Concurso Público,\nEdital n.º 001/2025, destinado ao preenchimento de vagas existentes e à formação de cadastro de reserva\nda Administração Direta da Prefeitura Municipal de Biguaçu, que reger-se-á pela Lei Orgânica do Município,\nLei Complementar n.º 53, de 04 de julho de 2012, e suas alterações, e pelas normas estabelecidas neste\nEdital.",
            JobRoles = new()
            {
                new()
                {
                    Name = "Perito criminal",
                    Description = "Especialização em análise forense e análise de vídeos e piriri pororo."
                },
                new()
                {
                    Name = "Assistente administrativo",
                    Description = "Responsável por atendimento ao público, preenchimento de documentos e formulários."
                },
                new()
                {
                    Name = "Faxineiro",
                    Description = "Responsável pela limpeza de escritórios e banheiros da delegacia."
                }
            }
        };
    }
}