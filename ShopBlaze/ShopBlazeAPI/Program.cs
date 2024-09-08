using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopBlazeAPI.Interface;
using ShopBlazeAPI.Models;
using ShopBlazeAPI.ShopBlazeRepositories;
using Swashbuckle.AspNetCore.Swagger;


var builder = WebApplication.CreateSlimBuilder(args);

// Register the DbContext
builder.Services.AddDbContext<ShopBlazeEcommerceContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register the repository
builder.Services.AddScoped<IShopBlazeRepo, ShopBlazeRepo>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.MapControllers();
app.UseHttpsRedirection();
app.Run();
