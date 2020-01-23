using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Evosmos.Thessaloniki;
using R5T.Lombardy.Standard;
using R5T.Thessaloniki.CDrive;


namespace R5T.Evosmos.CDriveTemp.Code.Services.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddTemporaryDirectoryFilePathProvider(this IServiceCollection services)
        {
            services
                .AddSingleton<ITemporaryDirectoryFilePathProvider, TemporaryDirectoryFilePathProvider>()
                .AddTemporaryDirectoryPathProvider()
                .AddStringlyTypedPathOperator()
                ;

            return services;
        }
    }
}
