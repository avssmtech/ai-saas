namespace AiSaas.Contracts;

public sealed record AgentResponse(
    string AgentKey,
    string Output,
    string ConversationId,
    List<Citation>? Citations = null);

public sealed record Citation(string Source, string Snippet);
