namespace APIHandler.Models.ViewModels;

public class ApiResponseViewModel
{
    public bool Success { get; set; }
    public int Code { get; set; }
    public string Data { get; set; }
    public string Message { get; set; }
}
