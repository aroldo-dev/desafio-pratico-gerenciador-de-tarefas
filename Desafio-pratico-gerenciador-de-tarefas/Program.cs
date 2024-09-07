using TaskManager.Application.Service.Task;
using TaskManager.Communication.Interface;
using TaskManager.SharedServices;
using TaskManager.SharedServices.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<ITaskDB, TaskDB>();
builder.Services.AddScoped<ITaskRegisterService, TaskRegister>();
builder.Services.AddScoped<ITaskGetAllService, TaskGetAllService>();
builder.Services.AddScoped<ITaskGetService, TaskGetService>();
builder.Services.AddScoped<ITaskUpdateService, TaskUpdateService>();
builder.Services.AddScoped<ITaskDeleteService, TaskDeleteService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
