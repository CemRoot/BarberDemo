# 🤝 Katkıda Bulunma Rehberi

Elite Barber projesine katkıda bulunmak istediğiniz için teşekkür ederiz! Bu doküman size katkı süreciyle ilgili tüm detayları verecektir.

## 📋 İçindekiler

- [Davranış Kuralları](#davranış-kuralları)
- [Nasıl Katkıda Bulunabilirim?](#nasıl-katkıda-bulunabilirim)
- [Geliştirme Ortamını Kurma](#geliştirme-ortamını-kurma)
- [Kodlama Standartları](#kodlama-standartları)
- [Commit Mesaj Formatı](#commit-mesaj-formatı)
- [Pull Request Süreci](#pull-request-süreci)
- [Issue Raporlama](#issue-raporlama)
- [Feature Request](#feature-request)
- [İletişim](#iletişim)

---

## 📜 Davranış Kuralları

Bu proje [Contributor Covenant](CODE_OF_CONDUCT.md) davranış kurallarını benimsemiştir. Projeye katkıda bulunarak bu kurallara uymayı kabul etmiş olursunuz.

Kısacası:
- ✅ Saygılı ve kapsayıcı olun
- ✅ Yapıcı eleştiri yapın ve kabul edin
- ✅ Topluluk çıkarlarını önemseyin
- ❌ Taciz veya ayrımcılık yapmayın
- ❌ Spam veya gereksiz içerik paylaşmayın

---

## 🚀 Nasıl Katkıda Bulunabilirim?

### 1. 🐛 Bug Buldum!

Harika! Bug bulduğunuzda:

1. Önce [mevcut issue'lara](https://github.com/CemRoot/BarberDemo/issues) bakın - belki zaten raporlanmıştır
2. Eğer yoksa, [yeni bir bug report](https://github.com/CemRoot/BarberDemo/issues/new?template=bug_report.md) oluşturun
3. Bug'ı detaylı bir şekilde tanımlayın:
   - Adımları nasıl tekrar edebiliriz?
   - Beklenen davranış neydi?
   - Gerçekte ne oldu?
   - Ekran görüntüleri (varsa)
   - Ortam bilgileri (.NET version, OS, browser vb.)

### 2. 💡 Yeni Özellik Öneriyorum!

Mükemmel! Önerinizi paylaşmak için:

1. [Mevcut feature request'leri](https://github.com/CemRoot/BarberDemo/issues?q=is%3Aissue+label%3Aenhancement) kontrol edin
2. [Yeni feature request](https://github.com/CemRoot/BarberDemo/issues/new?template=feature_request.md) açın
3. Özelliği detaylıca açıklayın:
   - Hangi problemi çözüyor?
   - Nasıl çalışmalı?
   - Alternatif çözümler düşündünüz mü?
   - Mockup veya çizimler (varsa)

### 3. 📝 Dokümantasyon İyileştirmesi

Dokümantasyonda hata veya eksik mi gördünüz?

1. Fork edin
2. Düzeltmeleri yapın
3. Pull Request gönderin
4. Değişikliklerinizi açıklayın

### 4. 🎨 Kod Katkısı

Kod yazmaya hazır mısınız? İşte adımlar:

1. Fork edin ve clone edin
2. Geliştirme ortamını kurun
3. Feature branch oluşturun
4. Kodunuzu yazın
5. Test edin
6. Commit ve Push
7. Pull Request açın

---

## 🛠️ Geliştirme Ortamını Kurma

### Gereksinimler

- .NET SDK 8.0+
- Git 2.0+
- Visual Studio Code veya Visual Studio 2022
- Docker (opsiyonel ama önerilir)

### Adım Adım Kurulum

```bash
# 1. Repo'yu fork edin ve clone edin
git clone https://github.com/YOUR-USERNAME/BarberDemo.git
cd BarberDemo

# 2. Upstream remote'u ekleyin
git remote add upstream https://github.com/CemRoot/BarberDemo.git

# 3. Bağımlılıkları yükleyin
dotnet restore

# 4. Uygulamayı çalıştırın
dotnet run

# 5. Tarayıcıda açın
# http://localhost:5000
```

### Environment Setup

`.env` dosyası oluşturun:

```bash
cp .env.example .env
# .env dosyasını gerektiği gibi düzenleyin
```

### Kod Editörü Uzantıları (VS Code)

Önerilen uzantılar:
- C# (Microsoft)
- C# Dev Kit (Microsoft)
- EditorConfig for VS Code
- GitLens
- Docker (Microsoft)
- REST Client

---

## 💻 Kodlama Standartları

### C# Kod Standartları

#### Naming Conventions

```csharp
// PascalCase - Classes, Methods, Properties
public class AppointmentService { }
public void CreateAppointment() { }
public string CustomerName { get; set; }

// camelCase - Local variables, parameters
var appointmentDate = DateTime.Now;
public void SendEmail(string emailAddress) { }

// _camelCase - Private fields
private readonly ILogger _logger;

// UPPER_CASE - Constants
public const int MAX_APPOINTMENTS = 100;
```

#### Code Formatting

```csharp
// ✅ GOOD
public class AppointmentService
{
    private readonly ILogger<AppointmentService> _logger;

    public AppointmentService(ILogger<AppointmentService> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<Appointment> CreateAppointmentAsync(
        string customer,
        DateTime date)
    {
        if (string.IsNullOrWhiteSpace(customer))
            throw new ArgumentException("Customer name is required", nameof(customer));

        _logger.LogInformation("Creating appointment for {Customer}", customer);

        // Implementation
        return new Appointment { Customer = customer, Date = date };
    }
}

// ❌ BAD
public class AppointmentService {
private ILogger _logger;
public AppointmentService(ILogger logger){_logger=logger;}
public async Task<Appointment> CreateAppointmentAsync(string customer,DateTime date){
if(customer==null) throw new Exception("error");
return new Appointment{Customer=customer,Date=date};}
}
```

#### XML Documentation

Public API'ler için XML dokümantasyonu ekleyin:

```csharp
/// <summary>
/// Creates a new appointment for a customer.
/// </summary>
/// <param name="customer">The customer's name.</param>
/// <param name="email">The customer's email address.</param>
/// <param name="date">The appointment date and time.</param>
/// <returns>The created appointment.</returns>
/// <exception cref="ArgumentException">
/// Thrown when customer name is null or empty.
/// </exception>
public async Task<Appointment> CreateAppointmentAsync(
    string customer,
    string email,
    DateTime date)
{
    // Implementation
}
```

### Frontend Kod Standartları

#### HTML

```html
<!-- ✅ GOOD -->
<div class="appointment-card" id="appointment-123">
    <h3 class="appointment-title">Saç Kesimi</h3>
    <p class="appointment-time">14:00 - 15:00</p>
</div>

<!-- ❌ BAD -->
<div class=appointment-card id=appointment-123>
<h3 class=appointment-title>Saç Kesimi</h3><p class=appointment-time>14:00 - 15:00</p></div>
```

#### CSS

```css
/* ✅ GOOD */
.appointment-card {
    background: white;
    border-radius: 8px;
    padding: 1rem;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
}

.appointment-card:hover {
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.15);
}

/* ❌ BAD */
.appointment-card{background:white;border-radius:8px;padding:1rem;box-shadow:0 2px 4px rgba(0,0,0,0.1)}
.appointment-card:hover{box-shadow:0 4px 8px rgba(0,0,0,0.15)}
```

#### JavaScript

```javascript
// ✅ GOOD
function createAppointment(customer, date) {
    if (!customer || !date) {
        throw new Error('Customer and date are required');
    }

    return {
        id: generateId(),
        customer: customer,
        date: date,
        status: 'pending'
    };
}

// ❌ BAD
function createAppointment(customer,date){
if(!customer||!date) throw new Error('error')
return {id:generateId(),customer:customer,date:date,status:'pending'}}
```

### EditorConfig

Projedeki `.editorconfig` dosyasına uyun:

```ini
[*.cs]
indent_style = space
indent_size = 4
end_of_line = lf
charset = utf-8
trim_trailing_whitespace = true
insert_final_newline = true

[*.{js,html,css}]
indent_size = 2
```

---

## 📝 Commit Mesaj Formatı

[Conventional Commits](https://www.conventionalcommits.org/) standardını kullanıyoruz.

### Format

```
<type>(<scope>): <subject>

<body>

<footer>
```

### Type

| Type | Açıklama | Örnek |
|------|----------|-------|
| `feat` | Yeni özellik | `feat(api): add appointment cancellation` |
| `fix` | Bug düzeltme | `fix(ui): resolve mobile menu bug` |
| `docs` | Dokümantasyon | `docs(readme): update installation guide` |
| `style` | Code formatting | `style(css): format according to prettier` |
| `refactor` | Code refactoring | `refactor(service): simplify email logic` |
| `test` | Test ekleme/düzenleme | `test(api): add appointment tests` |
| `chore` | Build/tool değişiklikleri | `chore(deps): update dependencies` |
| `perf` | Performance iyileştirme | `perf(db): optimize query performance` |
| `ci` | CI/CD değişiklikleri | `ci(github): add automated tests` |
| `revert` | Commit geri alma | `revert: revert commit abc123` |

### Scope (Opsiyonel)

Değişikliğin hangi modülü etkilediğini belirtir:
- `api` - API endpoints
- `ui` - User interface
- `db` - Database
- `auth` - Authentication
- `email` - Email service
- `docker` - Docker configuration
- vb.

### Subject

- 50 karakter veya daha az
- Küçük harfle başlayın
- Nokta ile bitmeyin
- Emir kipiyle yazın ("add", "fix", "update" gibi)

### Body (Opsiyonel)

- Ne değiştirildiğini ve neden değiştirildiğini açıklayın
- Her satır 72 karakterden az olmalı
- Subject'ten boş bir satır bırakın

### Footer (Opsiyonel)

- Breaking changes: `BREAKING CHANGE: description`
- Issue kapatma: `Closes #123`
- Issue referansı: `Refs #456`

### Örnekler

#### Basit Commit

```
feat(api): add appointment cancellation endpoint
```

#### Detaylı Commit

```
feat(api): add appointment cancellation endpoint

Add new POST /api/appointments/{id}/cancel endpoint that allows
users to cancel their appointments. The endpoint:
- Validates appointment ownership
- Sends cancellation email
- Updates appointment status
- Logs the action

Closes #42
```

#### Breaking Change

```
feat(api)!: change appointment date format to ISO 8601

BREAKING CHANGE: The appointment date field now uses ISO 8601 format
instead of custom format. Update your API calls accordingly.

Migration guide: https://example.com/migration

Closes #58
```

#### Bug Fix

```
fix(ui): resolve mobile navigation menu overflow

The navigation menu was overflowing on devices with width < 768px.
Fixed by:
- Adding proper media queries
- Adjusting z-index values
- Using flexbox for better layout

Fixes #73
```

---

## 🔄 Pull Request Süreci

### 1. Fork ve Clone

```bash
# Fork yapın (GitHub UI'da)
# Clone edin
git clone https://github.com/YOUR-USERNAME/BarberDemo.git
cd BarberDemo

# Upstream ekleyin
git remote add upstream https://github.com/CemRoot/BarberDemo.git
```

### 2. Branch Oluşturma

```bash
# Main branch'i güncelleyin
git checkout main
git pull upstream main

# Feature branch oluşturun
git checkout -b feature/amazing-feature

# veya bug fix için
git checkout -b fix/bug-description
```

Branch isimlendirme:
- `feature/feature-name` - Yeni özellikler
- `fix/bug-name` - Bug düzeltmeleri
- `docs/doc-name` - Dokümantasyon
- `refactor/refactor-name` - Refactoring
- `test/test-name` - Testler

### 3. Kod Yazma ve Test Etme

```bash
# Kod yazın...

# Test edin
dotnet test

# Uygulamayı çalıştırıp kontrol edin
dotnet run

# Code formatting kontrol edin
dotnet format --verify-no-changes
```

### 4. Commit Yapma

```bash
# Değişiklikleri stage'e alın
git add .

# Commit yapın (conventional commits formatında)
git commit -m "feat(api): add new endpoint for X"

# veya detaylı mesaj için
git commit
# Editor açılacak, mesajınızı yazın
```

### 5. Push ve Pull Request

```bash
# Branch'i push edin
git push origin feature/amazing-feature

# GitHub'da Pull Request oluşturun
# PR template'i doldurun
```

### Pull Request Template

PR açtığınızda şu bilgileri ekleyin:

```markdown
## Açıklama
Bu PR'da ne yaptığınızı kısaca açıklayın.

## Değişiklik Tipi
- [ ] Bug fix (non-breaking change which fixes an issue)
- [ ] New feature (non-breaking change which adds functionality)
- [ ] Breaking change (fix or feature that would cause existing functionality to not work as expected)
- [ ] Documentation update

## Nasıl Test Edildi?
Değişikliklerinizi nasıl test ettiğinizi açıklayın.

## Checklist
- [ ] Kodum proje standartlarına uygun
- [ ] Self-review yaptım
- [ ] Kod yorumları ekledim (özellikle anlaşılması zor kısımlarda)
- [ ] Dokümantasyonu güncelledim
- [ ] Değişikliklerim yeni warning oluşturmuyor
- [ ] Test ekledim/güncelledim
- [ ] Testler başarıyla geçiyor

## İlgili Issue'lar
Closes #(issue numarası)
```

### 6. Code Review Süreci

1. **Otomatik Kontroller**: CI/CD pipeline çalışacak
   - Build başarılı mı?
   - Testler geçiyor mu?
   - Code style uygun mu?

2. **Manuel Review**: Maintainer'lar kodunuzu inceleyecek
   - Kod kalitesi
   - Test coverage
   - Dokümantasyon
   - Best practices

3. **Değişiklik Talepleri**: Eğer düzeltme gerekiyorsa
   ```bash
   # Değişiklikleri yapın
   git add .
   git commit -m "fix: address review comments"
   git push origin feature/amazing-feature
   # PR otomatik güncellenecek
   ```

4. **Merge**: Onaylandıktan sonra merge edilecek

---

## 🐛 Issue Raporlama

### Bug Report

Bug bulduğunuzda [bug report template](https://github.com/CemRoot/BarberDemo/issues/new?template=bug_report.md) kullanın.

Şunları ekleyin:

**Bug Açıklaması**
Bug'ın net ve anlaşılır açıklaması.

**Tekrar Etme Adımları**
1. '...' git
2. '....' tıkla
3. '....' kaydır
4. Hatayı gör

**Beklenen Davranış**
Ne olmasını bekliyordunuz?

**Ekran Görüntüleri**
Varsa ekran görüntüleri ekleyin.

**Ortam Bilgileri:**
 - OS: [örn. Windows 11]
 - Browser: [örn. Chrome 120]
 - .NET Version: [örn. 8.0.1]

**Ek Bilgiler**
Başka eklemek istediğiniz bilgiler.

---

## 💡 Feature Request

Yeni özellik önerisi için [feature request template](https://github.com/CemRoot/BarberDemo/issues/new?template=feature_request.md) kullanın.

Şunları ekleyin:

**Özellik Açıklaması**
Özelliğin net açıklaması.

**Probleminiz Nedir?**
Bu özellik hangi problemi çözüyor?

**Önerilen Çözüm**
Özelliğin nasıl çalışmasını istiyorsunuz?

**Alternatifler**
Düşündüğünüz alternatif çözümler var mı?

**Ek Bilgiler**
Mockup, sketch, veya örnek kodlar.

---

## 📬 İletişim

### Sorularınız mı var?

- **GitHub Discussions**: [Soru sorun](https://github.com/CemRoot/BarberDemo/discussions)
- **Email**: [koyluoglu.cem@lll.kpi.ua](mailto:koyluoglu.cem@lll.kpi.ua)
- **Issues**: [Yeni issue açın](https://github.com/CemRoot/BarberDemo/issues/new/choose)

### Maintainer'lar

- **CemRoot** - Project Lead - [@CemRoot](https://github.com/CemRoot)

---

## 🎯 İyi İlk Issue'lar

Projeye yeni mi başlıyorsunuz? Şu etiketlere bakın:

- [`good first issue`](https://github.com/CemRoot/BarberDemo/labels/good%20first%20issue) - Başlangıç için uygun
- [`help wanted`](https://github.com/CemRoot/BarberDemo/labels/help%20wanted) - Yardım aranıyor
- [`documentation`](https://github.com/CemRoot/BarberDemo/labels/documentation) - Dokümantasyon iyileştirmeleri

---

## ⚖️ Lisans

Katkıda bulunarak, katkılarınızın aynı [MIT License](LICENSE) altında lisanslanacağını kabul etmiş olursunuz.

---

## 🙏 Teşekkürler

Katkıda bulunmayı düşündüğünüz için teşekkürler! Her türlü katkı değerlidir:

- 🐛 Bug raporları
- 💡 Özellik önerileri
- 📝 Dokümantasyon iyileştirmeleri
- 💻 Kod katkıları
- ⭐ GitHub'da yıldız vermek
- 🔄 Projeyi paylaşmak

**Mutlu kodlamalar! 🚀**
