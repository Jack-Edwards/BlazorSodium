using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using System.Runtime.InteropServices.JavaScript;

namespace BlazorSodium.Sodium
{
   public partial class PasswordHashStatic
   {
      [JSImport("sodium.randombytes_buf", "blazorSodium")]
      public static partial byte[] ArgonGenerateSalt(int size = 16);
   }
}
