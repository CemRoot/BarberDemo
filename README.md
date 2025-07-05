# BarberDemo – Minimal .NET 8 API (working hours, bookings, e-mail reminders)

## 🚀 Run in GitHub Codespaces (Recommended for Demos)

**Zero setup required!** Perfect for live presentations:

1. Click **Code** → **Codespaces** → **Create codespace**
2. Wait for automatic setup (2-3 minutes)
3. Run: `dotnet run`
4. Access Swagger UI at the forwarded port

**✅ No .NET installation needed • ✅ Cloud-based • ✅ Perfect for demos**

---

## 💻 Local Development

```bash
dotnet restore
dotnet run
# Swagger UI → http://localhost:5000/swagger
```

## 📝 API Endpoints

| Verb | Path | Body example (JSON) | Purpose |
|------|------|---------------------|---------|
| POST | `/api/hours` | `{ "day":"Monday","start":"10:00:00","end":"18:00:00" }` | Add working hours |
| POST | `/api/appointments` | `{ "customer":"John","email":"john@x.com","date":"2025-07-09T14:00:00Z" }` | Book an appointment |

## 📧 Email Configuration

- **Console mode** (default) — emails appear as log lines in terminal
- **SMTP mode** — set `Mail:Mode=smtp` and provide `SMTP_USER`, `SMTP_PASS` environment variables

## ⏰ Background Reminder Service

A background service runs every minute and sends reminder emails 24 hours before appointments.

## 🎯 Demo Features

- ✅ **Working hours management** with overlap validation
- ✅ **Appointment booking** with clash detection  
- ✅ **Immediate email notifications** (barber + customer)
- ✅ **24-hour reminder system** (background service)
- ✅ **In-memory database** (zero external dependencies)
- ✅ **Swagger UI** as demo frontend
- ✅ **Pre-seeded data** (Monday-Tuesday, 10 AM - 6 PM)

---

Built for live demos – **zero external infrastructure required**!