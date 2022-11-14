var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");


app.MapPost("/calc", (CalcModel calc) =>
{
    switch(calc.Op)
    {
        case"+":
            return Results.Json(calc.Num1 + calc.Num2);
        case"-":
            return Results.Json(calc.Num1 - calc.Num2);
        case"*":
            return Results.Json(calc.Num1 * calc.Num2);
        case"/":
            return Results.Json(calc.Num1 / calc.Num2);
    }
    return Results.Json("Not Supported");
});

app.Run();

class CalcModel
{
    int n1;
    int n2;
    string? op;

    public int Num1
    {
        get { return n1; }
        set { n1 = value; }
    }

    public int Num2
    {
        get { return n2; }
        set { n2 = value; }
    }

    public string Op
    {
        get { return op; }
        set { op = value; }
    }
}

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}