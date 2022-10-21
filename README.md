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

When a Sodium methods returns `byte[]` data, you often need to use `Array.CopyTo(Array array, int index)` to copy the data to an initialized array if you intend to use the data outside of the current scope.
Otherwise the `byte[]` may be garbage collected and your variable will be `null`.
