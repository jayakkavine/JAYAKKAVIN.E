using Microsoft.EntityFrameworkCore;
using StudentDetails.Context;
using StudentDetails.Services.Interfaces;
using StudentDetails.Services.ServiceClasses;
//using StudentDetails.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//My Code starts Here
builder.Services.AddDbContext<StudentContext>(
    optionsAction: options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("SQLServerConnection")
        )
    );


builder.Services.AddScoped<IStudent,StudentService>();


//My code ends here
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

//app.MapStudentEndpoints();

app.Run();
