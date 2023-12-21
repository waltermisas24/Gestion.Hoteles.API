using Gestion.Hoteles.API.Domain.Interfaces;
using Gestion.Hoteles.API.Domain.Services;
using Gestion.Hoteles.API.Infraestructure.Repositories;
using Gestion.Hoteles.API.Infraestructure.Utils;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
builder.Services.Configure<Settings>(configuration);

//Services
builder.Services.AddTransient<IReservacionServices, ReservacionServices>();
builder.Services.AddTransient<IHotelServices, HotelServices>();
builder.Services.AddTransient<IHabitacionServices, HabitacionServices>();

//Repositories
builder.Services.AddTransient<IReservacionRepository, ReservacionRepository>();
builder.Services.AddTransient<IHotelRepository, HotelRepository>();
builder.Services.AddTransient<IHabitacionRepository, HabitacionRepository>();


// Add services to the container.

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
