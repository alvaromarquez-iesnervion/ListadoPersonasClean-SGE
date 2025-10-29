using CleanPeopleList.Domain.Interfaces;
using CleanPeopleList.Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositioRoot.Dependencias
{
    public static class Container
    {
        
        public static IServiceCollection AddListadoPersonasDependencies(this IServiceCollection services)
        {
           
            services.AddScoped<IGetListadoPersonasUseCase, CleanPeopleList.Domain.UseCases.GetListadoPersonasUseCase>();
            services.AddScoped<IPersonaRepository, CleanPeopleList.Data.Repositories.PersonaRepository>();

            return services;
        }
    }
}