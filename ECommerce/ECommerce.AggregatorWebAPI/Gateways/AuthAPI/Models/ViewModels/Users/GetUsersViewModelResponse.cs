namespace ECommerce.AggregatorWebAPI.Gateways.AuthAPI.Models.ViewModels.Users;

public class GetUsersViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public IEnumerable<GetUsersViewModel>? Data { get; set; }
}
