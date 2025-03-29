using ECommerce.AggregatorWebAPI.Models.ViewModels;
using System.Text.Json;

namespace ECommerce.AggregatorWebAPI.Services;

public class CategoryService : ICategoryService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private const string apiEndpoint = "/category/";
    private readonly JsonSerializerOptions _options;

    public CategoryService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public async Task<IEnumerable<GetCategoriesViewModel>> GetCategories()
    {
        throw new NotImplementedException();
    }

    public async Task<DetailCategoryViewModel> DetailCategoryById(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<CreateCategoryViewModel> CreateCategory(CreateCategoryViewModel product)
    {
        throw new NotImplementedException();
    }

    public async Task<UpdateCategoryViewModel> UpdateCategoryById(string id, UpdateCategoryViewModel product)
    {
        throw new NotImplementedException();
    }

    public async Task<DetailCategoryViewModel> DeleteCategoryById(string id)
    {
        throw new NotImplementedException();
    }
}
