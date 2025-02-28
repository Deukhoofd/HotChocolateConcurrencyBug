var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient("Fusion");
builder.Services.AddFusionGatewayServer()
    .ModifyRequestOptions(options => options.IncludeExceptionDetails = true)
    .ConfigureFromFile("gateway.fgp");

var app = builder.Build();

app.MapGraphQL();

app.Run();