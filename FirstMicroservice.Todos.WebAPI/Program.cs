using FirstMicroservice.Todos.WebAPI.Context;
using FirstMicroservice.Todos.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ApplicationDbContext>(options =>  //Burada sql ba�lant�m�z� ge�tik
{
    options.UseInMemoryDatabase("MyDb");
});

var app = builder.Build();

app.MapGet("/todos/create", (string work, ApplicationDbContext context) =>
{
    Todo todo = new Todo()
    {
        Work = work,
    };
    context.Add(todo);
    context.SaveChanges();

    return new { Message = "Todo ba�ar�l� bir �ekilde olu�turuldu" };
});



app.MapGet("/todos/getall", (ApplicationDbContext context) =>
{
    var todos = context.Todos.ToList();
    return todos;
});

app.Run();
