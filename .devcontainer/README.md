# BarberDemo in GitHub Codespaces

This dev container is configured to run the BarberDemo .NET 8 application in GitHub Codespaces.

## Quick Start

1. **Open in Codespaces**: Click the "Code" button on GitHub → "Codespaces" → "Create codespace"
2. **Wait for setup**: The container will automatically install .NET 8 and restore packages
3. **Run the app**: In the terminal, run `dotnet run`
4. **Access Swagger**: Open the forwarded port 5000 in your browser

## What's Included

- ✅ .NET 8 SDK and runtime
- ✅ C# Dev Kit and extensions
- ✅ Automatic port forwarding (5000, 5001)
- ✅ Pre-configured VS Code settings
- ✅ All project dependencies restored

## Demo Flow

1. Start the application: `dotnet run`
2. Open Swagger UI (automatically opens in browser)
3. Test the endpoints:
   - POST `/api/hours` - Add working hours
   - POST `/api/appointments` - Book appointments
4. Watch console for email notifications
5. Background reminder service runs automatically

## Environment

- **HTTP URL**: http://localhost:5000/swagger
- **HTTPS URL**: https://localhost:5001/swagger
- **Email Mode**: Console (logs appear in terminal)
- **Database**: In-memory (resets on restart)

Perfect for live demos - no local setup required!