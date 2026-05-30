# Hi, I'm Kanishka 👋

Full-stack software engineer based in Melbourne, Australia. I work across **Angular, .NET, and microservices** — most recently building **AI / RAG systems** and **agentic applications** on Azure.

I spent 4+ years at **Agilent Technologies** as a full-stack engineer, owning compliance-sensitive backend components and contributing to a micro-frontend platform. Outside of work, I build things to learn things — usually distributed systems, sometimes blockchains, lately a lot of AI engineering.

🔭 **Currently open to new roles** — distributed systems, platform engineering, or AI-augmented application work in Melbourne. [Get in touch.](mailto:kapoor.kanishka@gmail.com)

---

## 🚀 Featured Projects

### [FinanceAI](https://github.com/kkap15/financeai) — AI-Powered Personal Finance SaaS
A production SaaS with dual bank provider support (Australian banks via Basiq CDR, international via Plaid), an agentic finance assistant, Stripe subscription billing, and full Azure + Vercel deployment.

**→ Try it live:** [financeai.moviegasm.xyz](https://financeai.moviegasm.xyz)

`Next.js 14` · `.NET 10` · `Semantic Kernel` · `Azure OpenAI` · `Plaid` · `Basiq` · `Stripe` · `PostgreSQL + pgvector` · `Auth0` · `Azure Container Apps` · `Vercel`

**Highlights:**
- Agentic finance assistant using Semantic Kernel AutoInvoke with 6 custom tools (spending summaries, budget management, transaction search, month comparisons) — streaming token-by-token via SSE
- Dual bank provider architecture: Australian banks via Basiq CDR, international banks via Plaid — unified behind `IBankService` interface with `BankServiceBase` abstract class and `BankServiceFactory`
- Semantic transaction search using Azure OpenAI `text-embedding-3-small` stored in pgvector HNSW index
- Stripe subscription billing with Checkout, Customer Portal, and webhook lifecycle handling — Free/Pro feature gating enforced at API layer via `[RequiresPro]` action filter
- Production observability with OpenTelemetry distributed tracing, Serilog structured logging, and Azure Application Insights
- PWA support with offline capability and Add to Home Screen on iOS/Android

---

### [AskDotNet](https://github.com/kkap15/AskDotNet) — Production RAG Assistant for .NET Docs
A live RAG chatbot grounded on Microsoft Learn C# documentation. Ask it a question in natural language and it streams back a grounded answer with citations.

**→ Try it live:** [askdotnet.vercel.app](https://askdotnet.vercel.app)

`.NET 10` · `React 19` · `Azure OpenAI` · `PostgreSQL + pgvector` · `Auth0` · `Azure Container Apps`

**Highlights:**
- Structure-aware chunking via Markdig AST walker at H2/H3 heading boundaries
- pgvector HNSW cosine-similarity retrieval, queried via raw Npgsql
- `IAsyncEnumerable<string>` token streaming end-to-end → SSE → React `ReadableStream`
- LLM-as-judge evaluation suite scoring retrieval recall and answer quality

---

### [Distributed Order Management Platform](https://github.com/kkap15/DistributedOrderManagementPlatform) — Event-Driven Microservices
A five-service event-driven system with async decoupling via Kafka, the transactional outbox pattern, and real-time SignalR notifications.

`Angular 21` · `.NET 10` · `Apache Kafka (KRaft)` · `Confluent.Kafka` · `SignalR` · `Polly v8` · `EF Core` · `SQLite` · `Docker Compose` · `GitHub Actions`

**Highlights:**
- Transactional outbox pattern in OrderService — order and OutboxMessage written atomically, background OutboxProcessor publishes to Kafka guaranteeing at-least-once delivery
- `KafkaConsumerBase<TEvent>` abstract generic base — scope-per-message pattern via `IServiceScopeFactory` for clean EF Core DbContext lifecycle
- `IEventPublisher` / `IEventConsumer` abstractions in shared Contracts project — swappable to any message broker without changing service code
- NotificationService consumes `payment.processed` and pushes real-time updates to Angular via SignalR
- Exactly-once producer semantics via `Acks.All` + `EnableIdempotence = true`
- CI/CD via GitHub Actions — builds and publishes all service images to GHCR on merge to main

---

### [MiniChain](https://github.com/kkap15/Blockchain-csharp) — Blockchain from Scratch in C#
A minimal blockchain built from first principles. Block hashing, Proof-of-Work mining, ECDSA-signed transactions, a mempool, P2P networking, and longest-chain consensus — all in C#.

`C# / .NET 10` · `Blazor Server` · `EF Core` · `SQLite` · `Auth0` · `Docker`

**Highlights:**
- Deterministic canonical serialization (`CultureInfo.InvariantCulture`) for cross-machine hash consistency
- Merkle tree committed into block hashes — any tampering breaks chain validity
- 90%+ test coverage across Block, Blockchain, Miner, Wallet, Mempool, and Node components
- Interface-driven core with dependency injection (test miners run at zero difficulty)

---

### [MFE Platform](https://github.com/kkap15/MFEPlatform) — Dynamic Micro-Frontend Host
An Angular 21 shell that loads registered remote apps at runtime via Native Federation — no host redeploy required to onboard a new MFE.

`Angular 21` · `.NET 10` · `Native Federation` · `Auth0` · `EF Core` · `SQLite`

**Highlights:**
- .NET 10 Web API registry with full CRUD + conflict detection (HTTP 409)
- Dynamic route generation via `loadRemoteModule()` + `router.resetConfig()`
- Auth0 PKCE flow end-to-end with an `AuthHttpInterceptor` for outbound API calls

---

## 🛠️ Tech I Work With

**Languages:** TypeScript · C# · JavaScript · Java · C · C++  
**Frameworks:** .NET 10 · ASP.NET Core · Angular · React · Next.js 14  
**AI / Agentic:** Azure OpenAI · Semantic Kernel · RAG pipelines · pgvector · function calling · AutoInvoke · LLM-as-judge eval  
**Messaging:** Apache Kafka (KRaft) · Confluent.Kafka · transactional outbox pattern  
**Integrations:** Stripe · Plaid · Basiq (Australian CDR)  
**Cloud:** Azure (Container Apps, Container Registry, PostgreSQL) · AWS (EC2, S3) · Vercel  
**DevOps:** GitHub Actions · Docker · Docker Compose · Kubernetes · OpenTelemetry · Serilog  
**Testing:** Reqnroll (BDD) · Playwright · xUnit · FluentAssertions  
**Auth:** Auth0 · JWT · PKCE flow  
**Architecture:** Microservices · Event-Driven · Micro-Frontends · Modular Monolith · SOLID · Distributed Systems · Outbox Pattern  

---

## 📫 Get in touch

- ✉️ [kapoor.kanishka@gmail.com](mailto:kapoor.kanishka@gmail.com)
- 💼 [LinkedIn](https://linkedin.com/in/kanishkakapoor15)
- 🌏 Melbourne, Australia

---

<sub>*Currently exploring roles where I can keep building distributed systems and AI-augmented applications. If your team is hiring and any of the above resonates — I'd love to hear from you.*</sub>
