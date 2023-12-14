using Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IEmailService, EmailService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
