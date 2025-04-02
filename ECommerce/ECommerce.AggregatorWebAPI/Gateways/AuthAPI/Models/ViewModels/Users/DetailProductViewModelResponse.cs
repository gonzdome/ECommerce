namespace ECommerce.AggregatorWebAPI.Gateways.AuthAPI.Models.ViewModels.Users;

public class DetailUserViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public DetailUserViewModel? Data { get; set; }
}
