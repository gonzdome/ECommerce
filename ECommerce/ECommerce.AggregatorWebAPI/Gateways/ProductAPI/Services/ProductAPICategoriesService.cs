namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Services;

public class ProductAPICategoriesService : ProductAPICategoriesGateway, IProductAPICategoriesService
{
    public ProductAPICategoriesService(APIClient apiClient) : base(apiClient)
    {
    }

    public async Task<DetailCategoryViewModelResponse> ProductAPIDetailCategoryById(string id)
    {
        var detailedCategory = await DetailCategoryById(id);
        return detailedCategory;
    }

    public async Task<GetCategoriesViewModelResponse> ProductAPIGetCategories()
    {
        var categoriesListed = await GetCategories();
        return categoriesListed;
    }

    public async Task<CreateCategoryViewModelResponse> ProductAPICreateCategory(CreateCategoryViewModel product)
    {
        var createdCategory = await CreateCategory(product);
        return createdCategory;
    }

    public async Task<UpdateCategoryViewModelResponse> ProductAPIUpdateCategoryById(UpdateCategoryViewModel product)
    {
        var updatedCategory = await UpdateCategoryById(product);
        return updatedCategory;
    }

    public async Task<DetailCategoryViewModelResponse> ProductAPIDeleteCategoryById(string id)
    {
        var deletedCategory = await DeleteCategoryById(id);
        return deletedCategory;
    }
}
