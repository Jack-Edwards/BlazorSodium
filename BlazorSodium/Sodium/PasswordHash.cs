using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorSodium.Sodium
{
   public partial class PasswordHash
   {
      private readonly IJSInProcessRuntime _runtime;

      public PasswordHash(IJSInProcessRuntime runtime)
      {
         _runtime = runtime;
      }
   }
}
