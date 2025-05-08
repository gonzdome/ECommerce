namespace ECommerce.AggregatorWebAPI.Gateways.AuthAPI.Services;

public class AuthAPICategoriesService : AuthAPICategoriesGateway, IAuthAPICategoriesService
{
    public AuthAPICategoriesService(APIClient apiClient) : base(apiClient)
    {
    }

    public async Task<DetailUserCategoryViewModelResponse> AuthAPIDetailCategoryById(string id)
    {
        var detailedCategory = await DetailCategoryById(id);
        return detailedCategory;
    }

    public async Task<GetUserCategoriesViewModelResponse> AuthAPIGetCategories()
    {
        var categoriesListed = await GetCategories();
        return categoriesListed;
    }

    public async Task<CreateUserCategoryViewModelResponse> AuthAPICreateCategory(CreateUserCategoryViewModel product)
    {
        var createdCategory = await CreateCategory(product);
        return createdCategory;
    }

    public async Task<UpdateUserCategoryViewModelResponse> AuthAPIUpdateCategoryById(UpdateUserCategoryViewModel product)
    {
        var updatedCategory = await UpdateCategoryById(product);
        return updatedCategory;
    }

    public async Task<DetailUserCategoryViewModelResponse> AuthAPIDeleteCategoryById(string id)
    {
        var deletedCategory = await DeleteCategoryById(id);
        return deletedCategory;
    }
}
