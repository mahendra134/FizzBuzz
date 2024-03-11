using FizzBuzz.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IFizzBuzzService, FizzBuzzService>();
builder.Services.AddScoped<IFizzBuzzServiceFactory, FizzBuzzServiceFactory>();
builder.Services.AddScoped<IFizzBuzzService>(provider =>
{
    var factory = provider.GetService<IFizzBuzzServiceFactory>();
    return factory.CreateFizzBuzzService();
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
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
