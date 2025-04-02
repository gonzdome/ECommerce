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

    public async Task<ApiResponseViewModel> Handle(string method, string apiName, string apiEndpoint, object? data = null, List<ApiHeadersViewModel>? headers = null)
    {
        HttpResponseMessage response = await CreateHTTPClient(method, apiEndpoint, data, headers);

        var apiResponse = new ApiResponseViewModel();
        apiResponse.Success = response.IsSuccessStatusCode;
        apiResponse.Code = (int)response.StatusCode;
        apiResponse.Data = response.Content.ReadAsStringAsync().Result;
        apiResponse.Message = response.IsSuccessStatusCode ? null : handleError(response.ReasonPhrase);

        return apiResponse;
    }

    private async Task<HttpResponseMessage> CreateHTTPClient(string method, string apiEndpoint, object? data, List<ApiHeadersViewModel>? headers = null)
    {
        var httpRequestMessage = new HttpRequestMessage();
        httpRequestMessage.RequestUri = new Uri(apiEndpoint);
        httpRequestMessage.Method = await HandleHTTPMethod(method);

        if (headers != null)
            SetHeaders(headers, httpRequestMessage);

        if (data != null && (method.ToUpper() == "POST" || method.ToUpper() == "PUT"))
            httpRequestMessage.Content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

        var response = await _httpClientFactory.CreateClient().SendAsync(httpRequestMessage);
        return response;
    }

    private async Task<HttpMethod> HandleHTTPMethod(string method)
    {
        return method.ToUpper() switch
        {
            "GET" => HttpMethod.Get,
            "POST" => HttpMethod.Post,
            "PUT" => HttpMethod.Put,
            "DELETE" => HttpMethod.Delete,
            _ => throw new ArgumentException("Método HTTP inválido. Use GET, POST, PUT ou DELETE.")
        };
    }

    private static void SetHeaders(List<ApiHeadersViewModel>? headers, HttpRequestMessage httpRequestMessage)
    {
        foreach (var item in headers)
            httpRequestMessage.Headers.Add(item.HeaderProperty, item.HeaderValue);
    }

    private string handleError(string method)
    {
        if (method.Equals("Bad Request")) return "Verifique se os dados estão corretos!";
        return "Erro ao enviar requisição!";
    }
}
