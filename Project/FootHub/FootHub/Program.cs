using FootHub.Contexts;
using FootHub.Services.Interface;
using FootHub.Services.ServiceClass;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<FootHubContext>(
    optionsAction: options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("SQLServerConnection")
    )
);


builder.Services.AddScoped<ICrud, CRUDServiceClass>();

builder.Services.AddScoped<IUser, UserService>();

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
