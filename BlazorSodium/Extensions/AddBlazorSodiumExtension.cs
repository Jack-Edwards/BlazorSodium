using BlazorSodium.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BlazorSodium.Extensions
{
   /// <summary>
   /// Static class to help add BlazorSodium to the project.
   /// </summary>
   public static class AddBlazorSodiumExtension
   {
      /// <summary>
      /// Add IBlazorSodiumService as a scoped service.
      /// </summary>
      /// <param name="services"></param>
      public static void AddBlazorSodium(this IServiceCollection services)
      {
         services.TryAddScoped<IBlazorSodiumService, BlazorSodiumService>();
      }
   }
}
