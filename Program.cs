
namespace BackendLek3;

public class Program
{
    public static void Main(string[] args)
    {
//         var builder = WebApplication.CreateBuilder(args);
//   builder.Services.AddControllers();
//         // Add services to the container.
//         builder.Services.AddAuthorization();

//         var app = builder.Build();

//         // Configure the HTTP request pipeline.
//         if (app.Environment.IsDevelopment())
//         {
//             app.UseSwagger();
//             app.UseSwaggerUI();
//             // app.MapOpenApi();

//         }

//         app.UseHttpsRedirection();

//         app.UseAuthorization();

//        app.MapControllers();

//         app.Run();
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

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
    }
}
