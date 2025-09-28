#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace ReadyPerfectly.Swagger;
#pragma warning restore IDE0130 // Namespace does not match folder structure

public class SwaggerUiConfiguration
{
    public string DocumentTitle { get; set; } = string.Empty;

    public string RoutePrefix { get; set; } = "/swagger/index.html";
}
