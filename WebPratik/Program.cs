﻿using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();


app.MapControllerRoute(
    name:"Default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();

