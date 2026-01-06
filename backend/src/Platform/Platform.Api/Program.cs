using AiSaas.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/health", () => Results.Ok(new { status = "ok" }));

// Temporary single-entry endpoint to route agent calls.
// Later: move this to API Gateway/BFF or dedicated Orchestrator service.
app.MapPost("/api/agents/run", (AgentRequest req) =>
{
    var conversationId = req.ConversationId ?? Guid.NewGuid().ToString("N");
    return Results.Ok(new AgentResponse(req.AgentKey, $"Stub response for '{req.AgentKey}': {req.Input}", conversationId));
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
