using FBags.Application.UseCases.Bags.Register;
using Microsoft.Extensions.DependencyInjection;

namespace FBags.Application;
public static class DependencyInjectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddUseCases(services);
    }

    private static void AddUseCases(IServiceCollection services)
    {
        services.AddScoped<IRegisterBagsUseCase, RegisterBagsUseCase>();
    }
}
