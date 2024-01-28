using Microsoft.EntityFrameworkCore;
using TFA.Storage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
// builder.Services.AddDbContext<ForumDbContext>(options => options
//     .UseNpgsql("User ID=postgres;Password=admin;Host=localhost;Database=tfa;Pooling=true;MinPoolSize=0;MaxPoolSize=100;Connection Idle Lifetime=60;"), ServiceLifetime.Singleton);


builder.Services.AddDbContextPool<ForumDbContext>(options => options
    .UseNpgsql("User ID=postgres;Password=admin;Host=localhost;Database=tfa;Pooling=true;MinPoolSize=0;MaxPoolSize=100;Connection Idle Lifetime=60;"));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// app.UseHttpsRedirection();

app.MapControllers();
// app.Services.GetRequiredService<ForumDbContext>().Database.Migrate();

/*
app.MapGet("/forums", async ([FromServices] ForumDbContext db_, CancellationToken cancellationToken) => {
    var forumTitles = await db_.Forums.Select(f=>f.Title).ToArrayAsync(cancellationToken);
    return Ok(forumTitles);
})
.WithName("GetForums")
.WithOpenApi();
*/
app.Run();