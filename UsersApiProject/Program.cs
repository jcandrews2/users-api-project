using UsersApiProject.Repositories;
using UsersApiProject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IUsersService, UsersService>();
builder.Services.AddTransient<IEmployeesRepository, EmployeesRepository>();
builder.Services.AddTransient<IEmployeesService, EmployeesService>();
builder.Services.AddTransient<ICustomersRepository, CustomersRepository>();
builder.Services.AddTransient<ICustomersService, CustomersService>();

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

