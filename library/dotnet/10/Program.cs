var builder = WebApplication.CreateSlimBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello, World!\n");

Console.WriteLine("Waiting for HTTP connections on port 8080 ...");
app.Run("http://0.0.0.0:8080");
