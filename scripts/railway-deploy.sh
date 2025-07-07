#!/bin/bash

# Deployment script for Railway
# Bu script Railway'da deployment yapmak için kullanılır

echo "🚀 Starting Railway deployment..."

# Build and push to Railway
echo "📦 Building application..."
dotnet restore
dotnet build -c Release

echo "🌐 Deploying to Railway..."
railway up

echo "✅ Deployment completed!"
echo "🔗 Check your Railway dashboard for the live URL"
