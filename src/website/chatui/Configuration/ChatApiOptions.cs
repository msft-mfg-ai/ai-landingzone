using System.ComponentModel.DataAnnotations;

namespace chatui.Configuration;

public class ChatApiOptions
{
    [Url]
    public string AIProjectEndpoint { get; init; } = default!;

    [Required]
    public string AIAgentId { get; init; } = default!;

    public string? VisualStudioTenantId { get; init; }
}