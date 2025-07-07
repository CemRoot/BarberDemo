#!/bin/bash

# Production Deployment Script for BarberDemo
# This script deploys the application to production

echo "🚀 BarberDemo Production Deployment"
echo "===================================="

# Check if environment variables are set
if [ -z "$SMTP_HOST" ] || [ -z "$SMTP_USER" ] || [ -z "$SMTP_PASS" ]; then
    echo "⚠️  Warning: Email environment variables are not set."
    echo "   Set SMTP_HOST, SMTP_USER, SMTP_PASS for email functionality."
fi

# Check if .NET 8.0 is installed
if ! command -v dotnet &> /dev/null; then
    echo "❌ .NET 8.0 SDK not found. Please install .NET 8.0 SDK first."
    exit 1
fi

# Clean previous builds
echo "🧹 Cleaning previous builds..."
dotnet clean

# Restore packages
echo "📦 Restoring packages..."
dotnet restore

# Build for production
echo "🔨 Building for production..."
dotnet build -c Release

if [ $? -eq 0 ]; then
    echo "✅ Build completed successfully."
else
    echo "❌ Build failed."
    exit 1
fi

# Publish the application
echo "📦 Publishing application..."
dotnet publish -c Release -o ./publish

if [ $? -eq 0 ]; then
    echo "✅ Application published successfully."
else
    echo "❌ Publish failed."
    exit 1
fi

echo ""
echo "🎉 Production deployment completed!"
echo ""
echo "Published files are in: ./publish"
echo ""
echo "To run the published application:"
echo "  cd publish"
echo "  dotnet BarberDemo.dll"
