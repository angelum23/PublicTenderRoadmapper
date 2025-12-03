using SistemaConcurso.Domain.Interfaces.Ai;
using SistemaConcurso.Domain.Interfaces.DPs;
using SistemaConcurso.Domain.Views.AiViews;
using System.Net.Http.Json;
using System.Text.Json;
using SistemaConcurso.Domain.Views;

namespace SistemaConcurso.Domain.Services;

public class AiService(HttpClient httpClient) : IAiService
{
    public const string BaseUrl = "https://projeto-integrador-ia-4a0661fec346.herokuapp.com/";
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

        var jsonResponse = await response.Content.ReadAsStringAsync();
        
        try 
        {
            var result = JsonSerializer.Deserialize<ExamSearchWrapper>(jsonResponse, _jsonOptions);
        
            if (result?.ExamDataView?.Notices == null || !result.ExamDataView.Notices.Any()) 
                throw new Exception("No exam found on AI response.");
        
            return result.ExamDataView.Notices.First();
        }
        catch (JsonException ex)
        {
            throw new Exception($"Error deserializing JSON: {jsonResponse}", ex);
        }
    }

    public async Task<RoadmapDataView> GenerateRoadmap(string selectedJobRole, string notice)
    {
        var payload = new { selectedJobRole, notice };

        var response = await httpClient.PostAsJsonAsync(GenerateRoadmapEndpoint, payload);
        var jsonResponse = await response.Content.ReadAsStringAsync();
        response.EnsureSuccessStatusCode();

        try
        {
            var result = JsonSerializer.Deserialize<RoadmapDataWrapper>(jsonResponse, _jsonOptions);

            if (result?.RoadmapDataView == null) 
                throw new Exception("No exam found on AI response.");
            
            return result.RoadmapDataView;
        }
        catch (JsonException ex)
        {
            throw new Exception($"Error deserializing JSON: {jsonResponse}", ex);
        }
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