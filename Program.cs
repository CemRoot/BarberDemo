using BarberDemo.Extensions;

var builder = WebApplication.CreateBuilder(args);

// ── Services Configuration ───────────────────────────────────────────
builder.Services.ConfigureApplicationServices();

var app = builder.Build();

// ── Middleware Configuration ──────────────────────────────────────────
app.ConfigureApplicationMiddleware();

// ── Seed Demo Data ─────────────────────────────────────────────────────
await app.SeedDataAsync();

// ── API Endpoints ──────────────────────────────────────────────────────
app.MapApiEndpoints();

app.Run();