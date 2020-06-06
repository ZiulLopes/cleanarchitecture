using Microsoft.Extensions.DependencyInjection;
using Quotes.Project.Application.Interfaces;
using Quotes.Project.Application.Services;
using Quotes.Project.Domain.Interfaces;
using Quotes.Project.Infrastructure.Data.Repositories;

namespace Quotes.Project.Infrastructure.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<IQuoteService, QuoteService>();

            //Infraestructure.Data Layer
            services.AddScoped<IQuoteRepository, QuoteRepository>();
        }
    }
}
