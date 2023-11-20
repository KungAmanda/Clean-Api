using Infrastruktur.Databas;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastruktur
{
    public static class DependeciesInjection
    {
       

   

        
            // vet inte riktigt varför vi gör detta men de behövs för apiet
            public static IServiceCollection AddInfrastruktur(this IServiceCollection services)
            {
                services.AddSingleton<mockDatabas>();
                return services;
            }



        
    }


}
