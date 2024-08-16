


using Microsoft.EntityFrameworkCore;
using Tarkiz_Task1.Core.Cust.Implementation;
using Tarkiz_Task1.Core.Cust.Interface;
using Tarkiz_Task1.Infrastructure.PracticeDBContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string connection = builder.Configuration.GetConnectionString("TrainingDb");
builder.Services.AddDbContext< UserDbContext>(option=>option.UseSqlServer(connection));

builder.Services.AddScoped<ICustomerCreator, CustomerCreator>();
builder.Services.AddScoped<IVehicleCreator, VehicleCreator>();
builder.Services.AddScoped<IBookingCreator, BookingCreator>();
builder.Services.AddScoped<IPaymentCreator, PaymentCreator>();
builder.Services.AddScoped<IGetDetails, GetDetails>();
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
