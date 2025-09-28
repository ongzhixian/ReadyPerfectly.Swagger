#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace ReadyPerfectly.Swagger;
#pragma warning restore IDE0130 // Namespace does not match folder structure

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
public class ApiDefinitionAttribute : Attribute
{
    public string DocumentId { get; init; } = null!;

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Version { get; set; } = null!;

    // Note: Omitting TermsOfService, Contact and License because:
    // CS0181 Attribute constructor parameter 'termsOfService' has type 'Uri', which is not a valid attribute parameter type
    // CS0181 Attribute constructor parameter 'contact' has type 'OpenApiContact', which is not a valid attribute parameter type
    // CS0181 Attribute constructor parameter 'license' has type 'OpenApiLicense', which is not a valid attribute parameter type
    // Which is probably fine because thse should probably stay the same.
    
    public ApiDefinitionAttribute(string? documentId = null, string title = "Api Definition", string description = "Api definition", string version = "v1")
    {
        DocumentId = documentId ?? Guid.NewGuid().ToString();
        Title = title;
        Description = description;
        Version = version;
    }
}
