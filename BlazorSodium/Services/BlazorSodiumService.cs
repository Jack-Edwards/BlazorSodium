using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSodium.Services
{
   public interface IBlazorSodiumService
   {
      Task InitializeAsync();
   }

   public class BlazorSodiumService : IBlazorSodiumService
   {
      private readonly IJSRuntime _jsRuntime;

      private const string _javascriptPath = "\"/js/BlazorSodium.bundle.js\"";

      private const string _bootstrapperScript = $@"
var bootstrapBlazorSodium = (function() {{
    var ready = false;
    return function() {{
        if (!ready) {{
            ready = true;
            var scriptTag = document.createElement(""script"");
            scriptTag.src = {_javascriptPath};
            scriptTag.onload = () => resolve();
            document.body.appendChild(scriptTag);
        }}
    }};
}})();

bootstrapBlazorSodium();";

      public BlazorSodiumService(IJSRuntime jsRuntime)
      {
         _jsRuntime = jsRuntime;
      }

      public async Task InitializeAsync()
      {
         await _jsRuntime.InvokeVoidAsync("eval", new object[] { _bootstrapperScript });
      }
   }
}
