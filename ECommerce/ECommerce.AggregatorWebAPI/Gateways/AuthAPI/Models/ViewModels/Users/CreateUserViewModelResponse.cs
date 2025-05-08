namespace ECommerce.AggregatorWebAPI.Gateways.AuthAPI.Models.ViewModels.Users;

public class CreateUserViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public CreateUserViewModel? Data { get; set; }
}
