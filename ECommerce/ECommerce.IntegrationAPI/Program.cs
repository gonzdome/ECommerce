using ECommerce.IntegrationAPI.Gateways.PurchaseAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddHttpClient("PurchaseAPI", c => { c.BaseAddress = new Uri(builder.Configuration["ServiceUri:PurchaseAPI:PurchaseAPIUri"]); });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)));


builder.Services.AddScoped<IPurchaseService, PurchaseService>();
builder.Services.AddScoped<IPurchaseAPIService, PurchaseAPIService>();
builder.Services.AddScoped<IIntegrationService, IntegrationService>();

builder.Services.AddScoped<IIntegrationRepository, IntegrationRepository>();
builder.Services.AddScoped(typeof(ICommonRepository<>), typeof(CommonRepository<>));

builder.Services.AddScoped<APIClient>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IGatewayUnitOfWork, GatewayUnitOfWork>();

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
