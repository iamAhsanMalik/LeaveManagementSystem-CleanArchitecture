using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
namespace LeaveManagement.Application;
public static class ApplicationServices
{
  public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
  {
    services.AddAutoMapper(Assembly.GetExecutingAssembly());
    services.AddMediatR(Assembly.GetExecutingAssembly());

    return services;
  }
}
