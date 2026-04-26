using xTestAutoMapper.Interfaces;
using xTestAutoMapper.Services;

var builder = WebApplication.CreateBuilder(args);

//
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//
// Add SUpport for Controllers ...
builder.Services.AddControllers();

//
// Register Services ...
builder.Services.AddScoped<ITestService, TestService>();

//
// Register AutoMapper ...
builder.Services.AddAutoMapper(typeof(Program).Assembly);

//
// Building App ...
var app = builder.Build();

//
// Configure the HTTP request pipeline.

//
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//
app.UseHttpsRedirection();
app.MapControllers();

//
// Running App ...
app.Run();
