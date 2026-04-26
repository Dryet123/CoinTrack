using MoneyAgregator.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=MoneyAgregator.db"));

app.Run();