var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string[] quotes = new[]
{
    "Believe you can and you're halfway there.",
    "It always seems impossible until it’s done.",
    "Success is not final, failure is not fatal.",
    "Act as if what you do makes a difference. It does."
};

app.MapGet("/quotes", () =>
{
    var random = new Random();
    var quote = quotes[random.Next(quotes.Length)];
    return Results.Ok(new { quote });
});

app.Run();
