#!/bin/bash

# Development Setup Script for BarberDemo
# This script sets up the development environment

echo "🔧 BarberDemo Development Setup"
echo "==============================="

# Check if .NET 8.0 is installed
if ! command -v dotnet &> /dev/null; then
    echo "❌ .NET 8.0 SDK not found. Please install .NET 8.0 SDK first."
    exit 1
fi

# Check .NET version
DOTNET_VERSION=$(dotnet --version)
echo "✅ .NET Version: $DOTNET_VERSION"

# Create .env file if it doesn't exist
if [ ! -f .env ]; then
    echo "📝 Creating .env file from .env.example..."
    cp .env.example .env
    echo "✅ .env file created. Please edit it with your settings."
else
    echo "✅ .env file already exists."
fi

# Restore NuGet packages
echo "📦 Restoring NuGet packages..."
dotnet restore

if [ $? -eq 0 ]; then
    echo "✅ NuGet packages restored successfully."
else
    echo "❌ Failed to restore NuGet packages."
    exit 1
fi

# Build the project
echo "🔨 Building project..."
dotnet build

if [ $? -eq 0 ]; then
    echo "✅ Project built successfully."
else
    echo "❌ Failed to build project."
    exit 1
fi

echo ""
echo "🎉 Setup completed successfully!"
echo ""
echo "To run the application:"
echo "  dotnet run"
echo ""
echo "To run with Docker:"
echo "  docker-compose up"
echo ""
echo "Open your browser to: http://localhost:5000"
