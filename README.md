# Hi, I'm Kanishka 👋

Full-stack software engineer based in Melbourne, Australia. I work across **Angular, .NET, and microservices** — most recently building **AI / RAG systems** on Azure.

I spent 4+ years at **Agilent Technologies** as a full-stack engineer, owning compliance-sensitive backend components and contributing to a micro-frontend platform. Outside of work, I build things to learn things — usually distributed systems, sometimes blockchains, lately a lot of AI engineering.

🔭 **Currently open to new roles** — distributed systems, platform engineering, or AI-augmented application work in Melbourne. [Get in touch.](mailto:kapoor.kanishka@gmail.com)

---

## 🚀 Featured Projects

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

### [Distributed Order Management Platform](https://github.com/kkap15/DistributedOrderManagementPlatform)
A four-service distributed system — API Gateway, OrderService, PaymentService, UserService — with Polly resilience and end-to-end Auth0 JWT propagation.

`Angular 21` · `.NET 10` · `Auth0` · `Polly v8` · `EF Core` · `SQLite` · `Docker Compose`

**Highlights:**
- One-command startup via Docker Compose with persistent SQLite volumes
- Polly v8 `ResiliencePipelineBuilder` — retry + circuit breaker on cross-service calls
- Gateway forwards raw Bearer tokens; auto user-registration on first login from JWT claims

---

## 🛠️ Tech I Work With

**Languages:** TypeScript · C# · SQL
**Frameworks:** .NET 10 · ASP.NET Core · Angular · React
**AI / RAG:** Azure OpenAI · pgvector · embedding pipelines · LLM-as-judge eval
**Cloud:** Azure (Container Apps, Container Registry) · AWS (EC2, S3) · Vercel
**DevOps:** GitHub Actions · Docker · Docker Compose · Kubernetes
**Testing:** Reqnroll (BDD) · Playwright · xUnit · FluentAssertions
**Auth:** Auth0 · JWT · PKCE flow
**Architecture:** Microservices · Micro-Frontends (Module Federation, Native Federation) · SOLID · Distributed Systems

---

## 📫 Get in touch

- ✉️ [kapoor.kanishka@gmail.com](mailto:kapoor.kanishka@gmail.com)
- 💼 [LinkedIn](https://linkedin.com/in/kanishkakapoor15)
- 🌏 Melbourne, Australia

---

<sub>*Currently exploring roles where I can keep building distributed systems and AI-augmented applications. If your team is hiring and any of the above resonates — I'd love to hear from you.*</sub>
