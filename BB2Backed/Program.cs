using BB2Backed;
using BB2Backed.Service;
using CreatingLevel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton(typeof(IContentGeneratorService),typeof(RealGenerator));
builder.Services.AddSingleton(typeof(LevelGenerator));
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()     // Разрешить все домены
              .AllowAnyMethod()     // Разрешить все HTTP-методы
              .AllowAnyHeader();    // Разрешить любые заголовки
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.MapControllers();

app.Run();
