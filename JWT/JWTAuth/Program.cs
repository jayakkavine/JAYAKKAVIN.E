using JWTAuth.Models;
using JWTAuth.Services.Interface;
using JWTAuth.Services.ServiceClass;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<StudentContext>(
            optionsAction: options => 
            options.UseSqlServer(
                builder.Configuration.GetConnectionString("SQLServerConnection"))
            );

        builder.Services.AddScoped<IUser, UserService>();

        builder.Services.AddScoped<IStudent, StudentService>();

        builder.Services.AddScoped<IToken, TokenService>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}