using ATM_DEMO_API.Data;
using ATM_DEMO_API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args: args);

/* Services */

var services = builder.Services;

services
    .AddSingleton<RSAEncryptor>()
    .AddSingleton<IDictionary<string, string>>(implementationFactory: provider => new Dictionary<string, string>())
    .AddDbContextPool<BankContext>(optionsAction: action =>
    {
        var connectionString = builder.Configuration.GetConnectionString(name: "Value");

        action.UseSqlServer(connectionString: connectionString, sqlServerOptionsAction: action =>
        {
            action
                .CommandTimeout(commandTimeout: 30)
                .EnableRetryOnFailure(maxRetryCount: 3);
        });

        action
            .EnableDetailedErrors(detailedErrorsEnabled: false)
            .EnableSensitiveDataLogging(sensitiveDataLoggingEnabled: false)
            .EnableThreadSafetyChecks()
            .EnableServiceProviderCaching();
    })
    .AddControllers(configure: options => options.SuppressAsyncSuffixInActionNames = false);

var app = builder.Build();

app
    .UseHsts()
    .UseHttpsRedirection()
    .UseRouting();

app.MapControllers();

app.Run();