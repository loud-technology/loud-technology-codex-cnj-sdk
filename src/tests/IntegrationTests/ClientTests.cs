using System.Net;
using System.Text;

namespace Loud.Technology.Codex.Cnj.Sdk.IntegrationTests;

[TestClass]
public sealed class ClientTests
{
    [TestMethod]
    public void Constructor_ConfiguresDefaultBaseUrlAndAuthorizationHeader()
    {
        using var client = new CodexCnjClient("Bearer test-token");

        client.BaseUri.Should().Be(new Uri("https://api-processo.data-lake.pdpj.jus.br/processo-api"));
        var authorization = client.Authorizations.Should().ContainSingle().Which;
        authorization.Type.Should().Be("ApiKey");
        authorization.Location.Should().Be("Header");
        authorization.Name.Should().Be("Authorization");
        authorization.Value.Should().Be("Bearer test-token");
    }

    [TestMethod]
    public async Task ProcessoExiste_SendsAuthorizationAndTypedQueryParameters()
    {
        using var handler = new RecordingHandler(JsonResponse("true"));
        using var httpClient = new HttpClient(handler);
        using var client = CreateClient(httpClient);

        var exists = await client.ProcessosDatalake.ProcessoExisteAsync(
            numeroProcesso: "00012345620238260000",
            cpfCnpj: "12345678901",
            jtr: "826");

        exists.Should().BeTrue();
        handler.Method.Should().Be(HttpMethod.Get);
        handler.RequestUri.Should().Be(new Uri("https://codex.example/processo-api/api/v1/processos/00012345620238260000/existe?cpfCnpj=12345678901&jtr=826"));
        handler.Authorization.Should().Be("Bearer test-token");
    }

    [TestMethod]
    public async Task RecuperarProcesso_DeserializesTypedResponse()
    {
        const string responseJson =
            """
            [
              {
                "id": "process-id",
                "numeroProcesso": "00012345620238260000",
                "siglaTribunal": "TJSP",
                "nivelSigilo": 0
              }
            ]
            """;
        using var handler = new RecordingHandler(JsonResponse(responseJson));
        using var httpClient = new HttpClient(handler);
        using var client = CreateClient(httpClient);

        var processes = await client.ProcessosDatalake
            .RecuperarProcessoPorNumeroProcessoAsync("00012345620238260000");

        var process = processes.Should().ContainSingle().Which;
        process.Id.Should().Be("process-id");
        process.NumeroProcesso.Should().Be("00012345620238260000");
        process.SiglaTribunal.Should().Be("TJSP");
        process.NivelSigilo.Should().Be(0);
    }

    [TestMethod]
    public void ProcessoS3_RoundTripsUsingGeneratedJsonContext()
    {
        var process = new ProcessoS3
        {
            Id = "process-id",
            NumeroProcesso = "00012345620238260000",
            SiglaTribunal = "TJSP",
        };

        var roundTrip = ProcessoS3.FromJson(process.ToJson());

        roundTrip.Should().NotBeNull();
        roundTrip!.Id.Should().Be(process.Id);
        roundTrip.NumeroProcesso.Should().Be(process.NumeroProcesso);
        roundTrip.SiglaTribunal.Should().Be(process.SiglaTribunal);
    }

    private static CodexCnjClient CreateClient(HttpClient httpClient) =>
        new(
            apiKey: "Bearer test-token",
            httpClient: httpClient,
            baseUri: new Uri("https://codex.example/processo-api"),
            disposeHttpClient: false);

    private static HttpResponseMessage JsonResponse(string json) =>
        new(HttpStatusCode.OK)
        {
            Content = new StringContent(json, Encoding.UTF8, "application/json"),
        };

    private sealed class RecordingHandler(HttpResponseMessage response) : HttpMessageHandler
    {
        public HttpMethod? Method { get; private set; }
        public Uri? RequestUri { get; private set; }
        public string? Authorization { get; private set; }

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Method = request.Method;
            RequestUri = request.RequestUri;
            Authorization = request.Headers.TryGetValues("Authorization", out var values)
                ? values.Single()
                : null;
            response.RequestMessage = request;
            return Task.FromResult(response);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                response.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
