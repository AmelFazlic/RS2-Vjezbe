using eProdaja.Services;
using eProdaja.Services.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IProizvodiService, ProizvodiService>();
builder.Services.AddTransient<IKorisniciService, KorisniciService>();
builder.Services.AddTransient<IJedniceMjereService, JediniceMjereService>();
//builder.Services.AddTransient<IService<eProdaja.Model.JediniceMjere>, BaseService<eProdaja.Model.JediniceMjere,JediniceMjere>>();
//builder.Services.AddTransient<IService<eProdaja.Model.Proizvodi>, BaseService<eProdaja.Model.Proizvodi, Proizvodi>>();

builder.Services.AddDbContext<eProdajaContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(IKorisniciService));
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
