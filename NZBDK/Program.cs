using Microsoft.EntityFrameworkCore;
using NZBDK.Data;
using NZBDK.Helpers;
using NZBDK.Interfaces;
using NZBDK.Models;
using NZBDK.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var MyPolicy = "MyPolicy";

builder.Services.AddCors(o => o.AddPolicy(MyPolicy, builder =>
{
    builder.AllowAnyHeader();
    builder.AllowAnyMethod();
    builder.AllowAnyOrigin();
}));


builder.Services.AddControllers();

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<NzbdkDBContext>(o => o.UseSqlServer(builder.Configuration["ConnectionString"]));

builder.Services.AddScoped<IRepositoryWorker, RepositoryWorker>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyPolicy);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<JwtMiddleware>();

app.Run();
