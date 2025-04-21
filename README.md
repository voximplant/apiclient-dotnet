# Voximplant API client library

#### Version 3.1.0

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
