using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    
    builder.Services.AddControllers();
    builder.Services.AddDbContext<DataContext>(opt =>
    {
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
    });

    var app = builder.Build();

    // Add routing middleware
    app.UseRouting();

    // Add endpoint to handle requests to the root path
    //app.MapGet("/", async context =>
    //{
      //  await context.Response.WriteAsync("Hello World!");
    //});

    app.UseHttpsRedirection();
    app.MapControllers();


    app.Run();
