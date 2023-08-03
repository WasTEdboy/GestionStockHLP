using GestionStockHLP.Services.EmplacementService;
using GestionStockHLP.Services.InventaireService;
using GestionStockHLP.Services.LocationService;
using GestionStockHLP.Services.MagasinierService;
using GestionStockHLP.Services.MagasinService;
using GestionStockHLP.Services.StockService;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMagasinier, MagasinierService>();
builder.Services.AddScoped<IInventaireService, InventaireService>();
builder.Services.AddScoped<IEmplacementService, EmplacementService>();
builder.Services.AddScoped<IMagasinService, MagasinService>();
builder.Services.AddScoped<IStockService, StockService>();
builder.Services.AddScoped<ILocationService, LocationService>();






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
