# Makefile for BarberDemo
# Common commands for development and deployment

.PHONY: help setup build run test clean docker-build docker-run deploy-local deploy-production

# Default target
help:
	@echo "BarberDemo - Available Commands:"
	@echo "================================"
	@echo "  help              - Show this help message"
	@echo "  setup             - Setup development environment"
	@echo "  build             - Build the application"
	@echo "  run               - Run the application"
	@echo "  test              - Run tests (when available)"
	@echo "  clean             - Clean build artifacts"
	@echo "  docker-build      - Build Docker image"
	@echo "  docker-run        - Run with Docker"
	@echo "  deploy-local      - Deploy locally"
	@echo "  deploy-production - Deploy to production"

# Setup development environment
setup:
	@echo "🔧 Setting up development environment..."
	@chmod +x scripts/*.sh
	@./scripts/dev-setup.sh

# Build the application
build:
	@echo "🔨 Building application..."
	@dotnet build

# Run the application
run:
	@echo "🚀 Running application..."
	@dotnet run

# Run tests (placeholder for future tests)
test:
	@echo "🧪 Running tests..."
	@dotnet test

# Clean build artifacts
clean:
	@echo "🧹 Cleaning build artifacts..."
	@dotnet clean
	@rm -rf bin obj publish

# Build Docker image
docker-build:
	@echo "🐳 Building Docker image..."
	@docker build -t barberdemo .

# Run with Docker
docker-run:
	@echo "🐳 Running with Docker..."
	@./scripts/docker-run.sh

# Deploy locally
deploy-local:
	@echo "🚀 Deploying locally..."
	@./scripts/local-deploy.sh

# Deploy to production
deploy-production:
	@echo "🚀 Deploying to production..."
	@./scripts/deploy-production.sh

# Install development dependencies
install:
	@echo "📦 Installing dependencies..."
	@dotnet restore

# Format code (if formatting tools are available)
format:
	@echo "🎨 Formatting code..."
	@dotnet format

# Check for updates
update:
	@echo "📋 Checking for updates..."
	@dotnet list package --outdated
