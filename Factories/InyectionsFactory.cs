using Microsoft.Extensions.DependencyInjection;
using MyServiceWeb.Interfaces;
using MyServiceWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyServiceWeb.Factories
{
    public static class InyectionsFactory
    {
        public static void IoC(IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserPostService, UserPostService>();
        }
    }
}
