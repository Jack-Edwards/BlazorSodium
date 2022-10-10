# BlazorSodium

BlazorSodium is a simple wrapper for over [libsodium.js](https://github.com/jedisct1/libsodium.js/) to use in Blazor WASM projects.

This is not compatible with Blazor Server.
Do not ask for Blazor Server support.  There are other NuGet packages available that should already work fine for Blazor Server.

## Setup

Add to your Program.cs:

```
builder.Services.AddBlazorSodium();
```

Initialize the `BlazorSodiumService` from any component.
You only need to do this once for the lifecycle of your application.

For example:

```
public partial class BlazorSodiumComponent : ComponentBase
{
   [Inject]
   IBlazorSodiumService BlazorSodiumService { get; set; }

   protected override async Task OnInitializedAsync()
   {
      await BlazorSodiumService.InitializeAsync();
   }
}
```

That is the entirety of the setup.
Now use the static wrapper methods from anywhere in your application.

## Data types

### `byte[]` as a return value

Whenever a Sodium methods returns `byte[]` data, you will need to use `Array.CopyTo(Array array, int index)` to copy the data to an initialized array if you intend to use the data outside of the current scope.
Otherwise the `byte[]` will be garbage collected and you will be left with `null`.

### `int` vs `long`

Javascript's "Number" type is a double-precision 64-bit number, with a maximum safe integer value of `9,007,199,254,740,991`.
This constant is defined as `Number.MAX_SAFE_INTEGER`.
This number should be the theoretical limit you can provide or request from a libsodium.js method.

This number is much larger than the maximum value for a C# `int`, but also much smaller than a C# `long`.
Unfortunately this is why the wrappers in this library use `int` rather than `long`.
I do not want to run the risk of someone providing a number that exceeds `Number.MAX_SAFE_INTEGER` and something catastrophic occurring as a result.

Feel free to fork this repository with support for `long` if you wish.