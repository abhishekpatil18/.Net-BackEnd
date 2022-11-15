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
