using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Evosmos.Thessaloniki;
using R5T.Lombardy.Standard;
using R5T.Thessaloniki.CDrive;


namespace R5T.Evosmos.CDriveTemp
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds an <see cref="ITemporaryDirectoryFilePathProvider"/> service.
        /// </summary>
        public static IServiceCollection AddTemporaryDirectoryFilePathProvider(this IServiceCollection services)
        {
            services.AddThessalonikiTemporaryDirectoryFilePathProvider(
                services.AddTemporaryDirectoryPathProviderAction(),
                services.AddStringlyTypedPathOperatorAction())
                ;

            return services;
        }

        /// <summary>
        /// Adds an <see cref="ITemporaryDirectoryFilePathProvider"/> service.
        /// </summary>
        public static ServiceAction<ITemporaryDirectoryFilePathProvider> AddTemporaryDirectoryFilePathProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ITemporaryDirectoryFilePathProvider>(() => services.AddTemporaryDirectoryFilePathProvider());
            return serviceAction;
        }
    }
}
