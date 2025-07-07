# Tests

Bu klasör proje testleri için kullanılacaktır.

## Planlanan Test Yapısı

```
tests/
├── Unit/
│   ├── Services/
│   │   ├── EmailServiceTests.cs
│   │   └── ReminderServiceTests.cs
│   └── Models/
│       └── AppointmentTests.cs
├── Integration/
│   ├── ApiTests.cs
│   └── DatabaseTests.cs
└── TestHelpers/
    └── TestData.cs
```

## Test Çalıştırma

```bash
# Testleri çalıştır
dotnet test

# Makefile ile
make test
```
