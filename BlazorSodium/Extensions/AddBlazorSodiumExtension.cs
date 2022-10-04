using BlazorSodium.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSodium.Extensions
{
   public static class AddBlazorSodiumExtension
   {
      public static IServiceCollection AddBlazorSodium(this IServiceCollection services)
      {
         return ServiceCollectionDescriptorExtensions.Add(services,
            new ServiceDescriptor(typeof(IBlazorSodiumService),
            serviceProvider => new BlazorSodiumService(serviceProvider.GetRequiredService<IJSRuntime>()),
            ServiceLifetime.Scoped));
      }
   }
}
