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
```

## Endpoints

Not all endpoints are currently implemented.

- [x] [Commands](https://github.com/projectkudu/kudu/wiki/REST-API#command) ([interface](./KuduApi.Client.Abstractions/Commands/IKuduCommandApiClient.cs))
- [x] [Environment](https://github.com/projectkudu/kudu/wiki/REST-API#environment) ([interface](./KuduApi.Client.Abstractions/Environment/IKuduEnvironmentApiClient.cs))
- [x] [WebJobs API\*](https://github.com/projectkudu/kudu/wiki/WebJobs-API) ([interface](./KuduApi.Client.Abstractions/WebJobs/IKuduWebJobApiClient.cs))
- [x] [Deployments\*](https://github.com/projectkudu/kudu/wiki/REST-API#deployment) ([interface](./KuduApi.Client.Abstractions/Deployments/IKuduDeploymentApiClient.cs))
- [ ] [scm](https://github.com/projectkudu/kudu/wiki/REST-API#scm)
- [ ] [VFS](https://github.com/projectkudu/kudu/wiki/REST-API#vfs)
- [ ] [Zip](https://github.com/projectkudu/kudu/wiki/REST-API#zip)
- [ ] [Zip Deployment](https://github.com/projectkudu/kudu/wiki/REST-API#zip-deployment)
- [ ] [SSHKey](https://github.com/projectkudu/kudu/wiki/REST-API#sshkey)
- [ ] [Settings](https://github.com/projectkudu/kudu/wiki/REST-API#settings)
- [ ] [Diagnostics](https://github.com/projectkudu/kudu/wiki/REST-API#diagnostics)
- [ ] [Diagnostics/Settings](https://github.com/projectkudu/kudu/wiki/REST-API#diagnosticssettings)
- [ ] [SiteExtensions](https://github.com/projectkudu/kudu/wiki/REST-API#siteextensions)

<small>\* Some endpoints are currently not implemented.</small>

## Roadmap

If you want to see a new feature or new endpoint available feel free to create a new issue or pull request. Here are some features which are planned when there is enough enthusiasm for this NuGet package.

- [x] Wrapper implemented for `/api/commands/`
- [x] Wrapper implemented for `/api/environment/`
- [x] Minimal wrappers for `/api/deployments` and `/api/webjobs/`
- [ ] Create method uploading a new [triggered](https://github.com/projectkudu/kudu/wiki/WebJobs-API#upload-a-triggered-job-as-zip) and [continuous](https://github.com/projectkudu/kudu/wiki/WebJobs-API#upload-a-continuous-job-as-zip) webjob.
- [ ] Creating methods for missing endpoints of `/api/deployments/`
- [ ] Creating wrappers for [all other endpoints](https://github.com/projectkudu/kudu/wiki/REST-API).
- [ ] Probably better documentation for usages.

## Usefull resources

- [How to get your deployment credentials.](https://github.com/projectkudu/kudu/wiki/Deployment-credentials)
