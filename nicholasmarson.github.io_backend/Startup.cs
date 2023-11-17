namespace nicholasmarson.github.io_backend;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection; 
using nicholasmarson.github.io_backend.DAOs;

public class Startup
{
    public IConfiguration Configuration { get; }
    
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }  
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddCors();
        services.AddSingleton<IGuestBookEntryDAO>(new GuestBookEntryDAO(Configuration["ConnectionStrings:Default"]));
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseCors(builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
