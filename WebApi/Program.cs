using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<IBlogDal,EfBlogDal>();
builder.Services.AddScoped<IBlogManager, BlogManager>();
builder.Services.AddScoped<ICategoryManager, CategoryManager>();

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
