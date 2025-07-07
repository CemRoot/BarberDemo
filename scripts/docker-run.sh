#!/bin/bash

# Docker Run Script for BarberDemo
# This script builds and runs the application using Docker

echo "🐳 Building and Running BarberDemo with Docker"
echo "==============================================="

# Check if Docker is installed
if ! command -v docker &> /dev/null; then
    echo "❌ Docker not found. Please install Docker first."
    exit 1
fi

# Check if Docker Compose is available
if command -v docker-compose &> /dev/null; then
    echo "🔧 Using Docker Compose..."
    docker-compose down
    docker-compose up --build
elif docker compose version &> /dev/null; then
    echo "🔧 Using Docker Compose (new syntax)..."
    docker compose down
    docker compose up --build
else
    echo "🔧 Using Docker directly..."
    
    # Build the Docker image
    echo "🔨 Building Docker image..."
    docker build -t barberdemo .
    
    if [ $? -eq 0 ]; then
        echo "✅ Docker image built successfully."
    else
        echo "❌ Failed to build Docker image."
        exit 1
    fi
    
    # Run the container
    echo "🚀 Running container..."
    docker run -p 8080:8080 --name barberdemo-container barberdemo
fi

echo ""
echo "🎉 Application is running!"
echo "Open your browser to: http://localhost:8080"
