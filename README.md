# Voximplant API client library

#### Version 3.11.0

> **NOTE**
>
> From **3.11.0**, the dedicated netcoreapp2.1 build is gone.
>
> net452 and netstandard2.0 both compiled, but netcoreapp2.1 asset references Microsoft.NETCore.App 2.1.0, which is
> out of support and still has open advisories, and there is no patched 2.1 runtime to upgrade to.
> A netcoreapp2.1 application still gets the netstandard2.0 build.

## Prerequisites

In order to use Voximplant SDK for the .NET, you need the following:

1. A developer account. If you don't have one, [sign up here](https://voximplant.com/sign-up/).
2. A private API key. There are 2 options to obtain it:
    1. Either generate it in the [Voximplant Control panel](https://manage.voximplant.com/settings/service_accounts)
    1. Or call the [CreateKey](https://voximplant.com/docs/references/httpapi/managing_role_system#createkey) HTTP API
       method with the
       specified [authentication parameters](https://voximplant.com/docs/references/httpapi/auth_parameters). You'll
       receive a response with the __result__ field in it. Save the __result__ value in a file (since we don't store the
       keys, save it securely on your side).

## Getting started

* The best way to start is to use `NuGet` to add the SDK to your Solution:

  ```powershell
  nuget install Voximplant.API
  ```

* Next, specify the path to the JSON service account file either with the ClientConfig file or using the environment.

  **ClientConfig:**
  ```csharp
  var config = new ClientConfiguration
  {
      KeyFile = "/path/to/credentials.json"
  };
  var api = new VoximplantAPI(config);
  ```

  **Environment:**
  ```bash
  export VOXIMPLANT_CREDENTIALS=/path/to/credentials.json
  ```

### HttpClient lifetime

Requests reuse one `HttpClient` for the life of the process, and `Authorization` is set on each request. Sockets stay in
that client's pool.

The package still targets .NET Framework 4.5.2, .NET Standard 2.0, and .NET Core 2.1.

To supply your own client (timeout, proxy, DNS refresh, or a client you already pool in the host), pass a delegate. The
library does not dispose that client. A delegate passed to `Create` is used even when
`ClientConfiguration.CreateHttpClient` is also set.

```csharp
var httpClient = new HttpClient(); // reuse this instance

var api = VoximplantAPI.Create(
    new ClientConfiguration { KeyFile = "/path/to/credentials.json" },
    () => httpClient);
```

You can also set `ClientConfiguration.CreateHttpClient` and pass that configuration to `new VoximplantAPI(config)`.
Dispose a downloaded `FileContent` stream when you are finished with it; that returns the connection to the pool.

### Example

This example shows how you can use the API client.

```csharp
using System;
using Voximplant.API;

namespace example
{
    class Program
    {
        private static void Main(string[] args)
        {
            try {
                var voximplant = new VoximplantAPI();
                
                var result = voximplant.GetSubscriptionPrice().Result;
                
                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
```
