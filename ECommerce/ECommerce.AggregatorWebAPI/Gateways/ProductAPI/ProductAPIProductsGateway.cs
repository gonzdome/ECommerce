﻿namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI;

public class ProductAPIProductsGateway
{
    private readonly APIClient _apiClient;
    private const string apiEndpoint = "https://localhost:7174/Product";

    public ProductAPIProductsGateway(APIClient apiClient)
    {
        _apiClient = apiClient;
    }

    protected internal async Task<DetailProductViewModelResponse> DetailProductById(string id)
    {
        var apiResponse = await _apiClient.Handle("GET", "ProductAPI", $"{apiEndpoint}/GetProductDetailsById?id={id}");

        var response = new DetailProductViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (apiResponse.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<DetailProductViewModel>(apiResponse.Data);
        return response;
    }

    protected internal async Task<GetProductsViewModelResponse> GetProducts()
    {
        var apiResponse = await _apiClient.Handle("GET", "ProductAPI", $"{apiEndpoint}/GetProducts");

        var response = new GetProductsViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (response.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<IEnumerable<GetProductsViewModel>>(apiResponse.Data);
        return response;
    }

    protected internal async Task<CreateProductViewModelResponse> CreateProduct(CreateProductViewModel productToCreate)
    {
        var apiResponse = await _apiClient.Handle("POST", "ProductAPI", $"{apiEndpoint}/CreateProduct", productToCreate);

        var response = new CreateProductViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (response.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<CreateProductViewModel>(apiResponse.Data);
        return response;
    }

    protected internal async Task<UpdateProductViewModelResponse> UpdateProductById(UpdateProductViewModel productToUpdate)
    {
        var apiResponse = await _apiClient.Handle("PUT", "ProductAPI", $"{apiEndpoint}/UpdateProductById", productToUpdate);

        var response = new UpdateProductViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (response.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<UpdateProductViewModel>(apiResponse.Data);
        return response;
    }

    protected internal async Task<DetailProductViewModelResponse> DeleteProductById(string id)
    {
        var apiResponse = await _apiClient.Handle("DELETE", "ProductAPI", $"{apiEndpoint}/DeleteProductById?id={id}");

        var response = new DetailProductViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (apiResponse.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<DetailProductViewModel>(apiResponse.Data);
        return response;
    }
}
