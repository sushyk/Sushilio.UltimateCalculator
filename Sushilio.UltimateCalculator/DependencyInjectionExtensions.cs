using Microsoft.Extensions.DependencyInjection;

namespace Sushilio.UltimateCalculator
{
    public static class CalculatorServiceCollectionExtensions
    {
        public static IServiceCollection AddSushilioUltimateCalculator(this IServiceCollection services)
        {
            services.AddTransient<ICalculator, Calculator>();

            return services;
        }
    }
}
