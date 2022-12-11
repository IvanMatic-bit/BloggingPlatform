using BloggingPlatform.Database;
using BloggingPlatform.Models;
using BloggingPlatform.Models.SearchRequests;
using BloggingPlatform.Models.UpsertRequests;
using BloggingPlatform.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddTransient<IBlogPostService, BlogPostService>();
builder.Services.AddTransient<ITagService, TagService>();
builder.Services.AddTransient<ICommentService, CommentService>();

builder.Services.AddAutoMapper(typeof(ICommentService));

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<BloggingPlatformContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BloggingPlatform v1"));
//}



//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
