using API.Filter;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using API.Repository;
using Microsoft.Extensions.Configuration;
using API;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LandonContext>(options =>{
    options.UseInMemoryDatabase("landon");
});

builder.Services.AddScoped<IService, Service>();

// Add services to the container.
builder.Services.Configure<HotelInfo>(builder.Configuration.GetSection(HotelInfo.Info));
builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Versioning API
builder.Services.AddApiVersioning(options =>{
    options.DefaultApiVersion = new ApiVersion(1,0);
    options.ApiVersionReader = new MediaTypeApiVersionReader();
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
    options.ApiVersionSelector = new CurrentImplementationApiVersionSelector(options);
});

//Adding Filters
builder.Services.AddMvc(options => {
    options.Filters.Add<JsonExceptionFilter>();
    options.Filters.Add<RequiredHttpsOrCloseAttribute>();
});

builder.Services.AddCors(options=>{
    options.AddPolicy("AllowOrigins", policy=> policy.AllowAnyOrigin());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowOrigin");
//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
