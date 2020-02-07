using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;


namespace R5T.Hladir.CSharp
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="CSharpVisualStudioProjectFileNameConventions"/> implementation of <see cref="ICSharpVisualStudioProjectFileNameConventions"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddCSharpVisualStudioProjectFileNameConventions(this IServiceCollection services,
            ServiceAction<IFileNameOperator> addFileNameOperator)
        {
            services
                .AddSingleton<ICSharpVisualStudioProjectFileNameConventions, CSharpVisualStudioProjectFileNameConventions>()
                .RunServiceAction(addFileNameOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="CSharpVisualStudioProjectFileNameConventions"/> implementation of <see cref="ICSharpVisualStudioProjectFileNameConventions"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<ICSharpVisualStudioProjectFileNameConventions> AddCSharpVisualStudioProjectFileNameConventionsAction(this IServiceCollection services,
            ServiceAction<IFileNameOperator> addFileNameOperator)
        {
            var serviceAction = new ServiceAction<ICSharpVisualStudioProjectFileNameConventions>(() => services.AddCSharpVisualStudioProjectFileNameConventions(addFileNameOperator));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioProjectFileNameConventions"/> implementation of <see cref="IVisualStudioProjectFileNameConventions"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddVisualStudioProjectFileNameConventions(this IServiceCollection services,
            ServiceAction<ICSharpVisualStudioProjectFileNameConventions> addCSharpVisualStudioProjectFileNameConventions)
        {
            services
                .AddSingleton<IVisualStudioProjectFileNameConventions, VisualStudioProjectFileNameConventions>()
                .RunServiceAction(addCSharpVisualStudioProjectFileNameConventions)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioProjectFileNameConventions"/> implementation of <see cref="IVisualStudioProjectFileNameConventions"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IVisualStudioProjectFileNameConventions> AddVisualStudioProjectFileNameConventionsAction(this IServiceCollection services,
            ServiceAction<ICSharpVisualStudioProjectFileNameConventions> addCSharpVisualStudioProjectFileNameConventions)
        {
            var serviceAction = new ServiceAction<IVisualStudioProjectFileNameConventions>(() => services.AddVisualStudioProjectFileNameConventions(
                addCSharpVisualStudioProjectFileNameConventions));
            return serviceAction;
        }
    }
}
