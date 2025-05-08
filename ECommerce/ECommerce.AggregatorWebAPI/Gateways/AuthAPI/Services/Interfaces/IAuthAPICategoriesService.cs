namespace ECommerce.AggregatorWebAPI.Gateways.AuthAPI.Services.Interfaces;

public interface IAuthAPICategoriesService
{
    public Task<GetUserCategoriesViewModelResponse> AuthAPIGetCategories();
    public Task<DetailUserCategoryViewModelResponse> AuthAPIDetailCategoryById(string id);
    public Task<CreateUserCategoryViewModelResponse> AuthAPICreateCategory(CreateUserCategoryViewModel product);
    public Task<UpdateUserCategoryViewModelResponse> AuthAPIUpdateCategoryById(UpdateUserCategoryViewModel product);
    public Task<DetailUserCategoryViewModelResponse> AuthAPIDeleteCategoryById(string id);
}
