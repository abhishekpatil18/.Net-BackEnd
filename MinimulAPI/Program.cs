using MinimulAPI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



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

