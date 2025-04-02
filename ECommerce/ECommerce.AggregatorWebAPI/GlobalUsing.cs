global using Newtonsoft.Json;
global using Microsoft.AspNetCore.Mvc;
global using System.ComponentModel.DataAnnotations;

global using ECommerce.AggregatorWebAPI.Services;
global using ECommerce.AggregatorWebAPI.Services.Interfaces;

global using ECommerce.AggregatorWebAPI.Models.ViewModels.Product;
global using ECommerce.AggregatorWebAPI.Models.ViewModels.Category;
global using ECommerce.AggregatorWebAPI.Models.ViewModels.Purchase;
global using ECommerce.AggregatorWebAPI.Models.ViewModels.Integration;

global using ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Models.ViewModels.Products;
global using ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Models.ViewModels.Categories;

global using ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Models.ViewModels;
global using ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Models.ViewModels.Purchase;
global using ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Models.ViewModels.Integrations;

global using ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI;

global using ECommerce.AggregatorWebAPI.Gateways.Services;
global using ECommerce.AggregatorWebAPI.Gateways.Services.Interfaces;

global using ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Services;
global using ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Services.Interfaces;

global using ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Services;
global using ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Services.Interfaces;

global using ECommerce.AggregatorWebAPI.Models.ViewModels.User;
global using ECommerce.AggregatorWebAPI.Gateways.AuthAPI.Models.ViewModels.Users;
global using ECommerce.AggregatorWebAPI.Gateways.AuthAPI.Models.ViewModels.Categories;
global using ECommerce.AggregatorWebAPI.Gateways.AuthAPI.Services;
global using ECommerce.AggregatorWebAPI.Gateways.AuthAPI.Services.Interfaces;

global using ECommerce.APIHandler;