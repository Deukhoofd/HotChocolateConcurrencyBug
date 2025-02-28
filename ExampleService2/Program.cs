var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer()
    .ModifyRequestOptions(options => options.IncludeExceptionDetails = true)
    .AddExampleService2Types();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);