using Microsoft.EntityFrameworkCore;
using NZBDK.Data;
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
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<NzbdkDBContext>(o => o.UseSqlServer(builder.Configuration["ConnectionString"]));

builder.Services.AddScoped<IRepositoryWorker, RepositoryWorker>();;
builder.Services.AddScoped<IRepository<Field>, FieldRepository>();
builder.Services.AddScoped<IRepository<Sygnature>, SygnatureRepository>();
builder.Services.AddScoped<IRepository<Segment>, SegmentRepository>();
builder.Services.AddScoped<IRepository<Variant>, VariantRepository>();

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

app.Run();
