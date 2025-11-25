using SistemaConcurso.Domain.Interfaces.Ai;
using SistemaConcurso.Domain.Interfaces.DPs;
using SistemaConcurso.Domain.Views.AiViews;
using System.Net.Http.Json;
using System.Text.Json;
using SistemaConcurso.Domain.Views;

namespace SistemaConcurso.Domain.Services;

public class AiService(HttpClient httpClient) //: IAiService
{
    private const string ExtractExamDataEndpoint = "extract_notice_data";
    private const string SearchExamEndpoint = "search_notice";
    private const string GenerateRoadmapEndpoint = "extract_roadmap";
    private const string GenerateQuestionsEndpoint = "generate_questions";
    
    private static readonly JsonSerializerOptions _jsonOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    public async Task<ExamDataView> ExtractExamData(string noticeText)
    {
        var payload = new { notice = noticeText };

        var response = await httpClient.PostAsJsonAsync(ExtractExamDataEndpoint, payload);
        response.EnsureSuccessStatusCode();
        
        var result = await response.Content.ReadFromJsonAsync<ExamDataWrapper>(_jsonOptions);
        if(result == null) throw new Exception();
        
        return result.ExamDataView;
    }

    public async Task<ExamDataView> SearchExam(string prompt)
    {
        var payload = new { prompt };

        var response = await httpClient.PostAsJsonAsync(SearchExamEndpoint, payload);
        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<ExamDataWrapper>(_jsonOptions);
        if(result == null) throw new Exception();
        
        return result.ExamDataView;
    }

    public async Task<RoadmapDataView> GenerateRoadmap(string selectedJobRole, string notice)
    {
        var payload = new { selectedJobRole, notice };

        var response = await httpClient.PostAsJsonAsync(GenerateRoadmapEndpoint, payload);
        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<RoadmapDataWrapper>(_jsonOptions);
        if(result == null) throw new Exception();
        
        return result.RoadmapDataView;
    }

    public async Task<List<QuestionView>> GenerateQuestions(ISubject subject, int quantity)
    {
        var payload = new { subject, quantity };

        var response = await httpClient.PostAsJsonAsync(GenerateQuestionsEndpoint, payload);
        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<QuestionsWrapper>(_jsonOptions);
        if(result == null) throw new Exception();
        
        return result.Questions;
    }
}