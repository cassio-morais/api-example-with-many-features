using Api.Example.With.Many.Features.Rest.ApplicationBuilders;
using Api.Example.With.Many.Features.Rest.DependencyInjection;

namespace Api.Example.With.Many.Features
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddRouting(opt => opt.LowercaseUrls = true);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwagger();
            builder.Services.AddVersioning();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseCustomSwagger();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}