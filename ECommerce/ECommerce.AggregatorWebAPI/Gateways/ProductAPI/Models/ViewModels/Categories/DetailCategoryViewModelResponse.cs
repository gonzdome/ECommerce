﻿namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Models.ViewModels.Categories;

public class DetailCategoryViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public DetailCategoryViewModel? Data { get; set; }
}
