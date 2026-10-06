<div align="center">
  <img src="assets/nuget-icon.png" alt="Codex CNJ .NET SDK" width="112" />
  <h1>Codex CNJ .NET SDK</h1>
  <p><strong>Strongly typed .NET client for the CNJ Codex Process API.</strong></p>

  [![CI](https://github.com/loud-technology/loud-technology-codex-cnj-sdk/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/loud-technology/loud-technology-codex-cnj-sdk/actions/workflows/dotnet.yml)
  [![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
  [![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
</div>

## Features

- Complete coverage of the provided Codex CNJ Swagger `v1.7.30` specification.
- 43 async operations organized into 11 clients by API tag.
- Strongly typed contracts, enums, source-generated JSON serialization, and model validation.
- Authentication through the `Authorization` header.
- Typed HTTP exception hierarchy and response wrappers.
- Deterministic generation with AutoSDK `0.30.2-dev.152` and validated OpenAPI overrides.

> [!NOTE]
> This community SDK is maintained by loud-technology and is not an official CNJ SDK.

## Requirements

- .NET 10 SDK or later to build
- A valid credential for the Codex CNJ Process API

## Install

```bash
dotnet add package Codex.Cnj
```

## Quick start

The API expects the complete value of the `Authorization` header. If your issuer uses the Bearer scheme, include the `Bearer ` prefix:

```bash
export CODEX_CNJ_ACCESS_TOKEN="Bearer your-access-token"
```

```csharp
using Loud.Technology.Codex.Cnj.Sdk;

using var client = CodexCnjClient.CreateFromEnvironment();

var exists = await client.ProcessosDatalake.ProcessoExisteAsync(
    numeroProcesso: "0001234-56.2023.8.26.0000");

if (exists)
{
    var processes = await client.ProcessosDatalake
        .RecuperarProcessoPorNumeroProcessoAsync("0001234-56.2023.8.26.0000");
}
```

### Explicit credential and endpoint

```csharp
using var httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(30) };
using var client = new CodexCnjClient(
    apiKey: "Bearer your-access-token",
    httpClient: httpClient,
    baseUri: new Uri("https://api-processo.data-lake.pdpj.jus.br/processo-api"),
    disposeHttpClient: false);
```

| Variable | Purpose | Default |
|---|---|---|
| `CODEX_CNJ_ACCESS_TOKEN` | Complete value sent in the `Authorization` header | Required by `CreateFromEnvironment()` |
| `CODEX_CNJ_BASE_URL` | Codex CNJ Process API base URL | `https://api-processo.data-lake.pdpj.jus.br/processo-api` |

Never commit access tokens. Use environment variables, .NET user secrets, or a secret manager.

## API clients

The root `CodexCnjClient` exposes clients matching the Swagger tags:

- `Auditoria`
- `CompetenciasCodex`
- `Indicadores`
- `MetricasDatalake`
- `Mtd`
- `Precedentes`
- `ProcessosDatalake`
- `ProcessosDatalakeInterno`
- `ProcessosDatalakeRefinado`
- `Saneamento`
- `SituacaoFaseProcessual`

Every operation has an async typed method. `AsResponseAsync` variants expose HTTP status and headers, while stream variants are generated where supported by the response media type.

## Regenerate

```bash
cd src/libs/CodexCnj
./generate.sh
```

The script copies `codex-cnj-swagger.json`, validates its host, base path, and authentication contract, normalizes Springfox operation IDs, and replaces `Generated/`. If the pinned AutoSDK version is not globally available, it is installed into the ignored local `.tools/` directory.

## Build and test

```bash
dotnet restore Loud.Technology.Codex.Cnj.Sdk.slnx
dotnet build Loud.Technology.Codex.Cnj.Sdk.slnx --configuration Release --no-restore
dotnet test Loud.Technology.Codex.Cnj.Sdk.slnx --configuration Release --no-build
```

The tests are network-free and verify the default URL, `Authorization` header, route/query serialization, typed responses, and model JSON serialization.

## License

Licensed under the [MIT License](LICENSE).
