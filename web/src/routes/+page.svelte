<script lang="ts">
  const agents = [
    { key: 'compliance', name: 'AI Compliance & Policy Copilot' },
    { key: 'contract-risk', name: 'AI Vendor Contract Risk Analyzer' },
    { key: 'fraud', name: 'AI Expense & Invoice Fraud Detector' }
  ];
</script>

<h1>ai-saas</h1>
<p>Multi-agent SaaS skeleton (SvelteKit + .NET).</p>

<h2>Agents</h2>
<ul>
  {#each agents as a}
    <li><strong>{a.name}</strong> — <code>{a.key}</code></li>
  {/each}
</ul>
