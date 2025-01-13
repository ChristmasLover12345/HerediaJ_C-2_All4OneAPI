using HerediaJ_C_2_All4OneAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<HelloWorldService>();
builder.Services.AddScoped<AskingQuestionsService>();
builder.Services.AddScoped<AddingTwoService>();
builder.Services.AddScoped<MadLibServices>();
builder.Services.AddScoped<OddOrEvenService>();
builder.Services.AddScoped<ReverseItAlphaService>();
builder.Services.AddScoped<ReverseItNumbersService>();
builder.Services.AddScoped<Magic8BallService>();

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
