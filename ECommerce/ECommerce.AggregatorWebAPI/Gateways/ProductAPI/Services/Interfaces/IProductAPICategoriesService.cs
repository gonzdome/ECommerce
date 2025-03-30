namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Services.Interfaces;

public interface IProductAPICategoriesService
{
    public Task<GetCategoriesViewModelResponse> ProductAPIGetCategories();
    public Task<DetailCategoryViewModelResponse> ProductAPIDetailCategoryById(string id);
    public Task<CreateCategoryViewModelResponse> ProductAPICreateCategory(CreateCategoryViewModel product);
    public Task<UpdateCategoryViewModelResponse> ProductAPIUpdateCategoryById(UpdateCategoryViewModel product);
    public Task<DetailCategoryViewModelResponse> ProductAPIDeleteCategoryById(string id);
}
