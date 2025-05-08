namespace ECommerce.AggregatorWebAPI.Gateways.AuthAPI.Models.ViewModels.Users;

public class UpdateUserViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public UpdateUserViewModel? Data { get; set; }
}
