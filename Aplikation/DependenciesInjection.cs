using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Aplikation
{
    public static class DependenciesInjection

    {
        // vet inte riktigt varför vi gör detta men de behövs för apiet
        public static IServiceCollection AddAplikation(this IServiceCollection services) 
        {
           var assembly = typeof(DependenciesInjection).Assembly;

            // vi ladda ner nått nugget packet och nu ska vi introducera det till våran api
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(assembly));

            services.AddValidatorsFromAssembly(assembly);

            return services;
        }



    }
}
