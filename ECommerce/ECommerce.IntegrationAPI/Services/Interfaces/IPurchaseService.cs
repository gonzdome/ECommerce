﻿namespace ECommerce.IntegrationAPI.Services.Interfaces;

public interface IPurchaseService
{
    Task<PurchaseAPIPostResponse> Purchase(PurchaseAPIPostRequest purchaseAPIPostRequest, string ApiName, string ApiUri);
}
