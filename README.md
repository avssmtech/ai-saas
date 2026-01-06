# ai-saas (SvelteKit + .NET 8) — multi-agent SaaS skeleton

This repo is a **solo-friendly** starting point for a monetizable multi-agent web product.

Agents planned:
- AI Compliance & Policy Copilot
- AI Vendor Contract Risk Analyzer
- AI Expense & Invoice Fraud Detector

## Repo structure
- `web/` — SvelteKit UI (feature modules per agent)
- `backend/` — .NET 8 backend (Clean Architecture + DDD boundaries)
- `infra/` — optional IaC (Bicep/Terraform) later
- `docs/` — architecture diagrams + ADRs

## Local dev (suggested)
### Backend
```bash
cd backend
# Build a single API to start
# (You can later split into separate services)
dotnet build src/Platform.Api/Platform.Api.csproj

dotnet run --project src/Platform.Api/Platform.Api.csproj
```

### Web
```bash
cd web
npm install
npm run dev
```

## Architecture notes
- Start as a **modular monolith** with clear bounded contexts under `backend/src/Agents/*`.
- Add a dedicated **Orchestrator** module/service once agent count grows.
- Keep cross-context sharing limited to `backend/src/BuildingBlocks/Contracts`.
