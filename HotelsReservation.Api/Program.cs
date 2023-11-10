﻿var builder = WebApplication.CreateBuilder(args);

var startup = new HotelsReservation.Api.StartUp(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();
startup.Configure(app, builder.Environment);

