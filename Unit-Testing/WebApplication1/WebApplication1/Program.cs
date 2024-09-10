using Main;

static void Main(string[] args)
{
    var builder = WebApplication.CreateBuilder(args);
    var app = builder.Build();

    var mom = new Employee();

    app.MapGet("/", () => "Hello World!");
    app.Run();
}


