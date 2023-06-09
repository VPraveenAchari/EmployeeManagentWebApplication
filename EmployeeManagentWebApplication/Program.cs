using EmployeeManagentWebApplication.Data;
using EmployeeManagentWebApplication.Migrations;
using EmployeeManagentWebApplication.Repository;
using EmployeeManagentWebApplication.Repository.IRepository;
using EmployeeManagentWebApplication.ServiceLayer;
using EmployeeManagentWebApplication.ServiceLayer.IService;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EmployeeDbContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeConnection")));
builder.Services.AddScoped<IEmployee, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();



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
