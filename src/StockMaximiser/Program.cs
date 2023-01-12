using CodingChallenge.Qa.StockMaximiser;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IMaximiser, Maximiser>();
var app = builder.Build();

app.MapGet("/maximiser", (IMaximiser maximiser, string prices) =>
{
    
    var pricesConverted = prices.Split(",").Select(p => decimal.Parse(p)).ToList();
    return new { Max = maximiser.Max(pricesConverted)};
});

app.Run();