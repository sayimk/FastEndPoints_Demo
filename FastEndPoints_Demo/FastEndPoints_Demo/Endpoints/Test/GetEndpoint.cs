using FastEndpoints;

public class GetEndpoint : EndpointWithoutRequest
{
    public override void Configure()
    {
        Get("/api/test/get");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("GET Request handled");
        await SendOkAsync(cancellationToken).ConfigureAwait(false);
    }
}