﻿using EasyWork.Blazor.Data;
using Microsoft.AspNetCore.Components.WebView.Maui;

namespace EasyWork.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

            builder.Services.AddSingleton<WeatherForecastService>();

            return builder.Build();
        }
    }
}