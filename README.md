# KuduApi.Client

A .NET client wrapper for using the [Kudu API](https://github.com/projectkudu/kudu/wiki/REST-API) with strong-typed requests and responses.

## Getting Started

The `KuduApi.Client` can be installed using the Nuget package manager or the dotnet CLI.

```
dotnet add package KuduApi.Client
```

You can instatie a new Kudu API client by calling the factory:

```csharp
using KuduApi.Client;

var settings = new KuduApiClientSettings()
{
    Endpoint = "https://yourwebsite.scm.azurewebsites.net/api/",
    DeploymentUsername = "$yourwebsite",
    DeploymentCredentials = "P@$$W0RD!",
    HttpClient = new HttpClient(); // Optional Bring Your Own HttpClient (BYOH).
};

var client = KuduApiClientFactory.Create(settings);

var webjobs = await client.WebJobs.GetAll();

var commandResponse = await client.Commands
    .Execute(new KuduCommandRequest() {
        Command = "echo Hello World",
        Directory = "site\\repository"
    });

var deployments = await client.Deployments.GetAll();

var environment = await client.Environment.Get();

// And more...
```

## Roadmap

If you want to see a new feature or new endpoint available feel free to create a new issue. Here are some features which are planned when there is enough enthusiasm for this NuGet package.

- [x] Wrapper implemented for `/api/commands/`
- [x] Wrapper implemented for `/api/environment/`
- [x] Minimal wrappers for `/api/deployments` and `/api/webjobs/`
- [ ] Create method uploading a new [triggered](https://github.com/projectkudu/kudu/wiki/WebJobs-API#upload-a-triggered-job-as-zip) and [continuous](https://github.com/projectkudu/kudu/wiki/WebJobs-API#upload-a-continuous-job-as-zip) webjob.
- [ ] Creating methods for missing endpoints of `/api/deployments/`
- [ ] Creating wrappers for [all other endpoints](https://github.com/projectkudu/kudu/wiki/REST-API).
- [ ] Probably better documentation for usages.

## Usefull resources

- [How to get your deployment credentials.](https://github.com/projectkudu/kudu/wiki/Deployment-credentials)
