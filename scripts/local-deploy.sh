#!/bin/bash

# Local Docker deployment script
# Bu script uygulamayı local Docker'da çalıştırmak için kullanılır

echo "🐳 Starting local Docker deployment..."

# Stop and remove existing containers
echo "🛑 Stopping existing containers..."
docker-compose down

# Build and start containers
echo "🏗️ Building and starting containers..."
docker-compose up --build -d

echo "✅ Local deployment completed!"
echo "🌐 Application is running at: http://localhost:8080"
echo "📚 API documentation: http://localhost:8080/swagger"

# Show logs
echo "📋 Container logs:"
docker-compose logs -f
