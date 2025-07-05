#!/bin/bash

echo "🚀 Starting BarberDemo..."
echo "📍 Swagger UI will be available at the forwarded port"
echo "📧 Email notifications will appear in this terminal"
echo "⏰ Reminder service runs every minute in background"
echo ""
echo "🎯 Demo endpoints ready:"
echo "   POST /api/hours - Add working hours"
echo "   POST /api/appointments - Book appointments"
echo ""
echo "Press Ctrl+C to stop the demo"
echo "----------------------------------------"

dotnet run