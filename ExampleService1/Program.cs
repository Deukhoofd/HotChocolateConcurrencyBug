var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer()
    .ModifyRequestOptions(options => options.IncludeExceptionDetails = true)
    .AddExampleService1Types();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);