using CleanPeopleList.Data.Repositories;
using CleanPeopleList.Domain.Interfaces;
using CleanPeopleList.Domain.Repositories;
using CleanPeopleList.Domain.UseCases;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Data.Repositories;

namespace CompositioRoot.Dependencias
{
    public static class Container
    {
        
        public static IServiceCollection AddCompositionRoot(this IServiceCollection services)
        {
           
            services.AddScoped<IGetListadoPersonasUseCase, GetListadoPersonasUseCase>();
            services.AddScoped<IPersonaRepository,  PersonaRepositoryEmpty>();

            return services;
        }
    }
}