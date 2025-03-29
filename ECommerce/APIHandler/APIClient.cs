using System.Text;
using System.Text.Json;
using APIHandler.Models.ViewModels;

namespace ECommerce.APIHandler;

public class APIClient
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly JsonSerializerOptions _options;

    public APIClient(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public async Task<ApiResponseViewModel> Handle(string method, string apiName, string apiEndpoint, object? data = null)
    {
        StringContent? content = null;
        if (data != null && (method.ToUpper() == "POST" || method.ToUpper() == "PUT"))
            content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

        var client = _httpClientFactory.CreateClient(apiName);
        using var response = await GetHTTPMethod(method, apiEndpoint, client, content);

        var apiResponse = new ApiResponseViewModel();
        apiResponse.Success = response.IsSuccessStatusCode;
        apiResponse.Code = (int)response.StatusCode;
        apiResponse.Data = response.Content.ReadAsStringAsync().Result;
        apiResponse.Message = response.IsSuccessStatusCode ? null : handleError(response.ReasonPhrase);

        return apiResponse;
    }

    private static Task<HttpResponseMessage> GetHTTPMethod(string method, string apiEndpoint, HttpClient client, StringContent? content)
    {
        return method.ToUpper() switch
        {
            "GET" => client.GetAsync(apiEndpoint),
            "POST" => client.PostAsync(apiEndpoint, content),
            "PUT" => client.PutAsync(apiEndpoint, content),
            "DELETE" => client.DeleteAsync(apiEndpoint),
            _ => throw new ArgumentException("Método HTTP inválido. Use GET, POST, PUT ou DELETE.")
        };
    }

    private string handleError(string method)
    {
        if (method.Equals("Bad Request")) return "Verifique se os dados estão corretos!";
        return "Erro ao enviar requisição!";
    }
}
