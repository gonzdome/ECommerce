var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddHttpClient("ProductAPI", c => { c.BaseAddress = new Uri(builder.Configuration["ServiceUri:ProductAPI:ProductAPIUri"]); });
builder.Services.AddHttpClient("IntegrationAPI", c => { c.BaseAddress = new Uri(builder.Configuration["ServiceUri:IntegrationAPI:IntegrationAPIUri"]); });
builder.Services.AddHttpClient("AuthAPI", c => { c.BaseAddress = new Uri(builder.Configuration["ServiceUri:AuthAPI:AuthAPIUri"]); });
builder.Services.AddHttpClient("CartAPI", c => { c.BaseAddress = new Uri(builder.Configuration["ServiceUri:CartAPI:CartAPIUri"]); });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductAPIProductsService, ProductAPIProductsService>();
builder.Services.AddScoped<IProductAPICategoriesService, ProductAPICategoriesService>();

builder.Services.AddScoped<IIntegrationService, IntegrationService>();
builder.Services.AddScoped<IIntegrationAPIIntegrationService, IntegrationAPIIntegrationService>();
builder.Services.AddScoped<IIntegrationAPIPurchaseService, IntegrationAPIPurchaseService>();

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IUserCategoryService, UserCategoryService>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IAuthAPICategoriesService, AuthAPICategoriesService>();
builder.Services.AddScoped<IAuthAPIUsersService, AuthAPIUsersService>();

builder.Services.AddScoped<IPurchaseService, PurchaseService>();

builder.Services.AddScoped<APIClient>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
