﻿using Butler.Bot.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Butler.Bot.Sqlite;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSqliteUserRepository(this IServiceCollection services, IConfiguration config)
    {
        services.Configure<SqliteUserRepositoryOptions>(config);

        services.AddSingleton<SqlightDatabase>();
        services.AddSingleton<IUserRepository, SqliteUserRepository>();

        return services;
    }
}
