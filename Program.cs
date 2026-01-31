using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using RapidApi.Services;
using Serilog;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
// Adding Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Adding GeoDbService
builder.Services.AddHttpClient<GeoDbService>();
System.Console.WriteLine("GeoDbService added");
// Adding DeepTranslateService
builder.Services.AddHttpClient<DeepTranslateService>();
System.Console.WriteLine("DeepTranslateService added");
// Adding WeatherService
builder.Services.AddHttpClient<WeatherService>();
System.Console.WriteLine("WeatherService added");
// Adding FTService
builder.Services.AddHttpClient<FootballService>();
System.Console.WriteLine("FootballService added");
// Adding BinIpCheckerService
builder.Services.AddHttpClient<BinIpCheckerService>();
System.Console.WriteLine("BinIpCheckerService added");
// Adding TheRundownService
builder.Services.AddHttpClient<TheRundownService>();
System.Console.WriteLine("TheRundownService added");

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.Run();
