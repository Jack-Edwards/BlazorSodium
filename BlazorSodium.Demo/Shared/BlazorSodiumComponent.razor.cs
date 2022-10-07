using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Diagnostics.CodeAnalysis;

namespace BlazorSodium.Demo.Shared
{
   public partial class BlazorSodiumComponent
   {
      protected override async Task OnInitializedAsync()
      {
         await JSHost.ImportAsync("blazorSodium", "../_content/BlazorSodium/blazorSodium.bundle.js");
         Interop.LogSomething("foo");
         await Interop.InitializeAsync();
      }

      [SupportedOSPlatform("browser")]
      public partial class Interop
      {
         [DynamicDependency(DynamicallyAccessedMemberTypes.PublicMethods, typeof(JsonTypeInfo))]
         [DynamicDependency(DynamicallyAccessedMemberTypes.PublicMethods, typeof(JsonSerializerContext))]
         static Interop()
         {
         }

         [JSImport("logSomething", "blazorSodium")]
         public static partial void LogSomething(string something);

         [JSImport("sodium.ready", "blazorSodium")]
         public static partial Task InitializeAsync();
      }
   }
}
