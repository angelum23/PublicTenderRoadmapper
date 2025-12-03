using SistemaConcurso.Domain.Base.Extensions;
using SistemaConcurso.Domain.Enums;
using SistemaConcurso.Domain.Interfaces.Ai;
using SistemaConcurso.Domain.Interfaces.DPs;
using SistemaConcurso.Domain.Views.AiViews;

namespace SistemaConcurso.Domain.Services;

public class AiMockService// : IAiService
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

    public static string GetMockNoticeText() =>
        "EDITAL DE CONCURSO PÚBLICO Nº 01/2025 - TECNOLOGIA BRASILEIRA S.A. - TECNOBRAS\n\nA TECNOLOGIA BRASILEIRA S.A. - TECNOBRAS, empresa pública federal, torna pública a realização de Concurso Público para o provimento de vagas e a formação de cadastro de reserva para cargos de nível médio e superior, mediante as condições estabelecidas neste edital.\n\n1. DAS DISPOSIÇÕES PRELIMINARES 1.1. O Concurso Público será regido por este edital e executado pelo Centro de Seleção e de Promoção de Eventos (CESPE). 1.2. A seleção para os cargos de que trata este edital compreenderá exames de conhecimentos gerais e específicos, mediante aplicação de provas objetivas, de caráter eliminatório e classificatório.\n\n2. DOS CARGOS DE NÍVEL SUPERIOR\n\n2.1. CARGO 1: ANALISTA DE TECNOLOGIA DA INFORMAÇÃO - DESENVOLVIMENTO DE SISTEMAS\n\nDescrição: Atuar no desenvolvimento e manutenção de sistemas corporativos, utilizando plataformas Java e .NET. Realizar análise de requisitos, modelagem de dados e testes de software.\n\nVagas: 5 (cinco) vagas imediatas + Cadastro de Reserva.\n\nRequisitos: Diploma de conclusão de curso de graduação de nível superior em Ciência da Computação, Engenharia de Software, Análise de Sistemas ou áreas correlatas.\n\nConteúdo Programático: Lógica de Programação, Estrutura de Dados, Engenharia de Software (UML, RUP, Scrum), Banco de Dados (SQL, Oracle), Linguagens de Programação (Java EE, C# .NET Core), Arquitetura de Microsserviços, API Rest.\n\n2.2. CARGO 2: ANALISTA DE TECNOLOGIA DA INFORMAÇÃO - INFRAESTRUTURA E REDES\n\nDescrição: Administrar, configurar e manter a infraestrutura de servidores (Windows Server, Linux), redes corporativas (protocolos TCP/IP, switches, roteadores Cisco) e serviços de nuvem (Azure, AWS).\n\nVagas: 3 (três) vagas imediatas + Cadastro de Reserva.\n\nRequisitos: Diploma de conclusão de curso de graduação de nível superior em Redes de Computadores, Engenharia da Computação ou áreas correlatas. Certificação CCNA é desejável.\n\nConteúdo Programático: Sistemas Operacionais (Linux, Windows Server), Redes de Computadores (Modelo OSI, TCP/IP, Roteamento, VLANs), Segurança da Informação (Firewall, VPN, IDS/IPS), Virtualização (VMware), Cloud Computing (Conceitos de IaaS, PaaS, SaaS).\n\n3. DOS CARGOS DE NÍVEL MÉDIO\n\n3.1. CARGO 3: TÉCNICO DE SUPORTE EM TI\n\nDescrição: Prestar suporte técnico de hardware e software (Help Desk) aos usuários internos, realizar a manutenção de computadores, impressoras e configuração de aplicativos de escritório (Microsoft 365).\n\nVagas: 10 (dez) vagas imediatas + Cadastro de Reserva.\n\nRequisitos: Certificado de conclusão de curso de ensino médio, acrescido de curso técnico em Montagem e Manutenção de Computadores ou similar.\n\nConteúdo Programático: Hardware (Montagem e Manutenção), Sistemas Operacionais (Windows 10/11), Pacote Office (Word, Excel, Outlook), Conceitos básicos de Redes.\n\n4. DAS INSCRIÇÕES 4.1. As inscrições estarão abertas no período de 10 de dezembro de 2025 a 10 de janeiro de 2026, exclusivamente pelo site oficial do CESPE.\n\nBrasília, 09 de novembro de 2025. Diretoria de Gestão de Pessoas - TECNOBRAS";

    #endregion
}