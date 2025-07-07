# Contributing to BarberDemo

Thank you for your interest in contributing to BarberDemo! This document provides guidelines for contributing to the project.

## 🌟 Code of Conduct

This project adheres to a code of conduct. By participating, you are expected to uphold this code. Please report unacceptable behavior to the project maintainers.

## 🚀 Getting Started

### Prerequisites
- .NET 8.0 SDK
- Git
- Docker (optional)

### Setting Up Development Environment

1. **Fork the repository**
   ```bash
   git clone https://github.com/yourusername/BarberDemo.git
   cd BarberDemo
   ```

2. **Setup development environment**
   ```bash
   make setup
   # or
   ./scripts/dev-setup.sh
   ```

3. **Run the application**
   ```bash
   make run
   # or
   dotnet run
   ```

## 📝 How to Contribute

### Reporting Bugs

1. Check if the bug has already been reported in [Issues](https://github.com/CemRoot/BarberDemo/issues)
2. If not, create a new issue with:
   - Clear description of the bug
   - Steps to reproduce
   - Expected vs actual behavior
   - Environment details (OS, .NET version, etc.)

### Suggesting Features

1. Check if the feature has already been requested
2. Create a new issue with:
   - Clear description of the feature
   - Use cases and benefits
   - Possible implementation approach

### Submitting Changes

1. **Create a feature branch**
   ```bash
   git checkout -b feature/your-feature-name
   ```

2. **Make your changes**
   - Follow the coding standards
   - Add tests if applicable
   - Update documentation

3. **Test your changes**
   ```bash
   make test
   make build
   ```

4. **Commit your changes**
   ```bash
   git add .
   git commit -m "feat: add your feature description"
   ```

5. **Push to your fork**
   ```bash
   git push origin feature/your-feature-name
   ```

6. **Create a Pull Request**
   - Provide a clear title and description
   - Reference related issues
   - Ensure all checks pass

## 📋 Coding Standards

### C# Guidelines
- Follow [Microsoft C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- Use meaningful variable and method names
- Add XML documentation for public APIs
- Follow async/await patterns for asynchronous operations

### Project Structure
```
src/
├── Controllers/     # API Controllers
├── Data/           # Database context
├── Models/         # Data models
├── Services/       # Business logic
├── Extensions/     # Extension methods
├── Middleware/     # Custom middleware
└── Configuration/  # Configuration files
```

### Commit Messages
Use conventional commits format:
- `feat:` for new features
- `fix:` for bug fixes
- `docs:` for documentation
- `style:` for formatting
- `refactor:` for code refactoring
- `test:` for tests
- `chore:` for maintenance

## 🧪 Testing

### Running Tests
```bash
make test
# or
dotnet test
```

### Writing Tests
- Place tests in the `tests/` directory
- Use descriptive test names
- Follow AAA pattern (Arrange, Act, Assert)
- Mock external dependencies

## 📖 Documentation

### Code Documentation
- Add XML documentation for public APIs
- Include examples in complex methods
- Document any non-obvious behavior

### README Updates
- Update README.md for new features
- Include screenshots for UI changes
- Update setup instructions if needed

## 🔄 Review Process

### Pull Request Review
1. All checks must pass
2. Code review by maintainers
3. Documentation review
4. Final approval and merge

### Review Criteria
- Code quality and readability
- Test coverage
- Documentation completeness
- Performance considerations
- Security best practices

## 📚 Resources

### Documentation
- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [Docker Documentation](https://docs.docker.com/)

### Tools
- [Visual Studio Code](https://code.visualstudio.com/)
- [Visual Studio](https://visualstudio.microsoft.com/)
- [JetBrains Rider](https://www.jetbrains.com/rider/)

## 🤝 Community

### Getting Help
- [GitHub Issues](https://github.com/CemRoot/BarberDemo/issues) for bugs and features
- [GitHub Discussions](https://github.com/CemRoot/BarberDemo/discussions) for questions

### Staying Updated
- Watch the repository for updates
- Follow the project on GitHub
- Join project discussions

## 🏆 Recognition

Contributors will be recognized in:
- README.md contributors section
- Release notes
- GitHub contributors page

Thank you for contributing to BarberDemo! 🎉
