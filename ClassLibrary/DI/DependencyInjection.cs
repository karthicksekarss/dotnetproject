using ClassLibrary.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DI
{
    public static class DependencyInjection
    {
        public static void AddArrayServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IArrayServices, ArrayServices>(x =>
            {
                return new ArrayServices("data");
            });
        }
    }
}
