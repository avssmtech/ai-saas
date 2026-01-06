namespace AiSaas.Contracts;

public sealed record AgentRequest(
    string AgentKey,
    string Input,
    string? ConversationId = null,
    Dictionary<string, string>? Metadata = null);
