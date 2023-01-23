using Alphastellar.Case.BusinessLayer;
using Alphastellar.Case.CoreLayer;
using Alphastellar.Case.DataAccessLayer;
using Alphastellar.Case.WebApý.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDALServices(builder.Configuration);
builder.Services.AddBusinessServices(builder.Configuration);
builder.Services.AddCoreServices(builder.Configuration);



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddLogging(i =>
{
    i.AddConsole();
    i.AddDebug();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.CustomExceptionMiddleWare();

app.MapControllers();

app.Run();
