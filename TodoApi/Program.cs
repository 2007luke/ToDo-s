using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using TodoApi.Services;
//using System.Net;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<TodoListDatabaseSettings>(
    builder.Configuration.GetSection("TodoListDatabase"));
    builder.Services.AddSingleton<TodoService>();
builder.Services.AddControllers();
/*builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));*/
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}*/




if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

}

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();