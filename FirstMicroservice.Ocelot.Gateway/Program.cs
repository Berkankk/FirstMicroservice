using Microsoft.VisualBasic;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

builder.Configuration.AddJsonFile("Ocelot/ocelot.json", optional: false, reloadOnChange: true);
//Klas�rde tuttu�umuz i�in bu �ekilde yolunu verdil


builder.Services.AddOcelot();


var app = builder.Build();

app.UseCors(x=>x.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());

app.MapGet("/", () => "Hello World!");

app.UseOcelot().Wait();

app.Run();
